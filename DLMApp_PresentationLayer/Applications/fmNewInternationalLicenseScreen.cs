using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmNewInternationalLicenseScreen : Form
    {
        // ==================================================

        clsApplicationType _ApplicationType = null;

        // ==================================================


        public fmNewInternationalLicenseScreen()
        {
            InitializeComponent();
        }

        
        void FillInternationalLicense(clsInternationalLicense internationalLicense, clsLicense License, int ApplicationID)
        {
            internationalLicense.LocalLicenseID = License.ID;
            internationalLicense.DriverID = License.DriverID;
            internationalLicense.ReleaseDate = DateTime.Now;
            internationalLicense.EndDate = InternationalLicenseService.CalcEndDate(internationalLicense.ReleaseDate);
            internationalLicense.IsActive = true;
            internationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            internationalLicense.ApplicationID = ApplicationID;
        }

        private async void btIssue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtxtbLocalLicenseID.Text))
            {
                uctrlInternationalLicenseInfo1.Reset();

                int LocalLicenseID = int.Parse(mtxtbLocalLicenseID.Text);

                clsLicense License = await LicenseService.Find(LocalLicenseID);

                if (License != null)
                {
                    if (LicenseService.IsLicenseValidAndActive(License) == true)
                    {
                        if (License.IsDetained == false)
                        {
                            if (License.IsThirdClass() == true)
                            {
                                clsApplication Application = Utility.FillAndGetApplication(License.PersonInfo.PersonID, enApplicationStatus.Completed,
                                    enApplicationTypes.NewInternationalLicense, _ApplicationType.ApplicationTypeFees, clsGlobal.CurrentUser.UserID);

                                if (await ApplicationService.AddNewApplication(Application))
                                {
                                    clsInternationalLicense internationalLicense = new clsInternationalLicense();

                                    FillInternationalLicense(internationalLicense, License, Application.ApplicationID);

                                    if (await InternationalLicenseService.AddNewInternationalLicense(internationalLicense))
                                    {
                                        MessageBox.Show("The operation was completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        uctrlApplicationInfo1.lbApplicationIDResult.Text = Application.ApplicationID.ToString();

                                        await uctrlInternationalLicenseInfo1.SetLicenseInfo(internationalLicense, License.PersonInfo, Application.ApplicationID);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("This person holds an active international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"The local license must be of class three ({enLicenseClasses.Class3_Ordinarydriving})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The local license is detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The operation faild,\nthe license expired or inactive.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Local License ID", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtxtbLocalLicenseID.Clear();
                    mtxtbLocalLicenseID.Focus();
                }
            }
            else
            {
                MessageBox.Show("License ID is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mtxtbLocalLicenseID.Focus();
        }

        private async void fmNewInternationalLicenseScreen_Load(object sender, EventArgs e)
        {
            _ApplicationType = await ApplicationService.GetApplicationType(enApplicationTypes.NewInternationalLicense);

            uctrlApplicationInfo1.SetApplicationInfo(_ApplicationType);

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbIssuingNewInternationalLicenseScreen);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
