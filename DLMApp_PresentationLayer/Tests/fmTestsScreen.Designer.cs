namespace DLMApp_PresentationLayer
{
    partial class fmTestsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPeopleRegisteredForTest = new System.Windows.Forms.DataGridView();
            this.colApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicenseClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTestsScreen = new System.Windows.Forms.Label();
            this.lbTest = new System.Windows.Forms.Label();
            this.lbTestFees = new System.Windows.Forms.Label();
            this.lbTestDescription = new System.Windows.Forms.Label();
            this.lbMaxNubmerOfPeople = new System.Windows.Forms.Label();
            this.lbAppointment = new System.Windows.Forms.Label();
            this.lbNumberOfPeopleRegistered = new System.Windows.Forms.Label();
            this.lbEnterApplicationID = new System.Windows.Forms.Label();
            this.mtxtbApplicationID = new System.Windows.Forms.MaskedTextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.lbMaxNubmerOfPeopleResult = new System.Windows.Forms.Label();
            this.cbTests = new System.Windows.Forms.ComboBox();
            this.dtpTestAppointment = new System.Windows.Forms.DateTimePicker();
            this.lbSelectTest = new System.Windows.Forms.Label();
            this.lbSelectAppointment = new System.Windows.Forms.Label();
            this.lbNumberOfPeopleRegisteredResult = new System.Windows.Forms.Label();
            this.lbTestDescriptionResult = new System.Windows.Forms.Label();
            this.lbAppointmentResult = new System.Windows.Forms.Label();
            this.lbTestResult = new System.Windows.Forms.Label();
            this.lbTestFeesResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAppointmentCreatedByUser = new System.Windows.Forms.Label();
            this.lbAppointmentCreatedByUserResult = new System.Windows.Forms.Label();
            this.btFindAvailableTestAppointment = new System.Windows.Forms.Button();
            this.btCreateAppointment = new System.Windows.Forms.Button();
            this.lbAddNotes = new System.Windows.Forms.Label();
            this.txtbNotes = new System.Windows.Forms.TextBox();
            this.btFindTestDay = new System.Windows.Forms.Button();
            this.btAdoptResult = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleRegisteredForTest)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeopleRegisteredForTest
            // 
            this.dgvPeopleRegisteredForTest.AllowUserToAddRows = false;
            this.dgvPeopleRegisteredForTest.AllowUserToDeleteRows = false;
            this.dgvPeopleRegisteredForTest.AllowUserToResizeRows = false;
            this.dgvPeopleRegisteredForTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeopleRegisteredForTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApplicationID,
            this.colPersonID,
            this.colFullname,
            this.colNationalNumber,
            this.colLicenseClass,
            this.colNotes,
            this.colPass,
            this.colFail});
            this.dgvPeopleRegisteredForTest.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeopleRegisteredForTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPeopleRegisteredForTest.Location = new System.Drawing.Point(0, 464);
            this.dgvPeopleRegisteredForTest.MultiSelect = false;
            this.dgvPeopleRegisteredForTest.Name = "dgvPeopleRegisteredForTest";
            this.dgvPeopleRegisteredForTest.RowHeadersVisible = false;
            this.dgvPeopleRegisteredForTest.RowHeadersWidth = 51;
            this.dgvPeopleRegisteredForTest.RowTemplate.Height = 24;
            this.dgvPeopleRegisteredForTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeopleRegisteredForTest.Size = new System.Drawing.Size(1419, 316);
            this.dgvPeopleRegisteredForTest.TabIndex = 11;
            this.dgvPeopleRegisteredForTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeopleRegisteredForTest_CellContentClick);
            // 
            // colApplicationID
            // 
            this.colApplicationID.HeaderText = "Application ID";
            this.colApplicationID.MinimumWidth = 6;
            this.colApplicationID.Name = "colApplicationID";
            this.colApplicationID.ReadOnly = true;
            this.colApplicationID.Width = 155;
            // 
            // colPersonID
            // 
            this.colPersonID.HeaderText = "Person ID";
            this.colPersonID.MinimumWidth = 6;
            this.colPersonID.Name = "colPersonID";
            this.colPersonID.ReadOnly = true;
            this.colPersonID.Width = 200;
            // 
            // colFullname
            // 
            this.colFullname.HeaderText = "Full name";
            this.colFullname.MinimumWidth = 6;
            this.colFullname.Name = "colFullname";
            this.colFullname.ReadOnly = true;
            this.colFullname.Width = 250;
            // 
            // colNationalNumber
            // 
            this.colNationalNumber.HeaderText = "National Number";
            this.colNationalNumber.MinimumWidth = 6;
            this.colNationalNumber.Name = "colNationalNumber";
            this.colNationalNumber.ReadOnly = true;
            this.colNationalNumber.Width = 200;
            // 
            // colLicenseClass
            // 
            this.colLicenseClass.HeaderText = "License Class";
            this.colLicenseClass.MinimumWidth = 6;
            this.colLicenseClass.Name = "colLicenseClass";
            this.colLicenseClass.ReadOnly = true;
            this.colLicenseClass.Width = 300;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "Notes";
            this.colNotes.MinimumWidth = 6;
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            this.colNotes.Width = 160;
            // 
            // colPass
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.NullValue = false;
            this.colPass.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPass.HeaderText = "Pass";
            this.colPass.MinimumWidth = 6;
            this.colPass.Name = "colPass";
            this.colPass.ReadOnly = true;
            this.colPass.Width = 70;
            // 
            // colFail
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.NullValue = false;
            this.colFail.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFail.HeaderText = "Fail";
            this.colFail.MinimumWidth = 6;
            this.colFail.Name = "colFail";
            this.colFail.ReadOnly = true;
            this.colFail.Width = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 28);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // lbTestsScreen
            // 
            this.lbTestsScreen.AutoSize = true;
            this.lbTestsScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestsScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbTestsScreen.Location = new System.Drawing.Point(618, 12);
            this.lbTestsScreen.Name = "lbTestsScreen";
            this.lbTestsScreen.Size = new System.Drawing.Size(288, 51);
            this.lbTestsScreen.TabIndex = 15;
            this.lbTestsScreen.Text = "Tests Screen";
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(12, 99);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(58, 20);
            this.lbTest.TabIndex = 2;
            this.lbTest.Text = "Test :";
            // 
            // lbTestFees
            // 
            this.lbTestFees.AutoSize = true;
            this.lbTestFees.Location = new System.Drawing.Point(12, 145);
            this.lbTestFees.Name = "lbTestFees";
            this.lbTestFees.Size = new System.Drawing.Size(147, 20);
            this.lbTestFees.TabIndex = 3;
            this.lbTestFees.Text = "Test Fees Now :";
            // 
            // lbTestDescription
            // 
            this.lbTestDescription.AutoSize = true;
            this.lbTestDescription.Location = new System.Drawing.Point(12, 191);
            this.lbTestDescription.Name = "lbTestDescription";
            this.lbTestDescription.Size = new System.Drawing.Size(161, 20);
            this.lbTestDescription.TabIndex = 4;
            this.lbTestDescription.Text = "Test Description :";
            // 
            // lbMaxNubmerOfPeople
            // 
            this.lbMaxNubmerOfPeople.AutoSize = true;
            this.lbMaxNubmerOfPeople.Location = new System.Drawing.Point(12, 237);
            this.lbMaxNubmerOfPeople.Name = "lbMaxNubmerOfPeople";
            this.lbMaxNubmerOfPeople.Size = new System.Drawing.Size(215, 20);
            this.lbMaxNubmerOfPeople.TabIndex = 5;
            this.lbMaxNubmerOfPeople.Text = "Max Number Of People :";
            // 
            // lbAppointment
            // 
            this.lbAppointment.AutoSize = true;
            this.lbAppointment.Location = new System.Drawing.Point(755, 99);
            this.lbAppointment.Name = "lbAppointment";
            this.lbAppointment.Size = new System.Drawing.Size(125, 20);
            this.lbAppointment.TabIndex = 6;
            this.lbAppointment.Text = "Appointment :";
            // 
            // lbNumberOfPeopleRegistered
            // 
            this.lbNumberOfPeopleRegistered.AutoSize = true;
            this.lbNumberOfPeopleRegistered.Location = new System.Drawing.Point(755, 145);
            this.lbNumberOfPeopleRegistered.Name = "lbNumberOfPeopleRegistered";
            this.lbNumberOfPeopleRegistered.Size = new System.Drawing.Size(403, 20);
            this.lbNumberOfPeopleRegistered.TabIndex = 7;
            this.lbNumberOfPeopleRegistered.Text = "Number Of People Registered in Appointment :";
            // 
            // lbEnterApplicationID
            // 
            this.lbEnterApplicationID.AutoSize = true;
            this.lbEnterApplicationID.Location = new System.Drawing.Point(12, 368);
            this.lbEnterApplicationID.Name = "lbEnterApplicationID";
            this.lbEnterApplicationID.Size = new System.Drawing.Size(190, 20);
            this.lbEnterApplicationID.TabIndex = 8;
            this.lbEnterApplicationID.Text = "Enter Application ID :";
            // 
            // mtxtbApplicationID
            // 
            this.mtxtbApplicationID.AllowPromptAsInput = false;
            this.mtxtbApplicationID.Location = new System.Drawing.Point(246, 365);
            this.mtxtbApplicationID.Mask = "00000000000";
            this.mtxtbApplicationID.Name = "mtxtbApplicationID";
            this.mtxtbApplicationID.PromptChar = ' ';
            this.mtxtbApplicationID.Size = new System.Drawing.Size(221, 27);
            this.mtxtbApplicationID.SkipLiterals = false;
            this.mtxtbApplicationID.TabIndex = 0;
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.Silver;
            this.btRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.ForeColor = System.Drawing.Color.Black;
            this.btRegister.Location = new System.Drawing.Point(472, 366);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(291, 94);
            this.btRegister.TabIndex = 1;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // lbMaxNubmerOfPeopleResult
            // 
            this.lbMaxNubmerOfPeopleResult.AutoSize = true;
            this.lbMaxNubmerOfPeopleResult.Location = new System.Drawing.Point(270, 237);
            this.lbMaxNubmerOfPeopleResult.Name = "lbMaxNubmerOfPeopleResult";
            this.lbMaxNubmerOfPeopleResult.Size = new System.Drawing.Size(39, 20);
            this.lbMaxNubmerOfPeopleResult.TabIndex = 11;
            this.lbMaxNubmerOfPeopleResult.Text = "???";
            // 
            // cbTests
            // 
            this.cbTests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTests.FormattingEnabled = true;
            this.cbTests.Location = new System.Drawing.Point(246, 302);
            this.cbTests.Name = "cbTests";
            this.cbTests.Size = new System.Drawing.Size(221, 28);
            this.cbTests.TabIndex = 12;
            this.cbTests.SelectedIndexChanged += new System.EventHandler(this.cbTests_SelectedIndexChanged);
            // 
            // dtpTestAppointment
            // 
            this.dtpTestAppointment.CustomFormat = "d-M-yyyy";
            this.dtpTestAppointment.Enabled = false;
            this.dtpTestAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTestAppointment.Location = new System.Drawing.Point(246, 334);
            this.dtpTestAppointment.MinDate = new System.DateTime(2026, 1, 16, 15, 43, 18, 0);
            this.dtpTestAppointment.Name = "dtpTestAppointment";
            this.dtpTestAppointment.Size = new System.Drawing.Size(221, 27);
            this.dtpTestAppointment.TabIndex = 13;
            this.dtpTestAppointment.Value = new System.DateTime(2026, 1, 16, 15, 43, 18, 0);
            this.dtpTestAppointment.ValueChanged += new System.EventHandler(this.dtpTestAppointment_ValueChanged);
            // 
            // lbSelectTest
            // 
            this.lbSelectTest.AutoSize = true;
            this.lbSelectTest.Location = new System.Drawing.Point(12, 306);
            this.lbSelectTest.Name = "lbSelectTest";
            this.lbSelectTest.Size = new System.Drawing.Size(117, 20);
            this.lbSelectTest.TabIndex = 14;
            this.lbSelectTest.Text = "Select Test :";
            // 
            // lbSelectAppointment
            // 
            this.lbSelectAppointment.AutoSize = true;
            this.lbSelectAppointment.Location = new System.Drawing.Point(12, 337);
            this.lbSelectAppointment.Name = "lbSelectAppointment";
            this.lbSelectAppointment.Size = new System.Drawing.Size(184, 20);
            this.lbSelectAppointment.TabIndex = 15;
            this.lbSelectAppointment.Text = "Select Appointment :";
            // 
            // lbNumberOfPeopleRegisteredResult
            // 
            this.lbNumberOfPeopleRegisteredResult.AutoSize = true;
            this.lbNumberOfPeopleRegisteredResult.Location = new System.Drawing.Point(1186, 145);
            this.lbNumberOfPeopleRegisteredResult.Name = "lbNumberOfPeopleRegisteredResult";
            this.lbNumberOfPeopleRegisteredResult.Size = new System.Drawing.Size(39, 20);
            this.lbNumberOfPeopleRegisteredResult.TabIndex = 16;
            this.lbNumberOfPeopleRegisteredResult.Text = "???";
            // 
            // lbTestDescriptionResult
            // 
            this.lbTestDescriptionResult.AutoSize = true;
            this.lbTestDescriptionResult.Location = new System.Drawing.Point(13, 18);
            this.lbTestDescriptionResult.Name = "lbTestDescriptionResult";
            this.lbTestDescriptionResult.Size = new System.Drawing.Size(39, 20);
            this.lbTestDescriptionResult.TabIndex = 17;
            this.lbTestDescriptionResult.Text = "???";
            // 
            // lbAppointmentResult
            // 
            this.lbAppointmentResult.AutoSize = true;
            this.lbAppointmentResult.Location = new System.Drawing.Point(1186, 99);
            this.lbAppointmentResult.Name = "lbAppointmentResult";
            this.lbAppointmentResult.Size = new System.Drawing.Size(39, 20);
            this.lbAppointmentResult.TabIndex = 18;
            this.lbAppointmentResult.Text = "???";
            // 
            // lbTestResult
            // 
            this.lbTestResult.AutoSize = true;
            this.lbTestResult.Location = new System.Drawing.Point(270, 99);
            this.lbTestResult.Name = "lbTestResult";
            this.lbTestResult.Size = new System.Drawing.Size(39, 20);
            this.lbTestResult.TabIndex = 19;
            this.lbTestResult.Text = "???";
            // 
            // lbTestFeesResult
            // 
            this.lbTestFeesResult.AutoSize = true;
            this.lbTestFeesResult.Location = new System.Drawing.Point(270, 145);
            this.lbTestFeesResult.Name = "lbTestFeesResult";
            this.lbTestFeesResult.Size = new System.Drawing.Size(39, 20);
            this.lbTestFeesResult.TabIndex = 20;
            this.lbTestFeesResult.Text = "???";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbTestDescriptionResult);
            this.panel1.Location = new System.Drawing.Point(257, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 56);
            this.panel1.TabIndex = 21;
            // 
            // lbAppointmentCreatedByUser
            // 
            this.lbAppointmentCreatedByUser.AutoSize = true;
            this.lbAppointmentCreatedByUser.Location = new System.Drawing.Point(755, 191);
            this.lbAppointmentCreatedByUser.Name = "lbAppointmentCreatedByUser";
            this.lbAppointmentCreatedByUser.Size = new System.Drawing.Size(271, 20);
            this.lbAppointmentCreatedByUser.TabIndex = 22;
            this.lbAppointmentCreatedByUser.Text = "Appointment Created By User :";
            // 
            // lbAppointmentCreatedByUserResult
            // 
            this.lbAppointmentCreatedByUserResult.AutoSize = true;
            this.lbAppointmentCreatedByUserResult.Location = new System.Drawing.Point(1186, 191);
            this.lbAppointmentCreatedByUserResult.Name = "lbAppointmentCreatedByUserResult";
            this.lbAppointmentCreatedByUserResult.Size = new System.Drawing.Size(39, 20);
            this.lbAppointmentCreatedByUserResult.TabIndex = 23;
            this.lbAppointmentCreatedByUserResult.Text = "???";
            // 
            // btFindAvailableTestAppointment
            // 
            this.btFindAvailableTestAppointment.BackColor = System.Drawing.Color.Silver;
            this.btFindAvailableTestAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btFindAvailableTestAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btFindAvailableTestAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindAvailableTestAppointment.ForeColor = System.Drawing.Color.Black;
            this.btFindAvailableTestAppointment.Location = new System.Drawing.Point(471, 300);
            this.btFindAvailableTestAppointment.Name = "btFindAvailableTestAppointment";
            this.btFindAvailableTestAppointment.Size = new System.Drawing.Size(291, 31);
            this.btFindAvailableTestAppointment.TabIndex = 24;
            this.btFindAvailableTestAppointment.Text = "Find Available Test Appointment";
            this.btFindAvailableTestAppointment.UseVisualStyleBackColor = false;
            this.btFindAvailableTestAppointment.Click += new System.EventHandler(this.btFindAvailableTestAppointment_Click);
            // 
            // btCreateAppointment
            // 
            this.btCreateAppointment.BackColor = System.Drawing.Color.Silver;
            this.btCreateAppointment.Enabled = false;
            this.btCreateAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btCreateAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btCreateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateAppointment.ForeColor = System.Drawing.Color.Black;
            this.btCreateAppointment.Location = new System.Drawing.Point(471, 332);
            this.btCreateAppointment.Name = "btCreateAppointment";
            this.btCreateAppointment.Size = new System.Drawing.Size(291, 31);
            this.btCreateAppointment.TabIndex = 25;
            this.btCreateAppointment.Text = "Create Appointment";
            this.btCreateAppointment.UseVisualStyleBackColor = false;
            this.btCreateAppointment.Click += new System.EventHandler(this.btCreateAppointment_Click);
            // 
            // lbAddNotes
            // 
            this.lbAddNotes.AutoSize = true;
            this.lbAddNotes.Location = new System.Drawing.Point(12, 417);
            this.lbAddNotes.Name = "lbAddNotes";
            this.lbAddNotes.Size = new System.Drawing.Size(108, 20);
            this.lbAddNotes.TabIndex = 26;
            this.lbAddNotes.Text = "Add Notes :";
            // 
            // txtbNotes
            // 
            this.txtbNotes.Location = new System.Drawing.Point(246, 396);
            this.txtbNotes.Multiline = true;
            this.txtbNotes.Name = "txtbNotes";
            this.txtbNotes.Size = new System.Drawing.Size(221, 62);
            this.txtbNotes.TabIndex = 27;
            // 
            // btFindTestDay
            // 
            this.btFindTestDay.BackColor = System.Drawing.Color.Silver;
            this.btFindTestDay.Enabled = false;
            this.btFindTestDay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btFindTestDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btFindTestDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindTestDay.ForeColor = System.Drawing.Color.Black;
            this.btFindTestDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFindTestDay.Location = new System.Drawing.Point(766, 300);
            this.btFindTestDay.Name = "btFindTestDay";
            this.btFindTestDay.Size = new System.Drawing.Size(137, 63);
            this.btFindTestDay.TabIndex = 28;
            this.btFindTestDay.Text = "Find Test Day";
            this.btFindTestDay.UseVisualStyleBackColor = false;
            this.btFindTestDay.Visible = false;
            this.btFindTestDay.Click += new System.EventHandler(this.btFindTestDay_Click);
            // 
            // btAdoptResult
            // 
            this.btAdoptResult.BackColor = System.Drawing.Color.Silver;
            this.btAdoptResult.Enabled = false;
            this.btAdoptResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btAdoptResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btAdoptResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdoptResult.ForeColor = System.Drawing.Color.Black;
            this.btAdoptResult.Location = new System.Drawing.Point(766, 365);
            this.btAdoptResult.Name = "btAdoptResult";
            this.btAdoptResult.Size = new System.Drawing.Size(137, 91);
            this.btAdoptResult.TabIndex = 29;
            this.btAdoptResult.Text = "Adopt Result";
            this.btAdoptResult.UseVisualStyleBackColor = false;
            this.btAdoptResult.Visible = false;
            this.btAdoptResult.Click += new System.EventHandler(this.btAdoptResult_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::DLMApp_PresentationLayer.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(234, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 119;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::DLMApp_PresentationLayer.Properties.Resources.Test_32;
            this.pictureBox2.Location = new System.Drawing.Point(234, 189);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 118;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(234, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.TestType_32;
            this.pictureBox4.Location = new System.Drawing.Point(234, 97);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 120;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Image = global::DLMApp_PresentationLayer.Properties.Resources.TestType_32;
            this.pictureBox5.Location = new System.Drawing.Point(210, 304);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 121;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Image = global::DLMApp_PresentationLayer.Properties.Resources.Notes_32;
            this.pictureBox6.Location = new System.Drawing.Point(210, 415);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 122;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(210, 366);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 123;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Black;
            this.pictureBox8.Image = global::DLMApp_PresentationLayer.Properties.Resources.Calendar_32;
            this.pictureBox8.Location = new System.Drawing.Point(210, 335);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 124;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox9.Location = new System.Drawing.Point(1156, 143);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 125;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.Image = global::DLMApp_PresentationLayer.Properties.Resources.Person_32;
            this.pictureBox10.Location = new System.Drawing.Point(1156, 189);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 126;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Black;
            this.pictureBox11.Image = global::DLMApp_PresentationLayer.Properties.Resources.Calendar_32;
            this.pictureBox11.Location = new System.Drawing.Point(1156, 97);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 127;
            this.pictureBox11.TabStop = false;
            // 
            // fmTestsScreen
            // 
            this.AcceptButton = this.btRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1419, 780);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAdoptResult);
            this.Controls.Add(this.btFindTestDay);
            this.Controls.Add(this.txtbNotes);
            this.Controls.Add(this.lbAddNotes);
            this.Controls.Add(this.btCreateAppointment);
            this.Controls.Add(this.btFindAvailableTestAppointment);
            this.Controls.Add(this.lbAppointmentCreatedByUserResult);
            this.Controls.Add(this.lbAppointmentCreatedByUser);
            this.Controls.Add(this.lbAppointmentResult);
            this.Controls.Add(this.lbNumberOfPeopleRegisteredResult);
            this.Controls.Add(this.lbNumberOfPeopleRegistered);
            this.Controls.Add(this.lbMaxNubmerOfPeople);
            this.Controls.Add(this.lbAppointment);
            this.Controls.Add(this.lbTestDescription);
            this.Controls.Add(this.lbTestFees);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTestFeesResult);
            this.Controls.Add(this.lbMaxNubmerOfPeopleResult);
            this.Controls.Add(this.lbSelectAppointment);
            this.Controls.Add(this.lbSelectTest);
            this.Controls.Add(this.dtpTestAppointment);
            this.Controls.Add(this.cbTests);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.lbTestResult);
            this.Controls.Add(this.mtxtbApplicationID);
            this.Controls.Add(this.lbEnterApplicationID);
            this.Controls.Add(this.lbTestsScreen);
            this.Controls.Add(this.dgvPeopleRegisteredForTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmTestsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tests Screen";
            this.Load += new System.EventHandler(this.fmTestsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleRegisteredForTest)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeopleRegisteredForTest;
        private System.Windows.Forms.Label lbTestsScreen;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Label lbTestFees;
        private System.Windows.Forms.Label lbTestDescription;
        private System.Windows.Forms.Label lbMaxNubmerOfPeople;
        private System.Windows.Forms.Label lbAppointment;
        private System.Windows.Forms.Label lbNumberOfPeopleRegistered;
        private System.Windows.Forms.Label lbEnterApplicationID;
        private System.Windows.Forms.MaskedTextBox mtxtbApplicationID;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label lbMaxNubmerOfPeopleResult;
        private System.Windows.Forms.ComboBox cbTests;
        private System.Windows.Forms.DateTimePicker dtpTestAppointment;
        private System.Windows.Forms.Label lbSelectTest;
        private System.Windows.Forms.Label lbSelectAppointment;
        private System.Windows.Forms.Label lbNumberOfPeopleRegisteredResult;
        private System.Windows.Forms.Label lbTestDescriptionResult;
        private System.Windows.Forms.Label lbAppointmentResult;
        private System.Windows.Forms.Label lbTestResult;
        private System.Windows.Forms.Label lbTestFeesResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAppointmentCreatedByUser;
        private System.Windows.Forms.Label lbAppointmentCreatedByUserResult;
        private System.Windows.Forms.Button btFindAvailableTestAppointment;
        private System.Windows.Forms.Button btCreateAppointment;
        private System.Windows.Forms.Label lbAddNotes;
        private System.Windows.Forms.TextBox txtbNotes;
        private System.Windows.Forms.Button btFindTestDay;
        private System.Windows.Forms.Button btAdoptResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicenseClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}