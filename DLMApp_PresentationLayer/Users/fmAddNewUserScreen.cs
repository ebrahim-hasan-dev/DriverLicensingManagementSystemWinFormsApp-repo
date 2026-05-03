using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLMApp_PresentationLayer
{
    public partial class fmAddNewUserScreen : Form
    {
        // ================================================

        public event Action<clsUser> AddedEventHandler;

        // ================================================


        public fmAddNewUserScreen()
        {
            InitializeComponent();
        }

        protected virtual void OnAddedEventHandler(clsUser User)
        {
            AddedEventHandler?.Invoke(User);
        }


        private void fmAddNewUserScreen_Load(object sender, EventArgs e)
        {
            uctrlAddOrUpdatePerson1.btSave.Location = new Point(uctrlAddOrUpdatePerson1.Width + 50, 0); 
        }

        void FillUser(clsUser User)
        {
            User.UserName = txtbUserName.Text;
            User.Password = txtbPassword.Text;
            User.IsActive = chbActive.Checked;
            User.PersonID = uctrlAddOrUpdatePerson1.PersonID;
        }

        void Reset()
        {
            txtbConfirmPassword.Clear();
            txtbPassword.Clear();
            txtbUserName.Clear();

            chbActive.Checked = true;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbConfirmPassword.Text) && !string.IsNullOrWhiteSpace(txtbPassword.Text) &&
                !string.IsNullOrWhiteSpace(txtbUserName.Text))
            {
                if (txtbConfirmPassword.Text == txtbPassword.Text)
                {
                    uctrlAddOrUpdatePerson1.btSave.PerformClick();

                    if (uctrlAddOrUpdatePerson1.AddedSuccessfully == true)
                    {
                        clsUser User = new clsUser();

                        FillUser(User);

                        if (UserService.AddNewUser(User))
                        {
                            MessageBox.Show($"Operation completed successfully with ID ({User.UserID})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            OnAddedEventHandler(User);

                            Reset();
                        }
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

        private void txtbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbUserName.Text))
            {
                if (UserService.UserNameExist(txtbUserName.Text) == true)
                {
                    errorProvider1.SetError(txtbUserName, $"This user name ({txtbUserName.Text}) is already exist");
                    btSave.Enabled = false;
                }
                else
                {
                    errorProvider1.SetError(txtbUserName, "");
                    btSave.Enabled = true;
                }
            }
        }







    }
}
