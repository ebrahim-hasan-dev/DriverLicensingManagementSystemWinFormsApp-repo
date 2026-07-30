using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmManagePeopleScreen : Form
    {
        // ============================================

        clsPerson _Person = null;

        // ============================================


        public fmManagePeopleScreen()
        {
            InitializeComponent();
        }


        void FillDataGirdView(List<clsPerson> ListOfPeople)
        {
            if (ListOfPeople.Count > 0)
            {
                lbNumberOfRowsResult.Text = ListOfPeople.Count.ToString();

                dgvPeople.Rows.Clear();

                for (int i = 0; i < ListOfPeople.Count; i++)
                {
                    dgvPeople.Rows.Add(new object[] { ListOfPeople[i].PersonID, ListOfPeople[i].GetFullName(), ListOfPeople[i].NationalNumber,
                         ListOfPeople[i].Gender, ListOfPeople[i].DateOfBirth.ToString("d-M-yyyy"), ListOfPeople[i].Country});
                }
            }
        }

        void FillComboBox()
        {
            cbFilter.Items.Add("All");
            cbFilter.Items.Add("National Number");

            cbFilter.SelectedIndex = 0;
        }

        async void fmManagePeopleScreen_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbManagePeopleScreen);

            dgvPeople.ForeColor = Color.Black;

            FillDataGirdView(await PersonService.GetAllPeople());

            FillComboBox();
        }

        private async void dgvPeople_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count > 0)
            {
                int.TryParse(dgvPeople.SelectedRows[0].Cells[0].Value.ToString(), out int PersonID);

                _Person = await PersonService.FindByPersonID(PersonID);

                await uctrlPersonInfo1.SetPersonInfo(_Person);
            }
        }

        private void showAllLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmManageLicensesScreen manageLicensesScreen = new fmManageLicensesScreen(dgvPeople.SelectedRows[0].Cells[2].Value.ToString());
            manageLicensesScreen.ShowDialog();
        }

        private async void showAllInternationalLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = await DriverService.GetDriverID(int.Parse(dgvPeople.SelectedRows[0].Cells[0].Value.ToString()));

            fmShowInternationalLicensesForDriverScreen showInternationalLicensesForDriverScreen = new fmShowInternationalLicensesForDriverScreen(DriverID, _Person);
            showInternationalLicensesForDriverScreen.ShowDialog();
        }

        void AddNewPerson(clsPerson Person)
        {
            dgvPeople.Rows.Add(Person.PersonID, Person.GetFullName(), Person.NationalNumber,
                         Person.Gender, Person.DateOfBirth.ToString("d-M-yyyy"), Person.Country);

            int NumberOfRows = int.Parse(lbNumberOfRowsResult.Text);
            NumberOfRows++;
            lbNumberOfRowsResult.Text = NumberOfRows.ToString();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAdd_UpdatePersonScreen add_UpdatePersonScreen = new fmAdd_UpdatePersonScreen();
            add_UpdatePersonScreen.AddedEventHandler += AddNewPerson;
            add_UpdatePersonScreen.ShowDialog();
        }

        async void UpdatePerson(clsPerson Person)
        {
            dgvPeople.SelectedRows[0].Cells[0].Value = Person.PersonID;
            dgvPeople.SelectedRows[0].Cells[1].Value = Person.GetFullName();
            dgvPeople.SelectedRows[0].Cells[2].Value = Person.NationalNumber;
            dgvPeople.SelectedRows[0].Cells[3].Value = Person.Gender;
            dgvPeople.SelectedRows[0].Cells[4].Value = Person.DateOfBirth.ToString("d-M-yyyy");
            dgvPeople.SelectedRows[0].Cells[5].Value = Person.Country;

            await uctrlPersonInfo1.SetPersonInfo(Person);
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAdd_UpdatePersonScreen add_UpdatePersonScreen = new fmAdd_UpdatePersonScreen(_Person);
            add_UpdatePersonScreen.AddedEventHandler += UpdatePerson;
            add_UpdatePersonScreen.ShowDialog();
        }

        void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtxtbNationalNumber.Clear();
        }

        async void btFind_Click(object sender, EventArgs e)
        {
            if (cbFilter.Text == "All")
            {
                FillDataGirdView(await PersonService.GetAllPeople());
            }
            else
            {
                if (mtxtbNationalNumber.MaskCompleted)
                {
                    dgvPeople.Rows.Clear();

                    clsPerson Person = await PersonService.FindByNationalNumber(mtxtbNationalNumber.Text);

                    if (Person != null)
                    {
                        lbNumberOfRowsResult.Text = 1.ToString();

                        dgvPeople.Rows.Add(Person.PersonID, Person.GetFullName(), Person.NationalNumber,
                            Person.Gender, Person.DateOfBirth.ToString("d-M-yyyy"), Person.Country);
                    }
                    else
                    {
                        MessageBox.Show("No Results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("National Number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            mtxtbNationalNumber.Focus();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvPeople.SelectedRows.Count > 0)
            {
                showAllLicensesToolStripMenuItem.Enabled = true;
                showAllInternationalLicensesToolStripMenuItem.Enabled = true;
                updatePersonToolStripMenuItem.Enabled = true;
            }
            else
            {
                showAllLicensesToolStripMenuItem.Enabled = false;
                showAllInternationalLicensesToolStripMenuItem.Enabled = false;
                updatePersonToolStripMenuItem.Enabled = false;
            }
        }

        private void llbAddNewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmAdd_UpdatePersonScreen add_UpdatePersonScreen = new fmAdd_UpdatePersonScreen();
            add_UpdatePersonScreen.AddedEventHandler += AddNewPerson;
            add_UpdatePersonScreen.ShowDialog();
        }


    }
}
