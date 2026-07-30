using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmReleaseDetainedLicenseScreen : Form
    { // ==================================================

        clsApplicationType _ApplicationType = null;
        clsLicense _License = null;

        // ==================================================


        public fmReleaseDetainedLicenseScreen()
        {
            InitializeComponent();
        }

        void Reset()
        {
            lbCreatedByUserResult.Text = "???";
            lbDetainedDateResult.Text = "???";
            lbFineResult.Text = "???";
            lbReasonResult.Text = "???";

            uctrlLisenseInfo1.Reset();
        }

        void FillDetainedLicenseInfo(clsDetainedLicenseInfo DetainedLicenseInfo)
        {
            lbCreatedByUserResult.Text = DetainedLicenseInfo.CreatedByUser;
            lbDetainedDateResult.Text = DetainedLicenseInfo.DetainedDate.ToString("d-M-yyyy");
            lbFineResult.Text = DetainedLicenseInfo.Fine.ToString();
            lbReasonResult.Text = DetainedLicenseInfo.Reasson;

            lbTotalFeesResult.Text = (float.Parse(lbFineResult.Text) + float.Parse(uctrlApplicationInfo1.lbApplicationFeesResult.Text)).ToString();
        }

        private async void btFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtxtbLicenseID.Text))
            {
                Reset();
                
                _License = await LicenseService.Find(int.Parse(mtxtbLicenseID.Text));

                if (_License != null)
                {
                    clsDetainedLicenseInfo DetainedLicenseInfo = await DetainedLicenseService.GetDetainedLicenseInfo(_License.ID);

                    if (DetainedLicenseInfo != null)
                    {
                        if (_License.IsActive)
                        {
                            FillDetainedLicenseInfo(DetainedLicenseInfo);

                            btRelease.Enabled = true;
                            this.AcceptButton = btRelease;
                        }
                        else
                        {
                            MessageBox.Show("This license is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This license is not detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong License ID", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtxtbLicenseID.Clear();
                }
            }
            else
            {
                MessageBox.Show("License ID is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btRelease_Click(object sender, EventArgs e)
        {
            clsApplication Application = Utility.FillAndGetApplication(_License.PersonInfo.PersonID, enApplicationStatus.Completed,
                enApplicationTypes.ReleaseDetainedLicense, _ApplicationType.ApplicationTypeFees, clsGlobal.CurrentUser.UserID);

            if (await ApplicationService.AddNewApplication(Application))
            {
                if (await DetainedLicenseService.ReleaseDetainedLicense(_License.ID, clsGlobal.CurrentUser.UserID, Application.ApplicationID))
                {
                    _License.IsDetained = false;

                    MessageBox.Show("The operation was completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    uctrlApplicationInfo1.lbApplicationIDResult.Text = Application.ApplicationID.ToString();

                    await uctrlLisenseInfo1.SetLicenseInfo(_License, _License.ApplicationID, _License.LicenseClass);

                    mtxtbLicenseID.Clear();

                    btRelease.Enabled = false;

                    this.AcceptButton = btFind;

                    mtxtbLicenseID.Focus();
                }
            }
        }

        private async void fmReleaseDetainedLicenseScreen_Load(object sender, EventArgs e)
        {
            _ApplicationType = await ApplicationService.GetApplicationType(enApplicationTypes.ReleaseDetainedLicense);

            uctrlApplicationInfo1.SetApplicationInfo(_ApplicationType);

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbReleaseDetainedLicenseScreen);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }




    }
}
