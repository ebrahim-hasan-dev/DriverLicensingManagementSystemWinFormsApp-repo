namespace DLMApp_PresentationLayer
{
    partial class fmNewLocalLicenseScreen
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
            this.tabcNewLocalLicense = new System.Windows.Forms.TabControl();
            this.tabpPersonInfo = new System.Windows.Forms.TabPage();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.uctrlPersonInfo1 = new DLMApp_PresentationLayer.uctrlPersonInfo();
            this.mtxtbNationalNumber = new System.Windows.Forms.MaskedTextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbEnterNationalNumber = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.llbAddNewPerson = new System.Windows.Forms.LinkLabel();
            this.tabpApplicationInfo = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.uctrlApplicationInfo1 = new DLMApp_PresentationLayer.uctrlApplicationInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLicenseDescriptionResult = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.lbLicenseValidityPeriodResult = new System.Windows.Forms.Label();
            this.lbMinimumAllowedAgeResult = new System.Windows.Forms.Label();
            this.cbLicensesClasses = new System.Windows.Forms.ComboBox();
            this.lbLicenseValidityPeriod = new System.Windows.Forms.Label();
            this.lbMinimumAllowedAge = new System.Windows.Forms.Label();
            this.lbLicenseDescription = new System.Windows.Forms.Label();
            this.lbSelectLicenseType = new System.Windows.Forms.Label();
            this.lbNewLocalLicenseScreen = new System.Windows.Forms.Label();
            this.tabcNewLocalLicense.SuspendLayout();
            this.tabpPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.tabpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcNewLocalLicense
            // 
            this.tabcNewLocalLicense.Controls.Add(this.tabpPersonInfo);
            this.tabcNewLocalLicense.Controls.Add(this.tabpApplicationInfo);
            this.tabcNewLocalLicense.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabcNewLocalLicense.Location = new System.Drawing.Point(0, 83);
            this.tabcNewLocalLicense.Name = "tabcNewLocalLicense";
            this.tabcNewLocalLicense.SelectedIndex = 0;
            this.tabcNewLocalLicense.Size = new System.Drawing.Size(1180, 507);
            this.tabcNewLocalLicense.TabIndex = 22;
            // 
            // tabpPersonInfo
            // 
            this.tabpPersonInfo.BackColor = System.Drawing.Color.Black;
            this.tabpPersonInfo.Controls.Add(this.pictureBox11);
            this.tabpPersonInfo.Controls.Add(this.uctrlPersonInfo1);
            this.tabpPersonInfo.Controls.Add(this.mtxtbNationalNumber);
            this.tabpPersonInfo.Controls.Add(this.btSearch);
            this.tabpPersonInfo.Controls.Add(this.lbEnterNationalNumber);
            this.tabpPersonInfo.Controls.Add(this.btNext);
            this.tabpPersonInfo.Controls.Add(this.llbAddNewPerson);
            this.tabpPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tabpPersonInfo.Name = "tabpPersonInfo";
            this.tabpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpPersonInfo.Size = new System.Drawing.Size(1172, 474);
            this.tabpPersonInfo.TabIndex = 0;
            this.tabpPersonInfo.Text = "Person Info";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Black;
            this.pictureBox11.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox11.Location = new System.Drawing.Point(231, 71);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 25);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 124;
            this.pictureBox11.TabStop = false;
            // 
            // uctrlPersonInfo1
            // 
            this.uctrlPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlPersonInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlPersonInfo1.Location = new System.Drawing.Point(11, 127);
            this.uctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlPersonInfo1.Name = "uctrlPersonInfo1";
            this.uctrlPersonInfo1.Size = new System.Drawing.Size(1150, 225);
            this.uctrlPersonInfo1.TabIndex = 7;
            // 
            // mtxtbNationalNumber
            // 
            this.mtxtbNationalNumber.AllowPromptAsInput = false;
            this.mtxtbNationalNumber.Location = new System.Drawing.Point(266, 70);
            this.mtxtbNationalNumber.Mask = "00000000000000";
            this.mtxtbNationalNumber.Name = "mtxtbNationalNumber";
            this.mtxtbNationalNumber.PromptChar = ' ';
            this.mtxtbNationalNumber.Size = new System.Drawing.Size(163, 27);
            this.mtxtbNationalNumber.SkipLiterals = false;
            this.mtxtbNationalNumber.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Silver;
            this.btSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.ForeColor = System.Drawing.Color.Black;
            this.btSearch.Image = global::DLMApp_PresentationLayer.Properties.Resources.SearchPerson;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.Location = new System.Drawing.Point(433, 63);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(120, 40);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbEnterNationalNumber
            // 
            this.lbEnterNationalNumber.AutoSize = true;
            this.lbEnterNationalNumber.Location = new System.Drawing.Point(18, 73);
            this.lbEnterNationalNumber.Name = "lbEnterNationalNumber";
            this.lbEnterNationalNumber.Size = new System.Drawing.Size(212, 20);
            this.lbEnterNationalNumber.TabIndex = 10;
            this.lbEnterNationalNumber.Text = "Enter National Number :";
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.Silver;
            this.btNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.ForeColor = System.Drawing.Color.Black;
            this.btNext.Image = global::DLMApp_PresentationLayer.Properties.Resources.Next_32;
            this.btNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNext.Location = new System.Drawing.Point(1051, 433);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(120, 40);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // llbAddNewPerson
            // 
            this.llbAddNewPerson.AutoSize = true;
            this.llbAddNewPerson.Location = new System.Drawing.Point(494, 15);
            this.llbAddNewPerson.Name = "llbAddNewPerson";
            this.llbAddNewPerson.Size = new System.Drawing.Size(148, 20);
            this.llbAddNewPerson.TabIndex = 4;
            this.llbAddNewPerson.TabStop = true;
            this.llbAddNewPerson.Text = "Add New Person";
            this.llbAddNewPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAddNewPerson_LinkClicked);
            // 
            // tabpApplicationInfo
            // 
            this.tabpApplicationInfo.BackColor = System.Drawing.Color.Black;
            this.tabpApplicationInfo.Controls.Add(this.pictureBox2);
            this.tabpApplicationInfo.Controls.Add(this.pictureBox5);
            this.tabpApplicationInfo.Controls.Add(this.pictureBox6);
            this.tabpApplicationInfo.Controls.Add(this.pictureBox1);
            this.tabpApplicationInfo.Controls.Add(this.btCancel);
            this.tabpApplicationInfo.Controls.Add(this.uctrlApplicationInfo1);
            this.tabpApplicationInfo.Controls.Add(this.panel1);
            this.tabpApplicationInfo.Controls.Add(this.btSave);
            this.tabpApplicationInfo.Controls.Add(this.lbLicenseValidityPeriodResult);
            this.tabpApplicationInfo.Controls.Add(this.lbMinimumAllowedAgeResult);
            this.tabpApplicationInfo.Controls.Add(this.cbLicensesClasses);
            this.tabpApplicationInfo.Controls.Add(this.lbLicenseValidityPeriod);
            this.tabpApplicationInfo.Controls.Add(this.lbMinimumAllowedAge);
            this.tabpApplicationInfo.Controls.Add(this.lbLicenseDescription);
            this.tabpApplicationInfo.Controls.Add(this.lbSelectLicenseType);
            this.tabpApplicationInfo.Location = new System.Drawing.Point(4, 29);
            this.tabpApplicationInfo.Name = "tabpApplicationInfo";
            this.tabpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpApplicationInfo.Size = new System.Drawing.Size(1172, 474);
            this.tabpApplicationInfo.TabIndex = 1;
            this.tabpApplicationInfo.Text = "Application Info";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(297, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 145;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox5.Location = new System.Drawing.Point(297, 125);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 144;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Image = global::DLMApp_PresentationLayer.Properties.Resources.Notes_32;
            this.pictureBox6.Location = new System.Drawing.Point(297, 80);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 123;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.License_Type_32;
            this.pictureBox1.Location = new System.Drawing.Point(297, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Silver;
            this.btCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.Color.Black;
            this.btCancel.Image = global::DLMApp_PresentationLayer.Properties.Resources.Close_32;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(928, 433);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 31;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // uctrlApplicationInfo1
            // 
            this.uctrlApplicationInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlApplicationInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlApplicationInfo1.Location = new System.Drawing.Point(17, 256);
            this.uctrlApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlApplicationInfo1.Name = "uctrlApplicationInfo1";
            this.uctrlApplicationInfo1.Size = new System.Drawing.Size(568, 176);
            this.uctrlApplicationInfo1.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbLicenseDescriptionResult);
            this.panel1.Location = new System.Drawing.Point(323, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 55);
            this.panel1.TabIndex = 28;
            // 
            // lbLicenseDescriptionResult
            // 
            this.lbLicenseDescriptionResult.AutoSize = true;
            this.lbLicenseDescriptionResult.Location = new System.Drawing.Point(7, 18);
            this.lbLicenseDescriptionResult.Name = "lbLicenseDescriptionResult";
            this.lbLicenseDescriptionResult.Size = new System.Drawing.Size(39, 20);
            this.lbLicenseDescriptionResult.TabIndex = 10;
            this.lbLicenseDescriptionResult.Text = "???";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Silver;
            this.btSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Image = global::DLMApp_PresentationLayer.Properties.Resources.Save_32;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(1051, 433);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 40);
            this.btSave.TabIndex = 27;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbLicenseValidityPeriodResult
            // 
            this.lbLicenseValidityPeriodResult.AutoSize = true;
            this.lbLicenseValidityPeriodResult.Location = new System.Drawing.Point(332, 173);
            this.lbLicenseValidityPeriodResult.Name = "lbLicenseValidityPeriodResult";
            this.lbLicenseValidityPeriodResult.Size = new System.Drawing.Size(39, 20);
            this.lbLicenseValidityPeriodResult.TabIndex = 24;
            this.lbLicenseValidityPeriodResult.Text = "???";
            // 
            // lbMinimumAllowedAgeResult
            // 
            this.lbMinimumAllowedAgeResult.AutoSize = true;
            this.lbMinimumAllowedAgeResult.Location = new System.Drawing.Point(330, 127);
            this.lbMinimumAllowedAgeResult.Name = "lbMinimumAllowedAgeResult";
            this.lbMinimumAllowedAgeResult.Size = new System.Drawing.Size(39, 20);
            this.lbMinimumAllowedAgeResult.TabIndex = 23;
            this.lbMinimumAllowedAgeResult.Text = "???";
            // 
            // cbLicensesClasses
            // 
            this.cbLicensesClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicensesClasses.FormattingEnabled = true;
            this.cbLicensesClasses.Location = new System.Drawing.Point(336, 29);
            this.cbLicensesClasses.Name = "cbLicensesClasses";
            this.cbLicensesClasses.Size = new System.Drawing.Size(295, 28);
            this.cbLicensesClasses.TabIndex = 22;
            this.cbLicensesClasses.SelectedIndexChanged += new System.EventHandler(this.cbLicensesClasses_SelectedIndexChanged);
            // 
            // lbLicenseValidityPeriod
            // 
            this.lbLicenseValidityPeriod.AutoSize = true;
            this.lbLicenseValidityPeriod.Location = new System.Drawing.Point(26, 173);
            this.lbLicenseValidityPeriod.Name = "lbLicenseValidityPeriod";
            this.lbLicenseValidityPeriod.Size = new System.Drawing.Size(215, 20);
            this.lbLicenseValidityPeriod.TabIndex = 20;
            this.lbLicenseValidityPeriod.Text = "License Validity Period :";
            // 
            // lbMinimumAllowedAge
            // 
            this.lbMinimumAllowedAge.AutoSize = true;
            this.lbMinimumAllowedAge.Location = new System.Drawing.Point(26, 127);
            this.lbMinimumAllowedAge.Name = "lbMinimumAllowedAge";
            this.lbMinimumAllowedAge.Size = new System.Drawing.Size(205, 20);
            this.lbMinimumAllowedAge.TabIndex = 19;
            this.lbMinimumAllowedAge.Text = "Minimum Allowed Age :";
            // 
            // lbLicenseDescription
            // 
            this.lbLicenseDescription.AutoSize = true;
            this.lbLicenseDescription.Location = new System.Drawing.Point(26, 82);
            this.lbLicenseDescription.Name = "lbLicenseDescription";
            this.lbLicenseDescription.Size = new System.Drawing.Size(190, 20);
            this.lbLicenseDescription.TabIndex = 18;
            this.lbLicenseDescription.Text = "License Description :";
            // 
            // lbSelectLicenseType
            // 
            this.lbSelectLicenseType.AutoSize = true;
            this.lbSelectLicenseType.Location = new System.Drawing.Point(26, 37);
            this.lbSelectLicenseType.Name = "lbSelectLicenseType";
            this.lbSelectLicenseType.Size = new System.Drawing.Size(192, 20);
            this.lbSelectLicenseType.TabIndex = 29;
            this.lbSelectLicenseType.Text = "Select License Type :";
            // 
            // lbNewLocalLicenseScreen
            // 
            this.lbNewLocalLicenseScreen.AutoSize = true;
            this.lbNewLocalLicenseScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewLocalLicenseScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbNewLocalLicenseScreen.Location = new System.Drawing.Point(284, 9);
            this.lbNewLocalLicenseScreen.Name = "lbNewLocalLicenseScreen";
            this.lbNewLocalLicenseScreen.Size = new System.Drawing.Size(556, 51);
            this.lbNewLocalLicenseScreen.TabIndex = 62;
            this.lbNewLocalLicenseScreen.Text = "New Local License Screen";
            // 
            // fmNewLocalLicenseScreen
            // 
            this.AcceptButton = this.btSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1180, 590);
            this.Controls.Add(this.lbNewLocalLicenseScreen);
            this.Controls.Add(this.tabcNewLocalLicense);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmNewLocalLicenseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local License";
            this.Load += new System.EventHandler(this.fmNewLocalLicense_Load);
            this.tabcNewLocalLicense.ResumeLayout(false);
            this.tabpPersonInfo.ResumeLayout(false);
            this.tabpPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.tabpApplicationInfo.ResumeLayout(false);
            this.tabpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcNewLocalLicense;
        private System.Windows.Forms.TabPage tabpPersonInfo;
        private System.Windows.Forms.TabPage tabpApplicationInfo;
        private System.Windows.Forms.LinkLabel llbAddNewPerson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLicenseDescriptionResult;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbLicenseValidityPeriodResult;
        private System.Windows.Forms.Label lbMinimumAllowedAgeResult;
        private System.Windows.Forms.ComboBox cbLicensesClasses;
        private System.Windows.Forms.Label lbLicenseValidityPeriod;
        private System.Windows.Forms.Label lbMinimumAllowedAge;
        private System.Windows.Forms.Label lbLicenseDescription;
        private System.Windows.Forms.Label lbSelectLicenseType;
        private System.Windows.Forms.Button btNext;
        private uctrlApplicationInfo uctrlApplicationInfo1;
        private System.Windows.Forms.Label lbNewLocalLicenseScreen;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.MaskedTextBox mtxtbNationalNumber;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbEnterNationalNumber;
        private uctrlPersonInfo uctrlPersonInfo1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}