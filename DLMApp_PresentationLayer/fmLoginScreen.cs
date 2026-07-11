
using DLMApp_BusinessLayer;
using System;
using System.Security.Cryptography; // مخصصة للتشفير
using System.Text;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmLoginScreen : Form
    {
        public fmLoginScreen()
        {
            InitializeComponent();
        }

        
        public static void ShowMissingMessage()
        {
            MessageBox.Show("One of the requirements is missing", "Missing",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbUserName.Text) && !string.IsNullOrWhiteSpace(txtbPassword.Text))
            {
                clsGlobal.CurrentUser = UserService.Find(txtbUserName.Text, txtbPassword.Text);

                if (clsGlobal.CurrentUser == null)
                {
                    MessageBox.Show("Incorrect Password or Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (clsGlobal.CurrentUser.IsActive)
                    {
                        txtbUserName.Clear();
                        txtbPassword.Clear();
                        txtbUserName.Focus();

                        RememberMe();

                        this.Hide();

                        fmMainScreen MainScreen = new fmMainScreen(this);
                        MainScreen.Show();
                    }
                    else
                    {
                        clsGlobal.CurrentUser = null;

                        MessageBox.Show("Your account is inactive", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                ShowMissingMessage();
            }
        }

        void RememberMe()
        {
            if (chbRememberMe.Checked)
            {
                // تحويل النص إلى مصفوفة بايتات (Bytes)
                byte[] PasswordBytes = Encoding.UTF8.GetBytes(clsGlobal.CurrentUser.Password);
                byte[] UsernameBytes = Encoding.UTF8.GetBytes(clsGlobal.CurrentUser.UserName);

                // تشفير البيانات باستخدام DPAPI 
                // المفتاح السري للتشفير هنا مدمج ومخفي جوة نظام الويندوز نفسه ومربوط بالمستخدم الحالي
                byte[] EncryptedBytesPasswprd = ProtectedData.Protect(PasswordBytes, null, DataProtectionScope.CurrentUser);
                byte[] EncryptedBytesUsename = ProtectedData.Protect(UsernameBytes, null, DataProtectionScope.CurrentUser);

                Properties.Settings.Default.Username = Convert.ToBase64String(EncryptedBytesUsename);
                Properties.Settings.Default.Password = Convert.ToBase64String(EncryptedBytesPasswprd);
            }
            else
            {
                Properties.Settings.Default.Username = null;
                Properties.Settings.Default.Password = null;
            }
            
            Properties.Settings.Default.Save();
        }

        private void fmLoginScreen_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbLoginScreen);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberMe = chbRememberMe.Checked;
            Properties.Settings.Default.Save();
        }

        private void fmLoginScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Unprotected();

                chbRememberMe.Checked = Properties.Settings.Default.RememberMe;
            }
        }

        private void Unprotected()
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Username) && !string.IsNullOrWhiteSpace(Properties.Settings.Default.Password))
            {
                byte[] SavedBytesUsername = Convert.FromBase64String(Properties.Settings.Default.Username);
                byte[] SavedBytesPassword = Convert.FromBase64String(Properties.Settings.Default.Password);

                // فك التشفير ليعود لمصفوفة بايتات
                byte[] DecryptedBytesUsername = ProtectedData.Unprotect(SavedBytesUsername, null, DataProtectionScope.CurrentUser);
                byte[] DecryptedBytesPassword = ProtectedData.Unprotect(SavedBytesPassword, null, DataProtectionScope.CurrentUser);

                // تحويل البايتات إلى النص الأصلي
                txtbUserName.Text = Encoding.UTF8.GetString(DecryptedBytesUsername);
                txtbPassword.Text = Encoding.UTF8.GetString(DecryptedBytesPassword);
            }
        }
        


    }
}
