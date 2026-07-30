using DLMApp_ModulesLayer;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class uctrlInternationalLicenseInfo : UserControl
    {
        public uctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private void uctrlInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbInternationalLicenseInfo);
        }


        public async Task SetLicenseInfo(clsInternationalLicense InternationalLicense, clsPerson Person, int ApplicationID)
        {
            lbApplicationIDResult.Text = ApplicationID.ToString();
            lbDateOfBirthResult.Text = Person.DateOfBirth.ToString("d-M-yyyy");
            lbDriverIDResult.Text = InternationalLicense.DriverID.ToString();
            lbGenderResult.Text = Person.Gender.ToString();

            if (InternationalLicense.IsActive)
                lbIsActiveResult.Text = "Yes";
            else
                lbIsActiveResult.Text = "No";

            lbIssueDateResult.Text = InternationalLicense.ReleaseDate.ToString("d-M-yyyy");
            lblbEndDateResult.Text = InternationalLicense.EndDate.ToString("d-M-yyyy");
            lbNameResult.Text = Person.GetFullName();
            lbNationalNumberResult.Text = Person.NationalNumber.ToString();
            pbDriver.Image = await clsGlobal.LoadImageNoLockAsync(Person.ImagePath);
            lbInternationalLicenseIDResult.Text = InternationalLicense.InternationalLicenseID.ToString();
            lbLocalLicenseIDResult.Text = InternationalLicense.LocalLicenseID.ToString();
        }

        public void Reset()
        {
            lbApplicationIDResult.Text = "???";
            lbDateOfBirthResult.Text = "???";
            lbDriverIDResult.Text = "???";
            lbGenderResult.Text = "???";
            lbIsActiveResult.Text = "???";
            lbIssueDateResult.Text = "???";
            lblbEndDateResult.Text = "???";
            lbNameResult.Text = "???";
            lbNationalNumberResult.Text = "???";
            pbDriver.Image = null;
            lbInternationalLicenseIDResult.Text = "???";
            lbLocalLicenseIDResult.Text = "???";
        }



    }
}
