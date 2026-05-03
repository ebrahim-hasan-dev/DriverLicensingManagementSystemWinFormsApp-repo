
using System;
using System.Windows.Forms;
using DLMApp_BusinessLayer;


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
                Properties.Settings.Default.Username = clsGlobal.CurrentUser.UserName;
                Properties.Settings.Default.Password = clsGlobal.CurrentUser.Password;
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
                txtbUserName.Text = Properties.Settings.Default.Username;
                txtbPassword.Text = Properties.Settings.Default.Password;

                chbRememberMe.Checked = Properties.Settings.Default.RememberMe;
            }
        }


        


    }
}
