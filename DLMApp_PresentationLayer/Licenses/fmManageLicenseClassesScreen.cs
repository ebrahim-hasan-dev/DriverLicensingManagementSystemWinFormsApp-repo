using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmManageLicenseClassesScreen : Form
    {
        // ==============================================

        List<clsLicenseClass> _ListOfLicensesClasses = null;

        byte _LicenseClassID = 0;
        byte _ValidityPeriod = 0;
        byte _MinimumAllowedAge = 0;
        float _LicenseFees = 0;

        // ==============================================

        public fmManageLicenseClassesScreen()
        {
            InitializeComponent();
        }


        async Task LoadAllLicensesClasses()
        {
            _ListOfLicensesClasses = await LicenseService.GetAllLicensesClasses();

            for (byte i = 0; i < _ListOfLicensesClasses.Count; i++)
            {
                cbLicensesClasses.Items.Add(_ListOfLicensesClasses[i].LicenseClass);
            }

            cbLicensesClasses.SelectedIndex = 2;
        }

        private async void fmManageLicenseClassesScreen_Load(object sender, EventArgs e)
        {
            await LoadAllLicensesClasses();

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbManageLicenseClassesScreen);
        }

        void SetAllLicenseClassInfo(clsLicenseClass licenseClass)
        {
            _LicenseClassID = licenseClass.ID;
            _ValidityPeriod = licenseClass.ValidityPeriod;
            _MinimumAllowedAge = licenseClass.MinimumAllowedAge;
            _LicenseFees = licenseClass.Fees;

            lbLicenseDescriptionResult.Text = licenseClass.Description;
            lbLicenseValidityPeriodResult.Text = licenseClass.ValidityPeriod.ToString();
            lbMinimumAllowedAgeResult.Text = licenseClass.MinimumAllowedAge.ToString();
            lbLicenseFeesResult.Text = licenseClass.Fees.ToString();
        }

        private void cbLicensesClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAllLicenseClassInfo(_ListOfLicensesClasses.Find(x => x.LicenseClass == cbLicensesClasses.Text));
            mtxtbNewMinimumAllowedAge.Focus();
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtbNewFees.Text) && string.IsNullOrWhiteSpace(mtxtbNewMinimumAllowedAge.Text) &&
                string.IsNullOrWhiteSpace(mtxtbNewValidityPeriod.Text))
            {
                MessageBox.Show("All boxes are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(mtxtbNewFees.Text))
            {
                _LicenseFees = float.Parse(mtxtbNewFees.Text);
            }

            if (!string.IsNullOrWhiteSpace(mtxtbNewValidityPeriod.Text))
            {
                _ValidityPeriod = byte.Parse(mtxtbNewValidityPeriod.Text);
            }

            if (!string.IsNullOrWhiteSpace(mtxtbNewMinimumAllowedAge.Text))
            {
                _MinimumAllowedAge = byte.Parse(mtxtbNewMinimumAllowedAge.Text);
            }

            if (await LicenseService.UpdateLicenseClass(_LicenseClassID, _LicenseFees, _ValidityPeriod, _MinimumAllowedAge))
            {
                UpdateUI();
                MessageBox.Show("Operation completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Reset();
        }

        void Reset()
        {
            mtxtbNewFees.Clear();
            mtxtbNewMinimumAllowedAge.Clear();
            mtxtbNewValidityPeriod.Clear();
            mtxtbNewMinimumAllowedAge.Focus();
        }

        void UpdateUI()
        {
            lbMinimumAllowedAgeResult.Text = _MinimumAllowedAge.ToString();
            lbLicenseValidityPeriodResult.Text = _ValidityPeriod.ToString();
            lbLicenseFeesResult.Text = _LicenseFees.ToString();

            clsLicenseClass LicenseClass = _ListOfLicensesClasses.Find(x => x.ID == _LicenseClassID);

            LicenseClass.Fees = _LicenseFees;
            LicenseClass.ValidityPeriod = _ValidityPeriod;
            LicenseClass.MinimumAllowedAge = _MinimumAllowedAge;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
