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
    public partial class uctrlLisenseInfo : UserControl
    {
        public uctrlLisenseInfo()
        {
            InitializeComponent();
        }

        private void uctrlLisenseInfo_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbLicenseInfo);
        }

        public void SetLicenseInfo(clsLicense License, int ApplicationID, string LicenseClass)
        {
            lbApplicationIDResult.Text = ApplicationID.ToString();

            if (License.PersonInfo == null)
            {
                License.PersonInfo = PersonService.FindByDriverID(License.DriverID);
            }

            lbDateOfBirthResult.Text = License.PersonInfo.DateOfBirth.ToString("d-M-yyyy");
            lbDriverIDResult.Text = License.DriverID.ToString();
            lbGenderResult.Text = License.PersonInfo.Gender.ToString();

            if (License.IsActive)
                lbIsActiveResult.Text = "Yes";
            else
                lbIsActiveResult.Text = "No";

            if (License.IsDetained)
                lbIsDetainedResult.Text = "Yes";
            else
                lbIsDetainedResult.Text = "No";

            lbIssueDateResult.Text = License.ReleaseDate.ToString("d-M-yyyy");
            lblbEndDateResult.Text = License.EndDate.ToString("d-M-yyyy");
            lbLicenseClassResult.Text = LicenseClass;
            lbLicenseFeesResult.Text = License.LicenseFees.ToString();
            lbNameResult.Text = License.PersonInfo.GetFullName();
            lbNationalNumberResult.Text = License.PersonInfo.NationalNumber.ToString();
            lbStatusResult.Text = License.LicenseStatusID.ToString();
            pbDriver.Image = clsGlobal.LoadImageNoLock(License.PersonInfo.ImagePath);
            lbLicenseIDResult.Text = License.ID.ToString();

            if (string.IsNullOrWhiteSpace(License.Notes))
                lbNotesResult.Text = "No Notes";
            else
                lbNotesResult.Text = License.Notes;
        }

        public void Reset()
        {
            lbApplicationIDResult.Text = "???";
            lbDateOfBirthResult.Text = "???";
            lbDriverIDResult.Text = "???";
            lbGenderResult.Text = "???";
            lbIsActiveResult.Text = "???";
            lbIsDetainedResult.Text = "???";
            lbIssueDateResult.Text = "???";
            lblbEndDateResult.Text = "???";
            lbLicenseClassResult.Text = "???";
            lbLicenseFeesResult.Text = "???";
            lbNameResult.Text = "???";
            lbNationalNumberResult.Text = "???";
            lbStatusResult.Text = "???";
            pbDriver.Image = null;
            lbLicenseIDResult.Text = "???";
            lbNotesResult.Text = "???";
        }




    }
}
