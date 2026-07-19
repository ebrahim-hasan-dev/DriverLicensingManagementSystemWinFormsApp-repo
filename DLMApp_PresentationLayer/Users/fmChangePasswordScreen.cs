using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Windows.Forms;



namespace DLMApp_PresentationLayer
{
    public partial class fmChangePasswordScreen : Form
    {
        // ===========================================

        clsPerson _Person = null;
        clsUser _User = null;

        // ===========================================


        public fmChangePasswordScreen(clsUser User, clsPerson Person)
        {
            InitializeComponent();

            _User = User;
            _Person = Person;
        }


        void Reset()
        {
            txtbConfirmNewPassword.Clear();
            txtbNewPassword.Clear();
            txtbCurrentPassword.Clear();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbConfirmNewPassword.Text) && !string.IsNullOrWhiteSpace(txtbNewPassword.Text) &&
               !string.IsNullOrWhiteSpace(txtbCurrentPassword.Text))
            {
                if (txtbConfirmNewPassword.Text == txtbNewPassword.Text)
                {
                    if (clsGlobal.VerifyPassword(txtbCurrentPassword.Text, _User.Password))
                    {
                        string HashPassword = clsGlobal.HashPassword(txtbNewPassword.Text);

                        if (UserService.ChangePassword(_User.UserID, HashPassword))
                        {
                            _User.Password = txtbNewPassword.Text;

                            MessageBox.Show("Operation save completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password and confirm password not same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("One of requirments is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmUdateUserScreen_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbChangePasswordScreen);

            uctrlPersonInfo1.SetPersonInfo(_Person);

            lbUsernameResult.Text = _User.UserName;

            if (_User.IsActive)
                lbIsActiveResult.Text = "Yes";
            else
                lbIsActiveResult.Text = "No";
        }









    }
}
