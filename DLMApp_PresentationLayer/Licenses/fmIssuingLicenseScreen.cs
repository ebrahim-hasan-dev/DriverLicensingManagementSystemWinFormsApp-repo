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
    public partial class fmIssuingLicenseScreen : Form
    {
        // ===========================================================

        clsLicenseClass _LicenseClass = null;
        clsLicense _License = null;
        int _ApplicationID = 0;
        int _PersonID = 0;
        bool _IsNewLicense = false;

        // ===========================================================


        public fmIssuingLicenseScreen(bool IsNewLicense)
        {
            _IsNewLicense = IsNewLicense;

            InitializeComponent();
        }

        public fmIssuingLicenseScreen(bool IsNewLicense, int ApplicationID)
        {
            InitializeComponent();

            _IsNewLicense = IsNewLicense;

            mtxtxbApplicationID.Text = ApplicationID.ToString();
            mtxtxbApplicationID.Enabled = false;
        }


        void FillLicense(clsLicense license, clsPerson Person)
        {
            license.DriverID = DriverService.GetDriverID(Person.PersonID);

            if (license.DriverID == 0)
            {
                license.DriverID = DriverService.AddNewDriver(_PersonID, clsGlobal.CurrentUser.UserID);
            }

            license.Notes = txtbNotes.Text;

            license.ImagePath = Person.ImagePath;
            license.ReleaseDate = DateTime.Now;
            license.EndDate = LicenseService.CalcEndDate(license.ReleaseDate, _LicenseClass.ValidityPeriod);
            license.IsActive = true;
            license.IsDetained = false;
            license.LicenseFees = _LicenseClass.Fees;
            license.LicenseStatusID = enLicenseStatus.New;
            license.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            license.ApplicationID = _ApplicationID;
            license.LicenseClassID = _LicenseClass.ID;
        }
        
        void IssueNewLicenseProcess()
        {
            if (LicenseService.DoesHaveLicenseOfSameClass(_PersonID, _LicenseClass.ID) == false)
            {
                clsPerson Person = PersonService.FindByPersonID(_PersonID);

                if (EnrollmentService.IsPassedInAllTests(_ApplicationID) == true)
                {
                    if (_PersonID > 0 && Person != null)
                    {
                        clsLicense license = new clsLicense();

                        FillLicense(license, Person);

                        if (LicenseService.AddNewLicense(license))
                        {
                            MessageBox.Show($"License Added Successfully with License ID {license.ID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            uctrlLisenseInfo1.SetLicenseInfo(license, _ApplicationID, _LicenseClass.LicenseClass);

                            mtxtxbApplicationID.Clear();
                            mtxtxbApplicationID.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("One of the tests was not passed successfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("This person have license of same class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillRenewLicense(clsLicense license)
        {
            license.Notes = txtbNotes.Text;

            license.ReleaseDate = DateTime.Now;
            license.EndDate = LicenseService.CalcEndDate(license.ReleaseDate, license.LicenseClassInfo.ValidityPeriod);
            license.IsActive = true;
            license.IsDetained = false;
            license.LicenseFees = license.LicenseClassInfo.Fees;
            license.LicenseStatusID = enLicenseStatus.Renew;
            license.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            license.ApplicationID = _ApplicationID;
        }

        void IssueRenewLicenseProcess()
        {
            if (_License.IsValid() == false)
            {
                if (_License.IsActive == true)
                {
                    if (EnrollmentService.IsPassedInVisionTestRenewLicense(_ApplicationID) == true)
                    {
                        FillRenewLicense(_License);

                        if (LicenseService.AddNewLicense(_License))
                        {
                            MessageBox.Show($"License Added Successfully with License ID {_License.ID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            uctrlLisenseInfo1.SetLicenseInfo(_License, _ApplicationID, _License.LicenseClass);

                            mtxtxbApplicationID.Clear();
                            mtxtbLicenseID.Clear();
                            mtxtxbApplicationID.Focus();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("This person failed in vision test", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void btIssue_Click(object sender, EventArgs e)
        {
            btIssue.Enabled = false;
            txtbNotes.Enabled = false;
            this.AcceptButton = btSearch;

            if (_IsNewLicense)
            {
                IssueNewLicenseProcess();
            }
            else
            {
                IssueRenewLicenseProcess();
            }
        }

        void Reset()
        {
            lbLicenseClassResult.Text = "???";
            lbLicenseFeesResult.Text = "???";

            txtbNotes.Clear();

            uctrlLisenseInfo1.Reset();
        }

        void SearchNewLicenseProcess()
        {
            Reset();

            _ApplicationID = int.Parse(mtxtxbApplicationID.Text);

            if (ApplicationService.IsStatusNew(_ApplicationID))
            {
                _LicenseClass = LicenseService.GetLicenseClass(_ApplicationID, ref _PersonID);

                if (_LicenseClass != null)
                {
                    lbLicenseClassResult.Text = _LicenseClass.LicenseClass;
                    lbLicenseFeesResult.Text = _LicenseClass.Fees.ToString();

                    btIssue.Enabled = true;
                    txtbNotes.Enabled = true;
                    this.AcceptButton = btIssue;
                }
                else
                {
                    MessageBox.Show($"This application {_ApplicationID} not for new local license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Application status cancelled or completed or not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SearchRenewNewLicenseProcess()
        {
            if (!string.IsNullOrWhiteSpace(mtxtbLicenseID.Text))
            {
                Reset();

                _ApplicationID = int.Parse(mtxtxbApplicationID.Text);

                if (ApplicationService.IsStatusNew(_ApplicationID))
                {
                    _License = LicenseService.Find(int.Parse(mtxtbLicenseID.Text));
                    
                    if (_License != null)
                    {
                        lbLicenseClassResult.Text = _License.LicenseClassInfo.LicenseClass;
                        lbLicenseFeesResult.Text = _License.LicenseClassInfo.Fees.ToString();

                        btIssue.Enabled = true;
                        txtbNotes.Enabled = true;
                        this.AcceptButton = btIssue;
                    }
                    else
                    {
                        MessageBox.Show("Wrong License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Application status cancelled or completed not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("License ID is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtxtxbApplicationID.Text))
            {
                if (_IsNewLicense)
                {
                    SearchNewLicenseProcess();
                }
                else
                {
                    SearchRenewNewLicenseProcess();
                }
            }
            else
            {
                MessageBox.Show("Application ID is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fmIssuingNewLicenseScreen_Load(object sender, EventArgs e)
        {
            if (_IsNewLicense == false)
            {
                lbEnterLicenseID.Visible = true;
                mtxtbLicenseID.Visible = true;
                pictureBox1.Visible = true;

                lbIssuingLicenseScreen.Text = "Issuing Renew License Screen";
            }
            else
            {
                lbIssuingLicenseScreen.Text = "Issuing New License Screen";
            }

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbIssuingLicenseScreen);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
