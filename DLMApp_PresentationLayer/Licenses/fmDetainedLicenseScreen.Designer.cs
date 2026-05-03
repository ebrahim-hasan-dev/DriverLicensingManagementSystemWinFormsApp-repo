namespace DLMApp_PresentationLayer
{
    partial class fmDetainedLicenseScreen
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
            this.mtxtbFine = new System.Windows.Forms.MaskedTextBox();
            this.lbEnterFine = new System.Windows.Forms.Label();
            this.lbEnterReason = new System.Windows.Forms.Label();
            this.mtxtbLicenseID = new System.Windows.Forms.MaskedTextBox();
            this.lbEnterDetainedDate = new System.Windows.Forms.Label();
            this.lbEnterLicenseID = new System.Windows.Forms.Label();
            this.dtpDetainedDate = new System.Windows.Forms.DateTimePicker();
            this.txtbReason = new System.Windows.Forms.TextBox();
            this.btDetained = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbDetainedLicenseScreen = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtbFine
            // 
            this.mtxtbFine.AllowPromptAsInput = false;
            this.mtxtbFine.Location = new System.Drawing.Point(255, 184);
            this.mtxtbFine.Mask = "000000000";
            this.mtxtbFine.Name = "mtxtbFine";
            this.mtxtbFine.PromptChar = ' ';
            this.mtxtbFine.Size = new System.Drawing.Size(223, 27);
            this.mtxtbFine.TabIndex = 1;
            // 
            // lbEnterFine
            // 
            this.lbEnterFine.AutoSize = true;
            this.lbEnterFine.Location = new System.Drawing.Point(12, 187);
            this.lbEnterFine.Name = "lbEnterFine";
            this.lbEnterFine.Size = new System.Drawing.Size(108, 20);
            this.lbEnterFine.TabIndex = 6;
            this.lbEnterFine.Text = "Enter Fine :";
            // 
            // lbEnterReason
            // 
            this.lbEnterReason.AutoSize = true;
            this.lbEnterReason.Location = new System.Drawing.Point(12, 322);
            this.lbEnterReason.Name = "lbEnterReason";
            this.lbEnterReason.Size = new System.Drawing.Size(135, 20);
            this.lbEnterReason.TabIndex = 9;
            this.lbEnterReason.Text = "Enter Reason :";
            // 
            // mtxtbLicenseID
            // 
            this.mtxtbLicenseID.AllowPromptAsInput = false;
            this.mtxtbLicenseID.Location = new System.Drawing.Point(255, 125);
            this.mtxtbLicenseID.Mask = "000000000";
            this.mtxtbLicenseID.Name = "mtxtbLicenseID";
            this.mtxtbLicenseID.PromptChar = ' ';
            this.mtxtbLicenseID.Size = new System.Drawing.Size(223, 27);
            this.mtxtbLicenseID.TabIndex = 0;
            // 
            // lbEnterDetainedDate
            // 
            this.lbEnterDetainedDate.AutoSize = true;
            this.lbEnterDetainedDate.Location = new System.Drawing.Point(12, 246);
            this.lbEnterDetainedDate.Name = "lbEnterDetainedDate";
            this.lbEnterDetainedDate.Size = new System.Drawing.Size(199, 20);
            this.lbEnterDetainedDate.TabIndex = 7;
            this.lbEnterDetainedDate.Text = "Enter Detained Date : ";
            // 
            // lbEnterLicenseID
            // 
            this.lbEnterLicenseID.AutoSize = true;
            this.lbEnterLicenseID.Location = new System.Drawing.Point(12, 128);
            this.lbEnterLicenseID.Name = "lbEnterLicenseID";
            this.lbEnterLicenseID.Size = new System.Drawing.Size(163, 20);
            this.lbEnterLicenseID.TabIndex = 8;
            this.lbEnterLicenseID.Text = "Enter License ID :";
            // 
            // dtpDetainedDate
            // 
            this.dtpDetainedDate.CustomFormat = "d-M-yyyy";
            this.dtpDetainedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDetainedDate.Location = new System.Drawing.Point(255, 243);
            this.dtpDetainedDate.MaxDate = new System.DateTime(2026, 1, 25, 0, 0, 0, 0);
            this.dtpDetainedDate.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtpDetainedDate.Name = "dtpDetainedDate";
            this.dtpDetainedDate.Size = new System.Drawing.Size(223, 27);
            this.dtpDetainedDate.TabIndex = 2;
            this.dtpDetainedDate.Value = new System.DateTime(2026, 1, 25, 0, 0, 0, 0);
            // 
            // txtbReason
            // 
            this.txtbReason.Location = new System.Drawing.Point(255, 302);
            this.txtbReason.Multiline = true;
            this.txtbReason.Name = "txtbReason";
            this.txtbReason.Size = new System.Drawing.Size(223, 61);
            this.txtbReason.TabIndex = 3;
            // 
            // btDetained
            // 
            this.btDetained.BackColor = System.Drawing.Color.Silver;
            this.btDetained.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btDetained.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btDetained.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDetained.ForeColor = System.Drawing.Color.Black;
            this.btDetained.Image = global::DLMApp_PresentationLayer.Properties.Resources.Detain_32;
            this.btDetained.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDetained.Location = new System.Drawing.Point(669, 437);
            this.btDetained.Name = "btDetained";
            this.btDetained.Size = new System.Drawing.Size(120, 40);
            this.btDetained.TabIndex = 4;
            this.btDetained.Text = "Detained";
            this.btDetained.UseVisualStyleBackColor = false;
            this.btDetained.Click += new System.EventHandler(this.btDetained_Click);
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
            this.btCancel.Location = new System.Drawing.Point(549, 437);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbDetainedLicenseScreen
            // 
            this.lbDetainedLicenseScreen.AutoSize = true;
            this.lbDetainedLicenseScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedLicenseScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbDetainedLicenseScreen.Location = new System.Drawing.Point(123, 9);
            this.lbDetainedLicenseScreen.Name = "lbDetainedLicenseScreen";
            this.lbDetainedLicenseScreen.Size = new System.Drawing.Size(527, 51);
            this.lbDetainedLicenseScreen.TabIndex = 17;
            this.lbDetainedLicenseScreen.Text = "Detained License Screen";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(219, 126);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 129;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.Image = global::DLMApp_PresentationLayer.Properties.Resources.money_32;
            this.pictureBox9.Location = new System.Drawing.Point(219, 185);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 133;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Image = global::DLMApp_PresentationLayer.Properties.Resources.Calendar_32;
            this.pictureBox5.Location = new System.Drawing.Point(219, 244);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 134;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.List_32;
            this.pictureBox1.Location = new System.Drawing.Point(219, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // fmDetainedLicenseScreen
            // 
            this.AcceptButton = this.btDetained;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(790, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbDetainedLicenseScreen);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDetained);
            this.Controls.Add(this.txtbReason);
            this.Controls.Add(this.dtpDetainedDate);
            this.Controls.Add(this.lbEnterLicenseID);
            this.Controls.Add(this.lbEnterDetainedDate);
            this.Controls.Add(this.lbEnterReason);
            this.Controls.Add(this.mtxtbLicenseID);
            this.Controls.Add(this.lbEnterFine);
            this.Controls.Add(this.mtxtbFine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmDetainedLicenseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detained License Screen";
            this.Load += new System.EventHandler(this.fmDetainedLicenseScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtbFine;
        private System.Windows.Forms.Label lbEnterFine;
        private System.Windows.Forms.Label lbEnterReason;
        private System.Windows.Forms.MaskedTextBox mtxtbLicenseID;
        private System.Windows.Forms.Label lbEnterDetainedDate;
        private System.Windows.Forms.Label lbEnterLicenseID;
        private System.Windows.Forms.DateTimePicker dtpDetainedDate;
        private System.Windows.Forms.TextBox txtbReason;
        private System.Windows.Forms.Button btDetained;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbDetainedLicenseScreen;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}