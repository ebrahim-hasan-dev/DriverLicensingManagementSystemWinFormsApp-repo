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
    public partial class fmNewLocalLicenseScreen : Form
    {
        // ================================================================================================

        clsPerson _Person = null;

        List<clsLicenseClass> _ListOfLicensesClasses = null;

        byte _LicenseClassID = 0;

        float _ApplicationFees = 0;

        bool _IsNewPerson = false;

        // ================================================================================================

        void SetPersonInfo(clsPerson person)
        {
            _Person = person;

            uctrlPersonInfo1.SetPersonInfo(_Person);

            _IsNewPerson = true;
        }

        public fmNewLocalLicenseScreen()
        {
            InitializeComponent();
        }

        private void llbAddNewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmAdd_UpdatePersonScreen Add_UpdatePersonScreen = new fmAdd_UpdatePersonScreen();

            Add_UpdatePersonScreen.AddedEventHandler += SetPersonInfo;

            Add_UpdatePersonScreen.ShowDialog();
        }

        void LoadAllLicensesClasses()
        {
            _ListOfLicensesClasses = LicenseService.GetAllLicensesClasses();

            for (int i = 0; i < _ListOfLicensesClasses.Count; i++)
            {
                cbLicensesClasses.Items.Add(_ListOfLicensesClasses[i].LicenseClass);
            }

            cbLicensesClasses.SelectedIndex = 2;
        }

        private void fmNewLocalLicense_Load(object sender, EventArgs e)
        {
            clsApplicationType ApplicationType = ApplicationService.GetApplicationType(enApplicationTypes.NewLocalLicense);
            uctrlApplicationInfo1.SetApplicationInfo(ApplicationType);
            _ApplicationFees = ApplicationType.ApplicationTypeFees;

            this.AcceptButton = btNext;

            LoadAllLicensesClasses();

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbNewLocalLicenseScreen);
        }
       
        private void btNext_Click(object sender, EventArgs e)
        {
            tabcNewLocalLicense.SelectedTab = tabpApplicationInfo;
            this.AcceptButton = btSave;
        }

        void SetAllLicenseClassInfo(clsLicenseClass licenseClass)
        {
            _LicenseClassID = licenseClass.ID;

            lbLicenseDescriptionResult.Text = licenseClass.Description;
            lbLicenseValidityPeriodResult.Text = licenseClass.ValidityPeriod.ToString();
            lbMinimumAllowedAgeResult.Text = licenseClass.MinimumAllowedAge.ToString();
        }

        private void cbLicensesClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAllLicenseClassInfo(_ListOfLicensesClasses.Find(x => x.LicenseClass == cbLicensesClasses.Text));
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (_Person != null)
            {
                if (LicenseService.IsAllowedAge(_Person.DateOfBirth, byte.Parse(lbMinimumAllowedAgeResult.Text)))
                {
                    if (_ApplicationFees > 0 && _LicenseClassID > 0)
                    {
                        if (_IsNewPerson == false)
                        {
                            if (LicenseService.DoesHaveLicenseOfSameClass(_Person.PersonID, _LicenseClassID))
                            {
                                MessageBox.Show("This person has license of same class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            int ApplicationID = ApplicationService.DoesHaveApplicationOfSameLicenseClassForNewLocalLicenseStatusNew(_Person.PersonID, _LicenseClassID);

                            if (ApplicationID != 0)
                            {
                                MessageBox.Show($"This person has a new local license application of same license class, its status is new and its ID is ({ApplicationID})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        clsNewLocalLicenseApplication newLocalLicenseApplication = new clsNewLocalLicenseApplication();

                        newLocalLicenseApplication.ApplicationInfo = Utility.FillAndGetApplication(_Person.PersonID, enApplicationStatus.New, enApplicationTypes.NewLocalLicense,
                            _ApplicationFees, clsGlobal.CurrentUser.UserID);

                        newLocalLicenseApplication.LicenseClassID = (enLicenseClasses)_LicenseClassID;

                        if (ApplicationService.AddNewLocalLicenseApplication(newLocalLicenseApplication))
                        {
                            uctrlApplicationInfo1.lbApplicationIDResult.Text = newLocalLicenseApplication.ApplicationInfo.ApplicationID.ToString();
                            MessageBox.Show($"The Save operation successfully with Application ID ({newLocalLicenseApplication.ApplicationInfo.ApplicationID})", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();

                            fmTestsScreen TestsScreen = new fmTestsScreen(newLocalLicenseApplication.ApplicationInfo.ApplicationID, newLocalLicenseApplication.NewLocalLicenseApplicationID, _Person);

                            this.Close();

                            TestsScreen.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("The Save operation failed", "Failed",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Save operation failed", "Failed",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Age is not allowed", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (_IsNewPerson)
                    {
                        PersonService.DeleteByID(_Person.PersonID);
                    }
                }
            }
            else
            {
                MessageBox.Show("Find or Add Person first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (mtxtbNationalNumber.MaskCompleted)
            {
                _Person = PersonService.FindByNationalNumber(mtxtbNationalNumber.Text);

                if (_Person != null)
                {
                    uctrlPersonInfo1.SetPersonInfo(_Person);
                    _IsNewPerson = false;
                    this.AcceptButton = btNext;
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







    }
}
