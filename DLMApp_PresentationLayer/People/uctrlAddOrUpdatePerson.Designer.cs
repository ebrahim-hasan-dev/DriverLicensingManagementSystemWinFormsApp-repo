namespace DLMApp_PresentationLayer
{
    partial class uctrlAddOrUpdatePerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btSave = new System.Windows.Forms.Button();
            this.lbPersonIDResult = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.llbSetImage = new System.Windows.Forms.LinkLabel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone2 = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone1 = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.pctbNewPerson = new System.Windows.Forms.PictureBox();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbNationalNumber = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.mtxtbPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbPhone1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbNationalNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbThirdName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.txtbSecondName = new System.Windows.Forms.TextBox();
            this.txtbThirdName = new System.Windows.Forms.TextBox();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbNewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Silver;
            this.btSave.Enabled = false;
            this.btSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Image = global::DLMApp_PresentationLayer.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(919, 497);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 40);
            this.btSave.TabIndex = 75;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbPersonIDResult
            // 
            this.lbPersonIDResult.AutoSize = true;
            this.lbPersonIDResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonIDResult.ForeColor = System.Drawing.Color.Red;
            this.lbPersonIDResult.Location = new System.Drawing.Point(186, 9);
            this.lbPersonIDResult.Name = "lbPersonIDResult";
            this.lbPersonIDResult.Size = new System.Drawing.Size(62, 25);
            this.lbPersonIDResult.TabIndex = 72;
            this.lbPersonIDResult.Text = "[???]";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.ForeColor = System.Drawing.Color.Red;
            this.lbPersonID.Location = new System.Drawing.Point(7, 9);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(120, 25);
            this.lbPersonID.TabIndex = 71;
            this.lbPersonID.Text = "Person ID :";
            // 
            // llbSetImage
            // 
            this.llbSetImage.AutoSize = true;
            this.llbSetImage.Location = new System.Drawing.Point(867, 430);
            this.llbSetImage.Name = "llbSetImage";
            this.llbSetImage.Size = new System.Drawing.Size(93, 20);
            this.llbSetImage.TabIndex = 58;
            this.llbSetImage.TabStop = true;
            this.llbSetImage.Text = "Set Image";
            this.llbSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSetImage_LinkClicked);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(384, 271);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(68, 20);
            this.lbEmail.TabIndex = 70;
            this.lbEmail.Text = "Email :";
            // 
            // lbPhone2
            // 
            this.lbPhone2.AutoSize = true;
            this.lbPhone2.Location = new System.Drawing.Point(7, 341);
            this.lbPhone2.Name = "lbPhone2";
            this.lbPhone2.Size = new System.Drawing.Size(89, 20);
            this.lbPhone2.TabIndex = 69;
            this.lbPhone2.Text = "Phone 2 :";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(384, 341);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(86, 20);
            this.lbCountry.TabIndex = 67;
            this.lbCountry.Text = "Country :";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(7, 435);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(90, 20);
            this.lbAddress.TabIndex = 66;
            this.lbAddress.Text = "Address :";
            // 
            // lbPhone1
            // 
            this.lbPhone1.AutoSize = true;
            this.lbPhone1.Location = new System.Drawing.Point(7, 271);
            this.lbPhone1.Name = "lbPhone1";
            this.lbPhone1.Size = new System.Drawing.Size(89, 20);
            this.lbPhone1.TabIndex = 65;
            this.lbPhone1.Text = "Phone 1 :";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(7, 207);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(82, 20);
            this.lbGender.TabIndex = 64;
            this.lbGender.Text = "Gender :";
            // 
            // pctbNewPerson
            // 
            this.pctbNewPerson.Image = global::DLMApp_PresentationLayer.Properties.Resources.Male_512;
            this.pctbNewPerson.Location = new System.Drawing.Point(795, 205);
            this.pctbNewPerson.Name = "pctbNewPerson";
            this.pctbNewPerson.Size = new System.Drawing.Size(237, 210);
            this.pctbNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbNewPerson.TabIndex = 63;
            this.pctbNewPerson.TabStop = false;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Location = new System.Drawing.Point(417, 146);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(134, 20);
            this.lbDateOfBirth.TabIndex = 62;
            this.lbDateOfBirth.Text = "Date Of Birth :";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(388, 205);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(91, 24);
            this.rbFemale.TabIndex = 52;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(234, 205);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(70, 24);
            this.rbMale.TabIndex = 51;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // lbNationalNumber
            // 
            this.lbNationalNumber.AutoSize = true;
            this.lbNationalNumber.Location = new System.Drawing.Point(7, 144);
            this.lbNationalNumber.Name = "lbNationalNumber";
            this.lbNationalNumber.Size = new System.Drawing.Size(161, 20);
            this.lbNationalNumber.TabIndex = 61;
            this.lbNationalNumber.Text = "National Number :";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(608, 141);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2026, 1, 9, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1936, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(211, 27);
            this.dtpDateOfBirth.TabIndex = 50;
            this.dtpDateOfBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbCountries
            // 
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(526, 337);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(240, 28);
            this.cbCountries.TabIndex = 56;
            // 
            // mtxtbPhone2
            // 
            this.mtxtbPhone2.AllowPromptAsInput = false;
            this.mtxtbPhone2.Location = new System.Drawing.Point(234, 338);
            this.mtxtbPhone2.Mask = "00000000000";
            this.mtxtbPhone2.Name = "mtxtbPhone2";
            this.mtxtbPhone2.PromptChar = ' ';
            this.mtxtbPhone2.Size = new System.Drawing.Size(130, 27);
            this.mtxtbPhone2.TabIndex = 54;
            this.mtxtbPhone2.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtbPhone2_Validating);
            // 
            // mtxtbPhone1
            // 
            this.mtxtbPhone1.AllowPromptAsInput = false;
            this.mtxtbPhone1.Location = new System.Drawing.Point(234, 268);
            this.mtxtbPhone1.Mask = "00000000000";
            this.mtxtbPhone1.Name = "mtxtbPhone1";
            this.mtxtbPhone1.PromptChar = ' ';
            this.mtxtbPhone1.Size = new System.Drawing.Size(130, 27);
            this.mtxtbPhone1.TabIndex = 53;
            this.mtxtbPhone1.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtbPhone1_Validating);
            // 
            // mtxtbNationalNumber
            // 
            this.mtxtbNationalNumber.AllowPromptAsInput = false;
            this.mtxtbNationalNumber.Location = new System.Drawing.Point(234, 141);
            this.mtxtbNationalNumber.Mask = "00000000000000";
            this.mtxtbNationalNumber.Name = "mtxtbNationalNumber";
            this.mtxtbNationalNumber.PromptChar = ' ';
            this.mtxtbNationalNumber.Size = new System.Drawing.Size(162, 27);
            this.mtxtbNationalNumber.TabIndex = 49;
            this.mtxtbNationalNumber.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtbNationalNumber_Validating);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(230, 53);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(48, 20);
            this.lbFirstName.TabIndex = 68;
            this.lbFirstName.Text = "First";
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Location = new System.Drawing.Point(417, 53);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(71, 20);
            this.lbSecondName.TabIndex = 76;
            this.lbSecondName.Text = "Second";
            // 
            // lbThirdName
            // 
            this.lbThirdName.AutoSize = true;
            this.lbThirdName.Location = new System.Drawing.Point(604, 53);
            this.lbThirdName.Name = "lbThirdName";
            this.lbThirdName.Size = new System.Drawing.Size(52, 20);
            this.lbThirdName.TabIndex = 73;
            this.lbThirdName.Text = "Third";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(793, 53);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(46, 20);
            this.lbLastName.TabIndex = 77;
            this.lbLastName.Text = "Last";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(7, 79);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 20);
            this.lbName.TabIndex = 59;
            this.lbName.Text = "Name :";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(526, 268);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(240, 27);
            this.txtbEmail.TabIndex = 55;
            this.txtbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtbEmail_Validating);
            // 
            // txtbAddress
            // 
            this.txtbAddress.Location = new System.Drawing.Point(234, 406);
            this.txtbAddress.Multiline = true;
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(330, 78);
            this.txtbAddress.TabIndex = 57;
            // 
            // txtbSecondName
            // 
            this.txtbSecondName.Location = new System.Drawing.Point(421, 76);
            this.txtbSecondName.Name = "txtbSecondName";
            this.txtbSecondName.Size = new System.Drawing.Size(162, 27);
            this.txtbSecondName.TabIndex = 46;
            // 
            // txtbThirdName
            // 
            this.txtbThirdName.Location = new System.Drawing.Point(608, 76);
            this.txtbThirdName.Name = "txtbThirdName";
            this.txtbThirdName.Size = new System.Drawing.Size(162, 27);
            this.txtbThirdName.TabIndex = 47;
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(795, 76);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(162, 27);
            this.txtbLastName.TabIndex = 48;
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(234, 76);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(162, 27);
            this.txtbFirstName.TabIndex = 45;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "(*.png)|*.png| (*.jpg) |*.jpg|(*.svg)|*.svg";
            this.openFileDialog1.Title = "Choice Image";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(191, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DLMApp_PresentationLayer.Properties.Resources.Address_32;
            this.pictureBox2.Location = new System.Drawing.Point(490, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DLMApp_PresentationLayer.Properties.Resources.Calendar_32;
            this.pictureBox3.Location = new System.Drawing.Point(565, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Country_32;
            this.pictureBox4.Location = new System.Drawing.Point(490, 339);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 81;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DLMApp_PresentationLayer.Properties.Resources.Address_32;
            this.pictureBox5.Location = new System.Drawing.Point(191, 433);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 82;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DLMApp_PresentationLayer.Properties.Resources.Phone_32;
            this.pictureBox6.Location = new System.Drawing.Point(191, 339);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 83;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DLMApp_PresentationLayer.Properties.Resources.Phone_32;
            this.pictureBox7.Location = new System.Drawing.Point(191, 269);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 84;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DLMApp_PresentationLayer.Properties.Resources.Female_512;
            this.pictureBox8.Location = new System.Drawing.Point(348, 205);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 85;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DLMApp_PresentationLayer.Properties.Resources.Male_512;
            this.pictureBox9.Location = new System.Drawing.Point(191, 205);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 86;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox10.Location = new System.Drawing.Point(191, 142);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 25);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 87;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox11.Location = new System.Drawing.Point(150, 9);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 88;
            this.pictureBox11.TabStop = false;
            // 
            // uctrlAddOrUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
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
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbPersonIDResult);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.llbSetImage);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPhone2);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPhone1);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.pctbNewPerson);
            this.Controls.Add(this.lbDateOfBirth);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lbNationalNumber);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.mtxtbPhone2);
            this.Controls.Add(this.mtxtbPhone1);
            this.Controls.Add(this.mtxtbNationalNumber);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbSecondName);
            this.Controls.Add(this.lbThirdName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbAddress);
            this.Controls.Add(this.txtbSecondName);
            this.Controls.Add(this.txtbThirdName);
            this.Controls.Add(this.txtbLastName);
            this.Controls.Add(this.txtbFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uctrlAddOrUpdatePerson";
            this.Size = new System.Drawing.Size(1046, 544);
            this.Load += new System.EventHandler(this.uctrlAddOrUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbNewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label lbPersonIDResult;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.LinkLabel llbSetImage;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone2;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone1;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.PictureBox pctbNewPerson;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lbNationalNumber;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.MaskedTextBox mtxtbPhone2;
        private System.Windows.Forms.MaskedTextBox mtxtbPhone1;
        private System.Windows.Forms.MaskedTextBox mtxtbNationalNumber;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Label lbThirdName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.TextBox txtbSecondName;
        private System.Windows.Forms.TextBox txtbThirdName;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button btSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}
