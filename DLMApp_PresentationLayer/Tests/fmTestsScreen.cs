using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;



namespace DLMApp_PresentationLayer
{
    public partial class fmTestsScreen : Form
    {
        // ======================================================================================================

        int _ApplicationID = 0;
        int _NewLocalLicenseApplicationID = 0;
        byte _TestID = 0;
        int _AppointmentID = 0;
        int _RetakeTestApplicationID = 0;

        clsPerson _Person = null;

        bool _IsNewApplication = false;
        bool _IsTestDay = false;
        bool _IsRetakeTest = false;
        bool _IsRenewLicense = false;

        List<clsTest> _ListOfTests = null;

        List<clsPeopleRegisteredInAppointmentDTO> _ListOfRegisteredPeople = null;
        List<clsPeopleRegisteredInAppointmentDTO> _ListOfRegisteredPeopleRnewLicense = null;

        // ======================================================================================================


        public fmTestsScreen(int ApplicationID, int NewLocalLicenseApplicationID, clsPerson Person)
        {
            _ApplicationID = ApplicationID;
            _NewLocalLicenseApplicationID = NewLocalLicenseApplicationID;
            _Person = Person;
            _IsNewApplication = true;

            InitializeComponent();
        }

        public fmTestsScreen(bool IsTestDay)
        {
            _IsNewApplication = false;
            _IsTestDay = IsTestDay;

            InitializeComponent();
        }

        public fmTestsScreen(int RetakeTestApplicationID, int OriginalApplicationID, clsPerson Person, bool IsRetakeTest)
        {
            InitializeComponent();

            _RetakeTestApplicationID = RetakeTestApplicationID;
            _ApplicationID = OriginalApplicationID;
            _Person = Person;
            _IsRetakeTest = IsRetakeTest;

            mtxtbApplicationID.Text = OriginalApplicationID.ToString();

            mtxtbApplicationID.Enabled = false;
        }

        public fmTestsScreen(int ApplicationID, clsPerson Person)
        {
            _ApplicationID = ApplicationID;
            _Person = Person;

            _IsRenewLicense = true;

            InitializeComponent();
        }

        public fmTestsScreen(int ApplicationID)
        {
            InitializeComponent();

            mtxtbApplicationID.Text = ApplicationID.ToString();

            mtxtbApplicationID.Enabled = false;
        }


        // ======================================================================================================


        void SettingRenewLicense()
        {
            if (_IsRenewLicense)
            {
                this.AcceptButton = btFindAvailableTestAppointment;

                mtxtbApplicationID.Text = _ApplicationID.ToString();
                mtxtbApplicationID.Enabled = false;

                cbTests.Enabled = false;
            }
        }

        void LoadAllTests()
        {
            _ListOfTests = TestService.GetAllTests();

            for (byte i = 0; i < _ListOfTests.Count; i++)
            {
                cbTests.Items.Add(_ListOfTests[i].Test);
            }

            cbTests.SelectedIndex = 0;
        }

        void SettingNewApplication()
        {
            if (_IsNewApplication)
            {
                this.AcceptButton = btFindAvailableTestAppointment;

                mtxtbApplicationID.Text = _ApplicationID.ToString();
                mtxtbApplicationID.Enabled = false;
            }
        }

        void SettingTestDay()
        {
            if (_IsTestDay)
            {
                this.AcceptButton = btFindTestDay;

                dtpTestAppointment.MinDate = new DateTime(2026, 1, 1);
                dtpTestAppointment.Value = DateTime.Now;
                dtpTestAppointment.Enabled = true;

                this.AcceptButton = btFindTestDay;

                btFindTestDay.Visible = true;
                btFindTestDay.Enabled = true;
                btAdoptResult.Visible = true;

                btCreateAppointment.Enabled = false;
                btFindAvailableTestAppointment.Enabled = false;
                btRegister.Enabled = false;
                mtxtbApplicationID.Enabled = false;
                txtbNotes.Enabled = false;

                colFail.ReadOnly = false;
                colPass.ReadOnly = false;
            }
            else
            {
                dtpTestAppointment.MinDate = DateTime.Now.AddDays(1);
                dtpTestAppointment.Value = DateTime.Now.AddDays(1);
            }
        }

