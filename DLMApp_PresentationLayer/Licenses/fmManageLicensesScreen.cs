using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmManageLicensesScreen : Form
    {
        // =========================================

        int _DriverID = 0;
        clsPerson _Person = null;
        bool _IsSpecialPerson = false;
        string _NationalNumber = "";

        // =========================================

        public fmManageLicensesScreen()
        {
            InitializeComponent();
        }

        public fmManageLicensesScreen(string NationalNumber)
        {
            InitializeComponent();

            _NationalNumber = NationalNumber;
            _IsSpecialPerson = true;
        }


        void SpecialPersonSetting()
        {
            cbFilter.SelectedIndex = 2;

            mtxtbFilter.Text = _NationalNumber;

            btFilter.PerformClick();
        }

        void FillComboBox()
        {
            cbFilter.Items.Add("All");
            cbFilter.Items.Add("Driver ID");
            cbFilter.Items.Add("National Number");
            cbFilter.Items.Add("License ID");

            cbFilter.SelectedIndex = 0;
        }

        public static void MakePersonInfoInCenterScreen(int Width, uctrlPersonInfo PersonInfo)
        {
            PersonInfo.Location = new Point((Width / 2) - (PersonInfo.Size.Width / 2), PersonInfo.Location.Y);
        }

        private async void fmManageLicensesScreen_Load(object sender, EventArgs e)
        {
            dgvLicenses.ForeColor = Color.Black;

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbManageLicensesScreen);

            MakePersonInfoInCenterScreen(this.Width, uctrlPersonInfo1);

            FillComboBox();

            if (_IsSpecialPerson == true)
            {
                SpecialPersonSetting();
            }
            else
            {
                FillDataGridView(await LicenseService.GetAllLicenses());
            }
        }

        void FillDataGridView(List<clsLicense> ListOfLicenses)
        {
            if (ListOfLicenses.Count > 0)
            {
                lbNumberOfRowsResult.Text = ListOfLicenses.Count.ToString();

                for (int i = 0; i < ListOfLicenses.Count; i++)
                {
                    dgvLicenses.Rows.Add(new object[] { ListOfLicenses[i].DriverID, ListOfLicenses[i].ID, ListOfLicenses[i].ReleaseDate.ToString("d-M-yyyy"),
                ListOfLicenses[i].EndDate.ToString("d-M-yyyy"), ListOfLicenses[i].IsActive, ListOfLicenses[i].IsDetained, ListOfLicenses[i].LicenseClass,
                ListOfLicenses[i].LicenseFees, ListOfLicenses[i].LicenseStatusID, ListOfLicenses[i].ApplicationID, ListOfLicenses[i].Notes, ListOfLicenses[i].CreatedByUser});
                }
            }
            else
            {
                uctrlPersonInfo1.Reset();
                lbNumberOfRowsResult.Text = "???";

                MessageBox.Show("No Results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btFilter_Click(object sender, EventArgs e)
        {
            List<clsLicense> ListOfLicenses = new List<clsLicense>();

            if (cbFilter.Text == "All")
            {
                dgvLicenses.Rows.Clear();

                ListOfLicenses = await LicenseService.GetAllLicenses();

                FillDataGridView(ListOfLicenses);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(mtxtbFilter.Text))
                {
                    dgvLicenses.Rows.Clear();

                    if (cbFilter.Text == "License ID")
                    {
                        clsLicense License = await LicenseService.Find(int.Parse(mtxtbFilter.Text));

                        if (License != null)
                        {
                            ListOfLicenses.Add(License);
                        }
                    }
                    else if (cbFilter.Text == "Driver ID")
                    {
                        ListOfLicenses = await LicenseService.FindAllByDriverID(int.Parse(mtxtbFilter.Text));
                    }
                    else if (cbFilter.Text == "National Number")
                    {
                        if (mtxtbFilter.MaskCompleted)
                        {
                            ListOfLicenses = await LicenseService.FindAllByNationalNumber(mtxtbFilter.Text);
                        }
                        else
                        {
                            MessageBox.Show("National Number not completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    FillDataGridView(ListOfLicenses);
                }
                else
                {
                    MessageBox.Show("Input filter is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtxtbFilter.Clear();
            mtxtbFilter.Focus();

            if (cbFilter.Text == "National Number")
            {
                mtxtbFilter.Mask = "00000000000000";
            }
            else
            {
                mtxtbFilter.Mask = "000000000";
            }
        }

        private async void dgvLicenses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLicenses.SelectedRows.Count > 0)
            {
                _DriverID = int.Parse(dgvLicenses.SelectedRows[0].Cells[0].Value.ToString());

                _Person = await PersonService.FindByDriverID(_DriverID);

                await uctrlPersonInfo1.SetPersonInfo(_Person);
            }
        }

        private void showInternationalLicensesForThisDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmShowInternationalLicensesForDriverScreen showInternationalLicensesForDriverScreen = new fmShowInternationalLicensesForDriverScreen(_DriverID, _Person);
            showInternationalLicensesForDriverScreen.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvLicenses.SelectedRows.Count > 0)
            {
                showInternationalLicensesForThisDriverToolStripMenuItem.Enabled = true;
            }
            else
            {
                showInternationalLicensesForThisDriverToolStripMenuItem.Enabled = false;
            }
        }




    }
}
