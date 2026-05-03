namespace DLMApp_PresentationLayer
{
    partial class fmFindPersonScreen
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
            this.lbFindPersonScreen = new System.Windows.Forms.Label();
            this.mtxtbNationalNumber = new System.Windows.Forms.MaskedTextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbEnterNationalNumber = new System.Windows.Forms.Label();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.txtbConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUserName = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.lbEnterPassword = new System.Windows.Forms.Label();
            this.lbEnterUserName = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.uctrlPersonInfo1 = new DLMApp_PresentationLayer.uctrlPersonInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFindPersonScreen
            // 
            this.lbFindPersonScreen.AutoSize = true;
            this.lbFindPersonScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindPersonScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbFindPersonScreen.Location = new System.Drawing.Point(386, 9);
            this.lbFindPersonScreen.Name = "lbFindPersonScreen";
            this.lbFindPersonScreen.Size = new System.Drawing.Size(420, 51);
            this.lbFindPersonScreen.TabIndex = 32;
            this.lbFindPersonScreen.Text = "Find Person Screen";
            // 
            // mtxtbNationalNumber
            // 
            this.mtxtbNationalNumber.AllowPromptAsInput = false;
            this.mtxtbNationalNumber.Location = new System.Drawing.Point(263, 118);
            this.mtxtbNationalNumber.Mask = "00000000000000";
            this.mtxtbNationalNumber.Name = "mtxtbNationalNumber";
            this.mtxtbNationalNumber.PromptChar = ' ';
            this.mtxtbNationalNumber.Size = new System.Drawing.Size(163, 27);
            this.mtxtbNationalNumber.SkipLiterals = false;
            this.mtxtbNationalNumber.TabIndex = 33;
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
            this.btSearch.Location = new System.Drawing.Point(443, 112);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(120, 40);
            this.btSearch.TabIndex = 34;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbEnterNationalNumber
            // 
            this.lbEnterNationalNumber.AutoSize = true;
            this.lbEnterNationalNumber.Location = new System.Drawing.Point(17, 121);
            this.lbEnterNationalNumber.Name = "lbEnterNationalNumber";
            this.lbEnterNationalNumber.Size = new System.Drawing.Size(212, 20);
            this.lbEnterNationalNumber.TabIndex = 35;
            this.lbEnterNationalNumber.Text = "Enter National Number :";
            // 
            // chbActive
            // 
            this.chbActive.AutoSize = true;
            this.chbActive.Checked = true;
            this.chbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActive.Location = new System.Drawing.Point(293, 579);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(83, 24);
            this.chbActive.TabIndex = 50;
            this.chbActive.Text = "Active";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // txtbConfirmPassword
            // 
            this.txtbConfirmPassword.Location = new System.Drawing.Point(293, 533);
            this.txtbConfirmPassword.Name = "txtbConfirmPassword";
            this.txtbConfirmPassword.Size = new System.Drawing.Size(253, 27);
            this.txtbConfirmPassword.TabIndex = 49;
            this.txtbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(293, 487);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(253, 27);
            this.txtbPassword.TabIndex = 48;
            this.txtbPassword.UseSystemPasswordChar = true;
            // 
            // txtbUserName
            // 
            this.txtbUserName.Location = new System.Drawing.Point(293, 441);
            this.txtbUserName.Name = "txtbUserName";
            this.txtbUserName.Size = new System.Drawing.Size(253, 27);
            this.txtbUserName.TabIndex = 47;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Location = new System.Drawing.Point(17, 536);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(175, 20);
            this.lbConfirmPassword.TabIndex = 53;
            this.lbConfirmPassword.Text = "Confirm Password :";
            // 
            // lbEnterPassword
            // 
            this.lbEnterPassword.AutoSize = true;
            this.lbEnterPassword.Location = new System.Drawing.Point(17, 490);
            this.lbEnterPassword.Name = "lbEnterPassword";
            this.lbEnterPassword.Size = new System.Drawing.Size(154, 20);
            this.lbEnterPassword.TabIndex = 52;
            this.lbEnterPassword.Text = "Enter Password :";
            // 
            // lbEnterUserName
            // 
            this.lbEnterUserName.AutoSize = true;
            this.lbEnterUserName.Location = new System.Drawing.Point(17, 444);
            this.lbEnterUserName.Name = "lbEnterUserName";
            this.lbEnterUserName.Size = new System.Drawing.Size(166, 20);
            this.lbEnterUserName.TabIndex = 51;
            this.lbEnterUserName.Text = "Enter User Name :";
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
            this.btCancel.Location = new System.Drawing.Point(923, 566);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 55;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
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
            this.btSave.Location = new System.Drawing.Point(1046, 566);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 40);
            this.btSave.TabIndex = 54;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(228, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Password_32;
            this.pictureBox1.Location = new System.Drawing.Point(257, 534);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DLMApp_PresentationLayer.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(257, 488);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Person_32;
            this.pictureBox4.Location = new System.Drawing.Point(257, 442);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 83;
            this.pictureBox4.TabStop = false;
            // 
            // uctrlPersonInfo1
            // 
            this.uctrlPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlPersonInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlPersonInfo1.Location = new System.Drawing.Point(10, 197);
            this.uctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlPersonInfo1.Name = "uctrlPersonInfo1";
            this.uctrlPersonInfo1.Size = new System.Drawing.Size(1150, 225);
            this.uctrlPersonInfo1.TabIndex = 0;
            // 
            // fmFindPersonScreen
            // 
            this.AcceptButton = this.btSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1170, 609);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.chbActive);
            this.Controls.Add(this.txtbConfirmPassword);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUserName);
            this.Controls.Add(this.lbConfirmPassword);
            this.Controls.Add(this.lbEnterPassword);
            this.Controls.Add(this.lbEnterUserName);
            this.Controls.Add(this.mtxtbNationalNumber);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lbEnterNationalNumber);
            this.Controls.Add(this.lbFindPersonScreen);
            this.Controls.Add(this.uctrlPersonInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmFindPersonScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Person Screen";
            this.Load += new System.EventHandler(this.fmFindPersonScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlPersonInfo uctrlPersonInfo1;
        private System.Windows.Forms.Label lbFindPersonScreen;
        private System.Windows.Forms.MaskedTextBox mtxtbNationalNumber;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbEnterNationalNumber;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.TextBox txtbConfirmPassword;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbUserName;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Label lbEnterPassword;
        private System.Windows.Forms.Label lbEnterUserName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}