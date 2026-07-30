using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmRenewLicenseScreen : Form
    {
        // ============================================

        clsApplicationType _ApplicationType = null;
        clsLicense _License = null;
        // ============================================


        public fmRenewLicenseScreen()
        {
            InitializeComponent();
        }

        private async void fmRenewLicenseScreen_Load(object sender, EventArgs e)
        {
            _ApplicationType = await ApplicationService.GetApplicationType(enApplicationTypes.RenewLicense);

            uctrlApplicationInfo1.SetApplicationInfo(_ApplicationType);

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbRenewLicenseScreen);
        }

        private async void btFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtxtbLicenseID.Text))
            {
                uctrlLisenseInfo1.Reset();

                _License = await LicenseService.Find(int.Parse(mtxtbLicenseID.Text));

                if (_License != null)
                {
                    await uctrlLisenseInfo1.SetLicenseInfo(_License, _License.ApplicationID, _License.LicenseClassInfo.LicenseClass);

                    if (_License.IsValid() == false)
                    {
                        if (_License.IsActive == true)
                        {
                            btSave.Enabled = true;
                            this.AcceptButton = btSave;
                        }
                        else
                        {
                            MessageBox.Show("The license must be active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The license must be expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong License ID", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("License ID is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            clsApplication Application = Utility.FillAndGetApplication(_License.PersonInfo.PersonID, enApplicationStatus.New, enApplicationTypes.RenewLicense,
                _ApplicationType.ApplicationTypeFees, clsGlobal.CurrentUser.UserID);

            if (await ApplicationService.AddNewApplication(Application))
            {
                uctrlApplicationInfo1.lbApplicationIDResult.Text = Application.ApplicationID.ToString();

                MessageBox.Show($"The Save operation successfully with Application ID ({Application.ApplicationID})", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                fmTestsScreen testsScreen = new fmTestsScreen(Application.ApplicationID, _License.PersonInfo);

                this.Close();

                testsScreen.ShowDialog();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
