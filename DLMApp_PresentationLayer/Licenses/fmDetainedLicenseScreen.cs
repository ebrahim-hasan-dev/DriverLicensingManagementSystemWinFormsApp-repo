using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmDetainedLicenseScreen : Form
    {
        public fmDetainedLicenseScreen()
        {
            InitializeComponent();
        }

        private void fmDetainedLicenseScreen_Load(object sender, EventArgs e)
        {
            dtpDetainedDate.MaxDate = DateTime.Now.Date;
            dtpDetainedDate.Value = DateTime.Now.Date;

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbDetainedLicenseScreen);
        }

        void Reset()
        {
            mtxtbFine.Clear();
            mtxtbLicenseID.Clear();
            txtbReason.Clear();
            dtpDetainedDate.Value = DateTime.Now.Date;

            mtxtbFine.Focus();
        }

        private async void btDetained_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtxtbFine.Text) && !string.IsNullOrWhiteSpace(mtxtbLicenseID.Text) &&
                !string.IsNullOrWhiteSpace(txtbReason.Text))
            {
                clsLicense license = await LicenseService.Find(int.Parse(mtxtbLicenseID.Text));

                if (license != null)
                {
                    if (license.IsDetained == false)
                    {
                        if (license.IsActive)
                        {
                            if (float.Parse(mtxtbFine.Text) > 0)
                            {
                                if (await DetainedLicenseService.AddDetainedLicense(license.ID, float.Parse(mtxtbFine.Text), txtbReason.Text,
                                    dtpDetainedDate.Value, clsGlobal.CurrentUser.UserID))
                                {
                                    MessageBox.Show("The operation was completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Reset();
                                }
                            }
                            else
                            {
                                MessageBox.Show("The fine must be bigger than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("This license is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This license is already detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("One of the requirement is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mtxtbLicenseID.Focus();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
