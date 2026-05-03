namespace DLMApp_PresentationLayer
{
    partial class fmLostReplacementScreen
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
            this.lbEnterNationalNumber = new System.Windows.Forms.Label();
            this.mtxtbNationalNumber = new System.Windows.Forms.MaskedTextBox();
            this.cbLicensesClasses = new System.Windows.Forms.ComboBox();
            this.lbSelectLicenseType = new System.Windows.Forms.Label();
            this.btIssue = new System.Windows.Forms.Button();
            this.uctrlLisenseInfo1 = new DLMApp_PresentationLayer.uctrlLisenseInfo();
            this.uctrlApplicationInfo1 = new DLMApp_PresentationLayer.uctrlApplicationInfo();
            this.lbLostReplacementScreen = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEnterNationalNumber
            // 
            this.lbEnterNationalNumber.AutoSize = true;
            this.lbEnterNationalNumber.Location = new System.Drawing.Point(19, 107);
            this.lbEnterNationalNumber.Name = "lbEnterNationalNumber";
            this.lbEnterNationalNumber.Size = new System.Drawing.Size(212, 20);
            this.lbEnterNationalNumber.TabIndex = 0;
            this.lbEnterNationalNumber.Text = "Enter National Number :";
            // 
            // mtxtbNationalNumber
            // 
            this.mtxtbNationalNumber.AllowPromptAsInput = false;
            this.mtxtbNationalNumber.Location = new System.Drawing.Point(289, 104);
            this.mtxtbNationalNumber.Mask = "00000000000000";
            this.mtxtbNationalNumber.Name = "mtxtbNationalNumber";
            this.mtxtbNationalNumber.PromptChar = ' ';
            this.mtxtbNationalNumber.Size = new System.Drawing.Size(152, 27);
            this.mtxtbNationalNumber.TabIndex = 1;
            // 
            // cbLicensesClasses
            // 
            this.cbLicensesClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicensesClasses.FormattingEnabled = true;
            this.cbLicensesClasses.Location = new System.Drawing.Point(289, 135);
            this.cbLicensesClasses.Name = "cbLicensesClasses";
            this.cbLicensesClasses.Size = new System.Drawing.Size(295, 28);
            this.cbLicensesClasses.TabIndex = 2;
            this.cbLicensesClasses.SelectedIndexChanged += new System.EventHandler(this.cbLicensesClasses_SelectedIndexChanged);
            // 
            // lbSelectLicenseType
            // 
            this.lbSelectLicenseType.AutoSize = true;
            this.lbSelectLicenseType.Location = new System.Drawing.Point(19, 139);
            this.lbSelectLicenseType.Name = "lbSelectLicenseType";
            this.lbSelectLicenseType.Size = new System.Drawing.Size(192, 20);
            this.lbSelectLicenseType.TabIndex = 3;
            this.lbSelectLicenseType.Text = "Select License Type :";
            // 
            // btIssue
            // 
            this.btIssue.BackColor = System.Drawing.Color.Silver;
            this.btIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIssue.ForeColor = System.Drawing.Color.Black;
            this.btIssue.Image = global::DLMApp_PresentationLayer.Properties.Resources.IssueDrivingLicense_32;
            this.btIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIssue.Location = new System.Drawing.Point(1143, 683);
            this.btIssue.Name = "btIssue";
            this.btIssue.Size = new System.Drawing.Size(120, 40);
            this.btIssue.TabIndex = 4;
            this.btIssue.Text = "Issue";
            this.btIssue.UseVisualStyleBackColor = false;
            this.btIssue.Click += new System.EventHandler(this.btIssue_Click);
            // 
            // uctrlLisenseInfo1
            // 
            this.uctrlLisenseInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlLisenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlLisenseInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlLisenseInfo1.Location = new System.Drawing.Point(13, 381);
            this.uctrlLisenseInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlLisenseInfo1.Name = "uctrlLisenseInfo1";
            this.uctrlLisenseInfo1.Size = new System.Drawing.Size(1236, 295);
            this.uctrlLisenseInfo1.TabIndex = 5;
            // 
            // uctrlApplicationInfo1
            // 
            this.uctrlApplicationInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlApplicationInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlApplicationInfo1.Location = new System.Drawing.Point(13, 193);
            this.uctrlApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlApplicationInfo1.Name = "uctrlApplicationInfo1";
            this.uctrlApplicationInfo1.Size = new System.Drawing.Size(568, 176);
            this.uctrlApplicationInfo1.TabIndex = 6;
            // 
            // lbLostReplacementScreen
            // 
            this.lbLostReplacementScreen.AutoSize = true;
            this.lbLostReplacementScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLostReplacementScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbLostReplacementScreen.Location = new System.Drawing.Point(432, 9);
            this.lbLostReplacementScreen.Name = "lbLostReplacementScreen";
            this.lbLostReplacementScreen.Size = new System.Drawing.Size(541, 51);
            this.lbLostReplacementScreen.TabIndex = 19;
            this.lbLostReplacementScreen.Text = "Lost Replacement Screen";
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
            this.btCancel.Location = new System.Drawing.Point(1024, 683);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 20;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(253, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 118;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.License_Type_32;
            this.pictureBox1.Location = new System.Drawing.Point(253, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // fmLostReplacementScreen
            // 
            this.AcceptButton = this.btIssue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1263, 723);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbLostReplacementScreen);
            this.Controls.Add(this.uctrlApplicationInfo1);
            this.Controls.Add(this.uctrlLisenseInfo1);
            this.Controls.Add(this.btIssue);
            this.Controls.Add(this.lbSelectLicenseType);
            this.Controls.Add(this.cbLicensesClasses);
            this.Controls.Add(this.mtxtbNationalNumber);
            this.Controls.Add(this.lbEnterNationalNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmLostReplacementScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost Replacement Screen";
            this.Load += new System.EventHandler(this.fmLostReplacementScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterNationalNumber;
        private System.Windows.Forms.MaskedTextBox mtxtbNationalNumber;
        private System.Windows.Forms.ComboBox cbLicensesClasses;
        private System.Windows.Forms.Label lbSelectLicenseType;
        private System.Windows.Forms.Button btIssue;
        private uctrlLisenseInfo uctrlLisenseInfo1;
        private uctrlApplicationInfo uctrlApplicationInfo1;
        private System.Windows.Forms.Label lbLostReplacementScreen;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}