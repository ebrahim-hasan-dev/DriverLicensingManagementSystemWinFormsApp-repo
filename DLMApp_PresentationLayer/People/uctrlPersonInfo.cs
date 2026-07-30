using DLMApp_ModulesLayer;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class uctrlPersonInfo : UserControl
    {
        public uctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void uctrlPersonInfo_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbPersonInfo);
        }

        public async Task SetPersonInfo(clsPerson Person)
        {
            if (Person != null)
            {
                lbNameResult.Text = Person.GetFullName();
                lbGenderResult.Text = Person.Gender;
                lbNationalNumberResult.Text = Person.NationalNumber;
                lbAddressResult.Text = Person.Address;

                if (string.IsNullOrWhiteSpace(Person.Phone1))
                {
                    lbPhone1Result.Text = "No Phone";
                }
                else
                {
                    lbPhone1Result.Text = Person.Phone1;
                }

                if (string.IsNullOrWhiteSpace(Person.Phone2))
                {
                    lbPhone2Result.Text = "No Phone";
                }
                else
                {
                    lbPhone2Result.Text = Person.Phone2;
                }
                
                lbDateOfBirthResult.Text = Person.DateOfBirth.ToString("d-M-yyyy");
                lbEmailResult.Text = Person.Email;
                lbCountryResult.Text = Person.Country;
                lbCreatedByUserRseult.Text = Person.CreatedByUser;
                lblbAddedDateResult.Text = Person.AddedDate.ToString("d-M-yyyy h:m");

                pctbPerson.Image = await clsGlobal.LoadImageNoLockAsync(Person.ImagePath);
            }
        }

        public void Reset()
        {
            lbNameResult.Text = "???";
            lbGenderResult.Text = "???";
            lbNationalNumberResult.Text = "???";
            lbAddressResult.Text = "???";
            lbPhone1Result.Text = "???";
            lbPhone2Result.Text = "???";
            lbDateOfBirthResult.Text = "???";
            lbEmailResult.Text = "???";
            lbCountryResult.Text = "???";
            lbCreatedByUserRseult.Text = "???";
            lblbAddedDateResult.Text = "???";

            pctbPerson.Image = null;
        }



    }
}
