using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmLostReplacementScreen : Form
    {
        // ==========================================================

        List<clsLicenseClass> _ListOfLicensesClasses = null;
        byte _LicenseClassID = 0;
        clsApplicationType _ApplicationType = null;

        // ==========================================================


        public fmLostReplacementScreen()
        {
            InitializeComponent();
        }

       
        async Task LoadAllLicensesClasses()
        {
            _ListOfLicensesClasses = await LicenseService.GetAllLicensesClasses();

            for (int i = 0; i < _ListOfLicensesClasses.Count; i++)
            {
                cbLicensesClasses.Items.Add(_ListOfLicensesClasses[i].LicenseClass);
            }

            cbLicensesClasses.SelectedIndex = 2;
        }

        private async void fmLostReplacementScreen_Load(object sender, EventArgs e)
        {
            await LoadAllLicensesClasses();

            _ApplicationType = await ApplicationService.GetApplicationType(enApplicationTypes.ReplacementForLostLicense);

            uctrlApplicationInfo1.SetApplicationInfo(_ApplicationType);

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbLostReplacementScreen);
        }

        private void cbLicensesClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LicenseClassID = _ListOfLicensesClasses.Find(x => x.LicenseClass == cbLicensesClasses.Text).ID;
        }
       
        private async void btIssue_Click(object sender, EventArgs e)
        {
            if (mtxtbNationalNumber.MaskCompleted)
            {
                uctrlLisenseInfo1.Reset();

                clsPerson Person = await PersonService.FindByNationalNumber(mtxtbNationalNumber.Text);

                if (Person != null)
                {
                    clsLicense License = await LicenseService.FindActiveAndValidLicense(Person.PersonID, _LicenseClassID);

                    if (License != null)
                    {
                        if (License.IsDetained == false)
                        {
                            clsApplication Application = Utility.FillAndGetApplication(Person.PersonID, enApplicationStatus.Completed,
                                enApplicationTypes.ReplacementForLostLicense, _ApplicationType.ApplicationTypeFees, clsGlobal.CurrentUser.UserID);

                            if (await ApplicationService.AddNewApplication(Application))
                            {
                                LicenseService.UpdateToReplaceDamagedOrReplaceLost(License, Application.ApplicationID, clsGlobal.CurrentUser.UserID,
                                    enLicenseStatus.LostReplacement);

                                if (await LicenseService.AddNewLicense(License))
                                {
                                    MessageBox.Show("The operation was completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    uctrlApplicationInfo1.lbApplicationIDResult.Text = Application.ApplicationID.ToString();

                                    await uctrlLisenseInfo1.SetLicenseInfo(License, Application.ApplicationID, cbLicensesClasses.Text);

                                    mtxtbNationalNumber.Clear();
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
                        MessageBox.Show($"This person does not possess a license of this type ({cbLicensesClasses.Text}) or,\nthe license expired or inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong National Number", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtxtbNationalNumber.Clear();
                }
            }
            else
            {
                MessageBox.Show("National Number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mtxtbNationalNumber.Focus();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
