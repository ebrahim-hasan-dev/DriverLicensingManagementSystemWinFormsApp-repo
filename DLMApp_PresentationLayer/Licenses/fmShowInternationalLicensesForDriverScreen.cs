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
    public partial class fmShowInternationalLicensesForDriverScreen : Form
    {
        // =========================================================================

        List<clsInternationalLicense> _ListOfInternationalLicenses = null;

        clsPerson _Person = null;

        // =========================================================================


        public fmShowInternationalLicensesForDriverScreen(int DriverID, clsPerson Person)
        {
            InitializeComponent();

            dgvInternationalLicenses.ForeColor = Color.Black;

            _Person = Person;

            FillDataGridView(DriverID);
        }

        void FillDataGridView(int DriverID)
        {
            _ListOfInternationalLicenses = InternationalLicenseService.GetInternationalLicnesesForDriver(DriverID);

            if (_ListOfInternationalLicenses.Count > 0)
            {
                uctrlPersonInfo1.SetPersonInfo(_Person);

                for (short i = 0; i < _ListOfInternationalLicenses.Count; i++)
                {
                    dgvInternationalLicenses.Rows.Add(new object[] { _ListOfInternationalLicenses[i].DriverID, _ListOfInternationalLicenses[i].InternationalLicenseID,
                    _ListOfInternationalLicenses[i].LocalLicenseID, _ListOfInternationalLicenses[i].ReleaseDate.ToString("d-M-yyyy"),
                        _ListOfInternationalLicenses[i].EndDate.ToString("d-M-yyyy"), _ListOfInternationalLicenses[i].IsActive,
                        _ListOfInternationalLicenses[i].ApplicationID, _ListOfInternationalLicenses[i].CreatedByUser});
                }
            }
            else
            {
                MessageBox.Show("This driver not have international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fmShowInternationalLicensesForDriverScreen_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbShowInternationalLicensesForDriverScreen);

            fmManageLicensesScreen.MakePersonInfoInCenterScreen(this.Width, uctrlPersonInfo1);
        }





    }
}
