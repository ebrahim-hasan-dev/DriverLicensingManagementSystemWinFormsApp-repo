using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    public partial class fmManageApplicationsScreen : Form
    {
        // =================================================

        clsPerson _Person = null;

        string _AllNewLocalLicenseApplications = "All New Local License Applications";
        string _NewLocalLicenseApplicationsWithDate = "New Local License Applications With Date";
        string _AllRenewLicenseApplications = "All Renew License Applications";
        string _RenewLicenseApplicationsWithDate = "Renew License Applications With Date";
        string _NewLocalLicenseApplicationsForNationalNumber = "All New Local License Applications For National Number";
        string _RenewLicenseApplicationsForNationalNumber = "All Renew License Applications For National Number";
        string _ApplicationID = "Application ID";

        // =================================================
        public fmManageApplicationsScreen()
        {
            InitializeComponent();

            dgvApplications.ForeColor = Color.Black;
        }

        void FillComboBox()
        {
            cbFilter.Items.Add(_AllNewLocalLicenseApplications);
            cbFilter.Items.Add(_NewLocalLicenseApplicationsWithDate);
            cbFilter.Items.Add(_AllRenewLicenseApplications);
            cbFilter.Items.Add(_RenewLicenseApplicationsWithDate);
            cbFilter.Items.Add(_NewLocalLicenseApplicationsForNationalNumber);
            cbFilter.Items.Add(_RenewLicenseApplicationsForNationalNumber);
            cbFilter.Items.Add(_ApplicationID);

            cbFilter.SelectedIndex = 0;
        }

        private async void fmManageApplicationsScreen_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbManageApplicationsScreen);

            fmManageLicensesScreen.MakePersonInfoInCenterScreen(this.Width, uctrlPersonInfo1);

            FillComboBox();

            FillDataGridViewNewLocalLicense(await ApplicationService.FindAllNewLocalLicensesApplications());
        }

        void FillDataGridViewRenewLicense(List<clsApplication> ListOfApplications)
        {
            lbNumberOfRowsResult.Text = ListOfApplications.Count.ToString();

            string NumberOfTests = "";

            string LastDate = "";

            for (int i = 0; i < ListOfApplications.Count; i++)
            {
                if (ListOfApplications[i].LastUpdateDate == default(DateTime))
                {
                    LastDate = "No Update Date";
                }
                else
                {
                    LastDate = ListOfApplications[i].LastUpdateDate.ToString("d-M-yyyy h:m:s");
                }

                if (ListOfApplications[i].PassedInVisionTest == true)
                {
                    NumberOfTests = "1 / 1";
                }
                else
                {
                    NumberOfTests = "0 / 1";
                }

                dgvApplications.Rows.Add(ListOfApplications[i].ApplicationID, "???", ListOfApplications[i].ApplicationTypeID, ListOfApplications[i].StatusID,
                      ListOfApplications[i].AddedDateTme.ToString("d-M-yyyy h:m:s"), LastDate, ListOfApplications[i].Fees, ListOfApplications[i].PersonID,
                      NumberOfTests, ListOfApplications[i].CreatedByUser);
            }
        }

        void FillDataGridViewNewLocalLicense(List<clsNewLocalLicenseApplication> ListOfNewLocalLicenseApplications)
        {
            lbNumberOfRowsResult.Text = ListOfNewLocalLicenseApplications.Count.ToString();

            string NumberOfTests = " / 3";

            string LastDate = "";

            for (int i = 0; i < ListOfNewLocalLicenseApplications.Count; i++)
            {
                if (ListOfNewLocalLicenseApplications[i].ApplicationInfo.LastUpdateDate == default(DateTime))
                {
                    LastDate = "No Update Date";
                }
                else
                {
                    LastDate = ListOfNewLocalLicenseApplications[i].ApplicationInfo.LastUpdateDate.ToString("d-M-yyyy h:m:s");
                }

                dgvApplications.Rows.Add(ListOfNewLocalLicenseApplications[i].ApplicationInfo.ApplicationID, ListOfNewLocalLicenseApplications[i].LicenseClassID, ListOfNewLocalLicenseApplications[i].ApplicationInfo.ApplicationTypeID, ListOfNewLocalLicenseApplications[i].ApplicationInfo.StatusID,
                      ListOfNewLocalLicenseApplications[i].ApplicationInfo.AddedDateTme.ToString("d-M-yyyy h:m:s"), LastDate, ListOfNewLocalLicenseApplications[i].ApplicationInfo.Fees, ListOfNewLocalLicenseApplications[i].ApplicationInfo.PersonID,
                     ListOfNewLocalLicenseApplications[i].PassedTests + NumberOfTests, ListOfNewLocalLicenseApplications[i].ApplicationInfo.CreatedByUser);
            }
        }

        void FillDataGridView(List<clsApplication> ListOfApplications, List<clsNewLocalLicenseApplication> ListOfNewLocalLicenseApplications)
        {
            if (ListOfApplications.Count == 0 && ListOfNewLocalLicenseApplications.Count == 0)
            {
                MessageBox.Show("No Results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbFilter.Text == _AllNewLocalLicenseApplications || cbFilter.Text == _NewLocalLicenseApplicationsWithDate ||
                   cbFilter.Text == _NewLocalLicenseApplicationsForNationalNumber)
                {
                    FillDataGridViewNewLocalLicense(ListOfNewLocalLicenseApplications);
                }
                else if (cbFilter.Text == _AllRenewLicenseApplications || cbFilter.Text == _RenewLicenseApplicationsWithDate ||
                    cbFilter.Text == _RenewLicenseApplicationsForNationalNumber)
                {

                    FillDataGridViewRenewLicense(ListOfApplications);
                }
                else
                {
                    FillDataGridViewRenewLicense(ListOfApplications);
                }
            }
        }

        private async void btFilter_Click(object sender, EventArgs e)
        {
            List<clsNewLocalLicenseApplication> ListOfNewLocalLicenseApplications = new List<clsNewLocalLicenseApplication>();
            List<clsApplication> ListOfApplications = new List<clsApplication>();

            dgvApplications.Rows.Clear();
            lbNumberOfRowsResult.Text = "???";

            if (cbFilter.Text == _ApplicationID)
            {
                if (!string.IsNullOrWhiteSpace(mtxtbFilter.Text))
                {
                    clsApplication Application = await ApplicationService.Find(int.Parse(mtxtbFilter.Text));

                    if (Application != null)
                    {
                        ListOfApplications.Add(Application);
                    }
                }
                else
                {
                    MessageBox.Show("Box is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (cbFilter.Text == _AllNewLocalLicenseApplications)
                {
                    ListOfNewLocalLicenseApplications = await ApplicationService.FindAllNewLocalLicensesApplications();
                }

                else if (cbFilter.Text == _NewLocalLicenseApplicationsWithDate)
                {
                    ListOfNewLocalLicenseApplications = await ApplicationService.FindAllNewLocalLicensesApplications(DateTime.Parse(dtpDate.Value.ToString()));
                }

                else if (cbFilter.Text == _AllRenewLicenseApplications)
                {
                    ListOfApplications = await ApplicationService.FindAllRenewLicensesApplications();
                }

                else if (cbFilter.Text == _RenewLicenseApplicationsWithDate)
                {
                    ListOfApplications = await ApplicationService.FindAllRenewLicensesApplications(DateTime.Parse(dtpDate.Value.ToString()));
                }

                else if (cbFilter.Text == _NewLocalLicenseApplicationsForNationalNumber)
                {
                    if (mtxtbFilter.MaskCompleted)
                    {
                        ListOfNewLocalLicenseApplications = await ApplicationService.FindAllNewLocalLicensesApplicationsForNationalNumber(mtxtbFilter.Text);
                    }
                    else
                    {
                        MessageBox.Show("National number not completed or empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else if (cbFilter.Text == _RenewLicenseApplicationsForNationalNumber)
                {
                    if (mtxtbFilter.MaskCompleted)
                    {
                        ListOfApplications = await ApplicationService.FindAllRenewLicenseApplicationsForNationalNumber(mtxtbFilter.Text);
                    }
                    else
                    {
                        MessageBox.Show("National number not completed or empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            FillDataGridView(ListOfApplications, ListOfNewLocalLicenseApplications);
        }

        private async void dgvApplications_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count > 0)
            {
                _Person = await PersonService.FindByPersonID(int.Parse(dgvApplications.SelectedRows[0].Cells[7].Value.ToString()));

                await uctrlPersonInfo1.SetPersonInfo(_Person);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == _ApplicationID)
            {
                mtxtbFilter.Mask = "000000000";
            }
            else if (cbFilter.Text == _NewLocalLicenseApplicationsForNationalNumber)
            {
                mtxtbFilter.Mask = "00000000000000";
            }
            else if (cbFilter.Text == _RenewLicenseApplicationsForNationalNumber)
            {
                mtxtbFilter.Mask = "00000000000000";
            }

            mtxtbFilter.Clear();
            mtxtbFilter.Focus();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            mtxtbFilter.Clear();
        }

        private async void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count > 0)
            {
                if (Enum.TryParse(dgvApplications.SelectedRows[0].Cells[2].Value.ToString(), out enApplicationTypes ApplicationType))
                {
                    int ApplicationID = int.Parse(dgvApplications.SelectedRows[0].Cells[0].Value.ToString());

                    if (ApplicationType == enApplicationTypes.NewLocalLicense)
                    {
                        if (await ApplicationService.UpdateApplicationStatus(ApplicationID, enApplicationStatus.Canceled))
                        {
                            dgvApplications.SelectedRows[0].Cells[3].Value = enApplicationStatus.Canceled.ToString();

                            int NewLocalLicenseApplicationID = await ApplicationService.FindNewLocalLicenseID(ApplicationID);

                            if (await EnrollmentService.DeleteByNewLocalLicenseApplicationID(NewLocalLicenseApplicationID))
                            {
                                MessageBox.Show("Cancelled opreration successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else if (ApplicationType == enApplicationTypes.RenewLicense)
                    {
                        if (await ApplicationService.UpdateApplicationStatus(ApplicationID, enApplicationStatus.Canceled))
                        {
                            dgvApplications.SelectedRows[0].Cells[3].Value = enApplicationStatus.Canceled.ToString();

                            if (await EnrollmentService.DeleteByApplicationID(ApplicationID))
                            {
                                MessageBox.Show("Cancelled opreration successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvApplications.SelectedRows.Count > 0)
            {
                if (Enum.TryParse(dgvApplications.SelectedRows[0].Cells[2].Value.ToString(), out enApplicationTypes ApplicationType))
                {
                    if (ApplicationType != enApplicationTypes.NewLocalLicense && ApplicationType != enApplicationTypes.RenewLicense)
                    {
                        cancelToolStripMenuItem.Enabled = false;
                        registerInTestAppointmentToolStripMenuItem.Enabled = false;
                        issueLicenseToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        cancelToolStripMenuItem.Enabled = true;
                        registerInTestAppointmentToolStripMenuItem.Enabled = true;
                        issueLicenseToolStripMenuItem.Enabled = true;

                        if (dgvApplications.SelectedRows[0].Cells[3].Value.ToString() == enApplicationStatus.New.ToString())
                        {
                            cancelToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            cancelToolStripMenuItem.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                cancelToolStripMenuItem.Enabled = false;
                registerInTestAppointmentToolStripMenuItem.Enabled = false;
                issueLicenseToolStripMenuItem.Enabled = false;
            }
        }

        private void registerInTestAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count > 0)
            {
                if (Enum.TryParse(dgvApplications.SelectedRows[0].Cells[2].Value.ToString(), out enApplicationTypes ApplicationType))
                {
                    int ApplicationID = int.Parse(dgvApplications.SelectedRows[0].Cells[0].Value.ToString());

                    if (ApplicationType == enApplicationTypes.NewLocalLicense)
                    {
                        fmTestsScreen testsScreen = new fmTestsScreen(ApplicationID);
                        testsScreen.ShowDialog();
                    }
                    else if (ApplicationType == enApplicationTypes.RenewLicense)
                    {
                        fmTestsScreen testsScreen = new fmTestsScreen(ApplicationID, _Person);
                        testsScreen.ShowDialog();
                    }

                }
            }
        }

        private void issueLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count > 0)
            {
                if (Enum.TryParse(dgvApplications.SelectedRows[0].Cells[2].Value.ToString(), out enApplicationTypes ApplicationType))
                {
                    int ApplicationID = int.Parse(dgvApplications.SelectedRows[0].Cells[0].Value.ToString());

                    if (ApplicationType == enApplicationTypes.NewLocalLicense)
                    {
                        fmIssuingLicenseScreen issuingLicense = new fmIssuingLicenseScreen(true, ApplicationID);
                        issuingLicense.ShowDialog();
                    }
                    else if (ApplicationType == enApplicationTypes.RenewLicense)
                    {
                        fmIssuingLicenseScreen issuingLicense = new fmIssuingLicenseScreen(false, ApplicationID);
                        issuingLicense.ShowDialog();
                    }

                }
            }
        }




    }
}