        private void fmTestsScreen_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbTestsScreen);

            LoadAllTests();

            SettingNewApplication();

            dgvPeopleRegisteredForTest.ForeColor = Color.Black;

            SettingTestDay();

            SettingRenewLicense();
        }

        void AllowCreateAppoinntment()
        {
            MessageBox.Show($"No {lbTestResult.Text} appointment are available\nYou must create an appointment", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btCreateAppointment.Enabled = true;
            dtpTestAppointment.Enabled = true;
            this.AcceptButton = btCreateAppointment;
            dtpTestAppointment.Focus();
        }

        private void btFindAvailableTestAppointment_Click(object sender, EventArgs e)
        {
            string CreatedByUser = "";

            _ListOfRegisteredPeople = PeopleRegisteredInAppointmentDTOService.GetAllRegisteredPeopleInAppointment(_TestID, ref CreatedByUser);

            _ListOfRegisteredPeopleRnewLicense = PeopleRegisteredInAppointmentDTOService.GetAllRegisteredPeopleInAppointmentTestDayRenewLicense(_TestID, ref CreatedByUser);

            bool List1 = false;
            bool List2 = false;

            if (_ListOfRegisteredPeople.Count > 0)
            {
                List1 = FillListOfPeopleRegistered(_ListOfRegisteredPeople, CreatedByUser, _ListOfRegisteredPeople[0].Appointment);
                _AppointmentID = _ListOfRegisteredPeople[0].AppointmentID;
            }

            if (_ListOfRegisteredPeopleRnewLicense.Count > 0)
            {
                List2 = FillListOfPeopleRegistered(_ListOfRegisteredPeopleRnewLicense, CreatedByUser, _ListOfRegisteredPeopleRnewLicense[0].Appointment, false);
                _AppointmentID = _ListOfRegisteredPeopleRnewLicense[0].AppointmentID;
            }


            if (List1 == false && List2 == false)
            {
                AllowCreateAppoinntment();
            }
            else
            {
                this.AcceptButton = btRegister;
            }
        }

        void ShowReasonForRegistrationFailure(enEnrollmentResults Result)
        {
            switch (Result)
            {
                case enEnrollmentResults.eSameApplicationInSameApplointment:
                    {
                        MessageBox.Show("This application id  is already registered in the same appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case enEnrollmentResults.eFailInVisionTest:
                    {
                        MessageBox.Show("The vision test was not passesd successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case enEnrollmentResults.eFailInWrittenTest:
                    {
                        MessageBox.Show("The written test was not passesd successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case enEnrollmentResults.eFail:
                    {
                        MessageBox.Show("Enrollment operation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case enEnrollmentResults.eNoNewLocalLicenseID:
                    {
                        MessageBox.Show("This application is not for obtaining a new local license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case enEnrollmentResults.eAlreadyEnrollBefor:
                    {
                        MessageBox.Show("This application already enroll befor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case enEnrollmentResults.StatusNotNew:
                    {
                        MessageBox.Show("Application status cancelled or completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case enEnrollmentResults.AppointmentCompleted:
                    {

                        MessageBox.Show("Appointment completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvPeopleRegisteredForTest.Rows.Clear();
                        AllowCreateAppoinntment();
                        break;
                    }
                case enEnrollmentResults.eAlreadyPassedInVisionTest:
                case enEnrollmentResults.eAlreadyPassedInWrittenTest:
                case enEnrollmentResults.eAlreadyPassedInStreetTest:
                    {
                        MessageBox.Show("This person with this application id is already passed in this test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }

        }

        void NewApplicationProcess()
        {
            short NumberOfPeopleRegistered = 0;

            enEnrollmentResults Result = EnrollmentService.Enroll(_AppointmentID, _TestID, clsGlobal.CurrentUser.UserID,
                   _NewLocalLicenseApplicationID, float.Parse(lbTestFeesResult.Text), ref NumberOfPeopleRegistered, txtbNotes.Text);

            if (Result == enEnrollmentResults.Success)
            {
                int PersonID = 0;
                clsLicenseClass licenseClass = LicenseService.GetLicenseClass(_ApplicationID, ref PersonID);

                dgvPeopleRegisteredForTest.Rows.Add(new object[] { _ApplicationID, PersonID, _Person.GetFullName(), _Person.NationalNumber, 
                    licenseClass.LicenseClass, txtbNotes.Text});

                lbNumberOfPeopleRegisteredResult.Text = NumberOfPeopleRegistered.ToString();

                MessageBox.Show("Enrollment operation successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mtxtbApplicationID.Clear();
            }
            else
            {
                ShowReasonForRegistrationFailure(Result);
            }
        }

        void RetakeTestProcess()
        {
            short NumberOfPeopleRegistered = 0;

            enEnrollmentResults Result = EnrollmentService.EnrollByApplicationID(_AppointmentID, _TestID, clsGlobal.CurrentUser.UserID, _ApplicationID,
                                   float.Parse(lbTestFeesResult.Text), ref NumberOfPeopleRegistered, txtbNotes.Text, _RetakeTestApplicationID);

            if (Result == enEnrollmentResults.Success)
            {
                ApplicationService.UpdateApplicationStatus(_RetakeTestApplicationID, enApplicationStatus.Completed);

                int PersonID = 0;
                clsLicenseClass licenseClass = LicenseService.GetLicenseClass(_ApplicationID, ref PersonID);

                dgvPeopleRegisteredForTest.Rows.Add(new object[] { _ApplicationID, PersonID, _Person.GetFullName(), _Person.NationalNumber,
                licenseClass?.LicenseClass, txtbNotes.Text });

                lbNumberOfPeopleRegisteredResult.Text = NumberOfPeopleRegistered.ToString();

                MessageBox.Show("Enrollment operation successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mtxtbApplicationID.Clear();
            }
            else
            {
                ShowReasonForRegistrationFailure(Result);
            }
        }

        void RegisterProcess()
        {
            _ApplicationID = int.Parse(mtxtbApplicationID.Text);

            _Person = PersonService.FindByApplicationID(_ApplicationID);

            if (_Person != null)
            {
                short NumberOfPeopleRegistered = 0;

                enEnrollmentResults Result = EnrollmentService.EnrollByApplicationID(_AppointmentID, _TestID, clsGlobal.CurrentUser.UserID, _ApplicationID,
                                              float.Parse(lbTestFeesResult.Text), ref NumberOfPeopleRegistered, txtbNotes.Text);


                if (Result == enEnrollmentResults.Success)
                {
                    int PersonID = 0;
                    clsLicenseClass licenseClass = LicenseService.GetLicenseClass(_ApplicationID, ref PersonID);

                    dgvPeopleRegisteredForTest.Rows.Add(new object[] { _ApplicationID, PersonID, _Person.GetFullName(), _Person.NationalNumber,
                                   licenseClass?.LicenseClass, txtbNotes.Text});

                    lbNumberOfPeopleRegisteredResult.Text = NumberOfPeopleRegistered.ToString();

                    MessageBox.Show("Enrollment operation successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowReasonForRegistrationFailure(Result);
                }
            }
            else
            {
                MessageBox.Show($"There is no Application ID like this {mtxtbApplicationID.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void RenewLicenseProcess()
        {
            short NumberOfPeopleRegistered = 0;

            enEnrollmentResults Result = EnrollmentService.Enroll(_AppointmentID, _TestID, clsGlobal.CurrentUser.UserID,
                   float.Parse(lbTestFeesResult.Text), ref NumberOfPeopleRegistered, txtbNotes.Text, _ApplicationID);

            if (Result == enEnrollmentResults.Success)
            {
                dgvPeopleRegisteredForTest.Rows.Add(new object[] { _ApplicationID, _Person.PersonID, _Person.GetFullName(), _Person.NationalNumber,
                    "???", txtbNotes.Text });

                lbNumberOfPeopleRegisteredResult.Text = NumberOfPeopleRegistered.ToString();

                MessageBox.Show("Enrollment operation successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mtxtbApplicationID.Clear();
            }
            else
            {
                ShowReasonForRegistrationFailure(Result);
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtxtbApplicationID.Text))
            {
                if (_AppointmentID > 0)
                {
                    if (_IsNewApplication)
                    {
                        NewApplicationProcess();
                    }
                    else
                    {
                        if (_IsRetakeTest)
                        {
                            RetakeTestProcess();
                        }
                        else if (_IsRenewLicense)
                        {
                            RenewLicenseProcess();
                        }
                        else
                        {
                            RegisterProcess();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Find appointment first, then register", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Application ID is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (mtxtbApplicationID.Enabled)
            {
                mtxtbApplicationID.Clear();
                mtxtbApplicationID.Focus();
            }
        }

        void SetTestInfo(clsTest test)
        {
            _TestID = test.ID;

            lbTestResult.Text = test.Test;
            lbTestFeesResult.Text = test.Fees.ToString();
            lbTestDescriptionResult.Text = test.Description.ToString();
            lbMaxNubmerOfPeopleResult.Text = test.MaxNumberOfPeople.ToString();
        }

        void ResetAppointmentInfo()
        {
            lbAppointmentResult.Text = "???";
            lbNumberOfPeopleRegisteredResult.Text = "???";
            lbAppointmentCreatedByUserResult.Text = "???";
        }

        private void cbTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTestInfo(_ListOfTests.Find(x => x.Test == cbTests.Text));

            _AppointmentID = 0;

            ResetAppointmentInfo();

            if (_IsTestDay == false)
            {
                dtpTestAppointment.Enabled = false;
                btCreateAppointment.Enabled = false;
            }

            dgvPeopleRegisteredForTest.Rows.Clear();
        }

        private void btCreateAppointment_Click(object sender, EventArgs e)
        {
            if (dtpTestAppointment.Value > DateTime.Now)
            {
                btCreateAppointment.Enabled = false;
                dtpTestAppointment.Enabled = false;

                clsAppointment Appointment = new clsAppointment();

                Appointment.Appointment = dtpTestAppointment.Value;
                Appointment.NumberOfPeople = 0;
                Appointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (AppointmentService.IsExist(Appointment) == false)
                {
                    if (AppointmentService.AddNewAppointment(Appointment))
                    {
                        _AppointmentID = Appointment.ID;

                        lbAppointmentResult.Text = dtpTestAppointment.Value.ToString("d-M-yyyy");
                        lbNumberOfPeopleRegisteredResult.Text = Appointment.NumberOfPeople.ToString();
                        lbAppointmentCreatedByUserResult.Text = clsGlobal.CurrentUser.UserName;

                        this.AcceptButton = btRegister;
                    }
                }
                else
                {
                    if (Appointment.NumberOfPeople == 0)
                    {
                        lbAppointmentResult.Text = dtpTestAppointment.Value.ToString("d-M-yyyy");
                        lbNumberOfPeopleRegisteredResult.Text = Appointment.NumberOfPeople.ToString();
                        lbAppointmentCreatedByUserResult.Text = Appointment.CreatedByUser;
                        _AppointmentID = Appointment.ID;

                        this.AcceptButton = btRegister;
                    }
                    else
                    {
                        MessageBox.Show("This appointment is already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select appointment in the future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void FillDataGridView(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeople, bool Clear = true)
        {
            if (Clear)
                dgvPeopleRegisteredForTest.Rows.Clear();

            for (short i = 0; i < ListOfRegisteredPeople.Count; i++)
            {
                if (ListOfRegisteredPeople[i].Result == null)
                {
                    dgvPeopleRegisteredForTest.Rows.Add(new object[] { ListOfRegisteredPeople[i].ApplicationID, ListOfRegisteredPeople[i].PersonID,
                    ListOfRegisteredPeople[i].GetFullName(), ListOfRegisteredPeople[i].NationalNumber, ListOfRegisteredPeople[i].LicenseClass,
                    ListOfRegisteredPeople[i].Notes, false, false});
                }
                else
                {
                    bool Pass = false;
                    bool Fail = false;

                    if (ListOfRegisteredPeople[i].Result == true)
                        Pass = true;
                    else
                        Fail = true;

                    dgvPeopleRegisteredForTest.Rows.Add(new object[] { ListOfRegisteredPeople[i].ApplicationID, ListOfRegisteredPeople[i].PersonID,
                    ListOfRegisteredPeople[i].GetFullName(), ListOfRegisteredPeople[i].NationalNumber, ListOfRegisteredPeople[i].LicenseClass,
                    ListOfRegisteredPeople[i].Notes, Pass, Fail});

                    dgvPeopleRegisteredForTest.Rows[dgvPeopleRegisteredForTest.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[6].ReadOnly = true;
                    dgvPeopleRegisteredForTest.Rows[dgvPeopleRegisteredForTest.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[7].ReadOnly = true;
                }
            }
        }
        
        bool FillListOfPeopleRegistered(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeople, string CreatedByUser, DateTime Appointment, bool Clear = true)
        {
            if (ListOfRegisteredPeople.Count > 0)
            {
                lbAppointmentResult.Text = Appointment.ToString("d-M-yyyy");
                lbNumberOfPeopleRegisteredResult.Text = ListOfRegisteredPeople[0].NumberOfPeopleRegisteredInAppointment.ToString();
                lbAppointmentCreatedByUserResult.Text = CreatedByUser;

                FillDataGridView(ListOfRegisteredPeople, Clear);

                btAdoptResult.Enabled = true;

                return true;
            }
            else
            {
                return false;
            }
        }

        private void btFindTestDay_Click(object sender, EventArgs e)
        {
            DateTime Appointment = dtpTestAppointment.Value;
            string CreatedByUser = "";
            
            _ListOfRegisteredPeople = PeopleRegisteredInAppointmentDTOService.GetAllRegisteredPeopleInAppointment(_TestID, ref CreatedByUser, Appointment, true);

            _ListOfRegisteredPeopleRnewLicense = PeopleRegisteredInAppointmentDTOService.GetAllRegisteredPeopleInAppointmentTestDayRenewLicense(_TestID, ref CreatedByUser, Appointment, true);

            bool List1 = FillListOfPeopleRegistered(_ListOfRegisteredPeople, CreatedByUser, Appointment);
            bool List2 = FillListOfPeopleRegistered(_ListOfRegisteredPeopleRnewLicense, CreatedByUser, Appointment, false);

            if (List1 == false && List2 == false)
            {
                MessageBox.Show($"No registrations in this appointment ({Appointment.ToString("d-M-yyyy")}) with {lbTestResult.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.AcceptButton = btAdoptResult;
            }
        
        }

        bool HaveAllPeopleHadTheirResultsDetermined()
        {
            for (short i = 0; i < dgvPeopleRegisteredForTest.Rows.Count; i++)
            {
                if ((bool)dgvPeopleRegisteredForTest.Rows[i].Cells[6].Value == false && (bool)dgvPeopleRegisteredForTest.Rows[i].Cells[7].Value == false)
                {
                    return false;
                }
            }

            return true;
        }

        bool IsAllResultsCellsReadOnly()
        {
            for (short i = 0; i < dgvPeopleRegisteredForTest.Rows.Count; i++)
            {
                if (dgvPeopleRegisteredForTest.Rows[i].Cells[6].ReadOnly == false || dgvPeopleRegisteredForTest.Rows[i].Cells[7].ReadOnly == false)
                {
                    return false;
                }
            }

            return true;
        }

        void DeleteFromTowLists(int ApplicationID)
        {
            short index = (short)_ListOfRegisteredPeople.FindIndex(x => x.ApplicationID == ApplicationID);

            if (index != -1)
            {
                _ListOfRegisteredPeople.RemoveAt(index);
            }
            else
            {
                index = (short)_ListOfRegisteredPeopleRnewLicense.FindIndex(x => x.ApplicationID == ApplicationID);

                _ListOfRegisteredPeopleRnewLicense.RemoveAt(index);
            }
        }

        private void btAdoptResult_Click(object sender, EventArgs e)
        {
            if (HaveAllPeopleHadTheirResultsDetermined() == true)
            {
                if (IsAllResultsCellsReadOnly() == false)
                {
                    bool Result = false;

                    clsPeopleRegisteredInAppointmentDTO registeredInAppointmentDTO = null;

                    for (short i = 0; i < dgvPeopleRegisteredForTest.Rows.Count; i++)
                    {
                        if ((bool)dgvPeopleRegisteredForTest.Rows[i].Cells[6].Value == true)
                        {
                            Result = true;
                        }
                        else
                        {
                            Result = false;
                        }


                        int ApplicationID = int.Parse(dgvPeopleRegisteredForTest.Rows[i].Cells[0].Value.ToString());

                        if (dgvPeopleRegisteredForTest.Rows[i].Cells[6].ReadOnly == true || dgvPeopleRegisteredForTest.Rows[i].Cells[7].ReadOnly == true)
                        {
                            DeleteFromTowLists(ApplicationID);
                            continue;
                        }

                        registeredInAppointmentDTO = _ListOfRegisteredPeople.Find(x => x.ApplicationID == ApplicationID);

                        if (registeredInAppointmentDTO != null)
                        {
                            registeredInAppointmentDTO.Result = Result;
                        }

                        registeredInAppointmentDTO = _ListOfRegisteredPeopleRnewLicense.Find(x => x.ApplicationID == ApplicationID);

                        if (registeredInAppointmentDTO != null)
                        {
                            registeredInAppointmentDTO.Result = Result;
                        }
                    }

                    bool Result1 = EnrollmentService.SetResults(_ListOfRegisteredPeople, _TestID);
                    bool Result2 = EnrollmentService.SetResults(_ListOfRegisteredPeopleRnewLicense);

                    if (Result1 || Result2)
                    {
                        MessageBox.Show("The results have been set successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btAdoptResult.Enabled = false;
                        colFail.ReadOnly = true;
                        colPass.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Faild to set results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("All results have already been set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("One of the results was not assigned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPeopleRegisteredForTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgvPeopleRegisteredForTest.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly == false)
                {
                    if (e.ColumnIndex == 6)
                    {
                        dgvPeopleRegisteredForTest.Rows[e.RowIndex].Cells[7].Value = false;
                    }
                    else if (e.ColumnIndex == 7)
                    {
                        dgvPeopleRegisteredForTest.Rows[e.RowIndex].Cells[6].Value = false;
                    }
                }
            }
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeopleRegisteredForTest.SelectedRows.Count > 0)
            {
                int.TryParse(dgvPeopleRegisteredForTest.SelectedRows[0].Cells[1].Value.ToString(), out int PersonID);

                clsPerson Person = PersonService.FindByPersonID(PersonID);

                fmShowUserInfoScreen showUserInfoScreen = new fmShowUserInfoScreen(Person);
                showUserInfoScreen.ShowDialog();
            }
        }

        private void dtpTestAppointment_ValueChanged(object sender, EventArgs e)
        {
            dgvPeopleRegisteredForTest.Rows.Clear();
        }



    }
}
