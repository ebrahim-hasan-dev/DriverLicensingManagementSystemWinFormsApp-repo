using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmFindPersonScreen : Form
    {
        // ======================================

        clsPerson _Person = null;

        // ======================================


        public fmFindPersonScreen()
        {
            InitializeComponent();
        }

        private void fmFindPersonScreen_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbFindPersonScreen);
        }

        private async void btSearch_Click(object sender, EventArgs e)
        {
            if (mtxtbNationalNumber.MaskCompleted)
            {
                _Person = await PersonService.FindByNationalNumber(mtxtbNationalNumber.Text);

                if (_Person != null)
                {
                    await uctrlPersonInfo1.SetPersonInfo(_Person);

                    btSave.Enabled = true;
                    this.AcceptButton = btSave;
                    txtbUserName.Focus();
                }
                else
                {
                    MessageBox.Show($"not found Person with national number like this {mtxtbNationalNumber.Text}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The field is empty or not completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FillUser(clsUser User)
        {
            User.UserName = txtbUserName.Text;

            User.Password = PasswordManager.HashPassword(txtbPassword.Text);
            
            User.IsActive = chbActive.Checked;
            User.PersonID = _Person.PersonID;
        }

        void Reset()
        {
            txtbConfirmPassword.Clear();
            txtbPassword.Clear();
            txtbUserName.Clear();
            mtxtbNationalNumber.Clear();
            mtxtbNationalNumber.Focus();

            chbActive.Checked = true;

            btSave.Enabled = false;
            
            this.AcceptButton = btSearch;

            uctrlPersonInfo1.Reset();
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbConfirmPassword.Text) && !string.IsNullOrWhiteSpace(txtbPassword.Text) &&
               !string.IsNullOrWhiteSpace(txtbUserName.Text))
            {
                if (_Person != null)
                {
                    if (txtbConfirmPassword.Text == txtbPassword.Text)
                    {
                        if (await UserService.PersonIDExist(_Person.PersonID) == false)
                        {
                            clsUser User = new clsUser();

                            FillUser(User);

                            if (await UserService.AddNewUser(User))
                            {
                                MessageBox.Show($"Operation completed successfully with ID ({User.UserID})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Reset();
                            }
                        }
                        else
                        {
                            MessageBox.Show("This person already have account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and confirm password not same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Find person first then click save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("One of requirments is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
