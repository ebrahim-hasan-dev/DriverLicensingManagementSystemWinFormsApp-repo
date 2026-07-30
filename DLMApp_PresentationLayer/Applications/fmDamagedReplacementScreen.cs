using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmDamagedReplacementScreen : Form
    {
        // ==================================================

        clsApplicationType _ApplicationType = null;

        // ==================================================


        public fmDamagedReplacementScreen()
        {
            InitializeComponent();
        }


        private async void btIssue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtxtbLicenseID.Text))
            {
                uctrlLisenseInfo1.Reset();

                int LicenseID = int.Parse(mtxtbLicenseID.Text);

                clsLicense License = await LicenseService.Find(LicenseID);

                if (License != null)
                {
                    if (LicenseService.IsLicenseValidAndActive(License) == true)
                    {
                        if (License.IsDetained == false)
                        {
                            clsApplication Application = Utility.FillAndGetApplication(License.PersonInfo.PersonID, enApplicationStatus.Completed,
                            enApplicationTypes.ReplacementForDamagedLicense, _ApplicationType.ApplicationTypeFees, clsGlobal.CurrentUser.UserID);

                            if (await ApplicationService.AddNewApplication(Application))
                            {
                                LicenseService.UpdateToReplaceDamagedOrReplaceLost(License, Application.ApplicationID, clsGlobal.CurrentUser.UserID, enLicenseStatus.DamagedReplacement);

                                if (await LicenseService.AddNewLicense(License))
                                {
                                    MessageBox.Show("The operation was completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    uctrlApplicationInfo1.lbApplicationIDResult.Text = Application.ApplicationID.ToString();

                                    mtxtbLicenseID.Clear();

                                    await uctrlLisenseInfo1.SetLicenseInfo(License, Application.ApplicationID, License.LicenseClassInfo.LicenseClass);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("This license is detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The operation faild,\nthe license expired or inactive.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            mtxtbLicenseID.Focus();
        }

        private async void fmDamagedReplacementScreen_Load(object sender, EventArgs e)
        {
            _ApplicationType = await ApplicationService.GetApplicationType(enApplicationTypes.ReplacementForDamagedLicense);

            uctrlApplicationInfo1.SetApplicationInfo(_ApplicationType);

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbDamagedReplacementScreen);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
