namespace DLMApp_PresentationLayer
{
    partial class fmChangeApplicationFeesScreen
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
            this.lbChangeApplicationsFeesScreen = new System.Windows.Forms.Label();
            this.lbSelectApplicationType = new System.Windows.Forms.Label();
            this.cbApplicationTypes = new System.Windows.Forms.ComboBox();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbApplicationFeesResult = new System.Windows.Forms.Label();
            this.lbEnterNewFees = new System.Windows.Forms.Label();
            this.mtxtbNewFees = new System.Windows.Forms.MaskedTextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChangeApplicationsFeesScreen
            // 
            this.lbChangeApplicationsFeesScreen.AutoSize = true;
            this.lbChangeApplicationsFeesScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangeApplicationsFeesScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbChangeApplicationsFeesScreen.Location = new System.Drawing.Point(12, 9);
            this.lbChangeApplicationsFeesScreen.Name = "lbChangeApplicationsFeesScreen";
            this.lbChangeApplicationsFeesScreen.Size = new System.Drawing.Size(705, 51);
            this.lbChangeApplicationsFeesScreen.TabIndex = 17;
            this.lbChangeApplicationsFeesScreen.Text = "Change Applications Fees Screen";
            // 
            // lbSelectApplicationType
            // 
            this.lbSelectApplicationType.AutoSize = true;
            this.lbSelectApplicationType.Location = new System.Drawing.Point(7, 112);
            this.lbSelectApplicationType.Name = "lbSelectApplicationType";
            this.lbSelectApplicationType.Size = new System.Drawing.Size(219, 20);
            this.lbSelectApplicationType.TabIndex = 39;
            this.lbSelectApplicationType.Text = "Select Application Type :";
            // 
            // cbApplicationTypes
            // 
            this.cbApplicationTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApplicationTypes.FormattingEnabled = true;
            this.cbApplicationTypes.Location = new System.Drawing.Point(267, 108);
            this.cbApplicationTypes.Name = "cbApplicationTypes";
            this.cbApplicationTypes.Size = new System.Drawing.Size(412, 28);
            this.cbApplicationTypes.TabIndex = 38;
            this.cbApplicationTypes.SelectedIndexChanged += new System.EventHandler(this.cbApplicationTypes_SelectedIndexChanged);
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Location = new System.Drawing.Point(7, 176);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(161, 20);
            this.lbApplicationFees.TabIndex = 36;
            this.lbApplicationFees.Text = "Application Fees :";
            // 
            // lbApplicationFeesResult
            // 
            this.lbApplicationFeesResult.AutoSize = true;
            this.lbApplicationFeesResult.Location = new System.Drawing.Point(212, 176);
            this.lbApplicationFeesResult.Name = "lbApplicationFeesResult";
            this.lbApplicationFeesResult.Size = new System.Drawing.Size(39, 20);
            this.lbApplicationFeesResult.TabIndex = 37;
            this.lbApplicationFeesResult.Text = "???";
            // 
            // lbEnterNewFees
            // 
            this.lbEnterNewFees.AutoSize = true;
            this.lbEnterNewFees.Location = new System.Drawing.Point(7, 255);
            this.lbEnterNewFees.Name = "lbEnterNewFees";
            this.lbEnterNewFees.Size = new System.Drawing.Size(155, 20);
            this.lbEnterNewFees.TabIndex = 41;
            this.lbEnterNewFees.Text = "Enter New Fees :";
            // 
            // mtxtbNewFees
            // 
            this.mtxtbNewFees.AllowPromptAsInput = false;
            this.mtxtbNewFees.Location = new System.Drawing.Point(205, 252);
            this.mtxtbNewFees.Mask = "000000";
            this.mtxtbNewFees.Name = "mtxtbNewFees";
            this.mtxtbNewFees.PromptChar = ' ';
            this.mtxtbNewFees.Size = new System.Drawing.Size(124, 27);
            this.mtxtbNewFees.TabIndex = 0;
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
            this.btCancel.Location = new System.Drawing.Point(497, 328);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
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
            this.btSave.Location = new System.Drawing.Point(616, 328);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 40);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Application_Types_64;
            this.pictureBox4.Location = new System.Drawing.Point(229, 110);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 129;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::DLMApp_PresentationLayer.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(173, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 130;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.money_32;
            this.pictureBox1.Location = new System.Drawing.Point(168, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // fmChangeApplicationFeesScreen
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(736, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbEnterNewFees);
            this.Controls.Add(this.mtxtbNewFees);
            this.Controls.Add(this.lbSelectApplicationType);
            this.Controls.Add(this.cbApplicationTypes);
            this.Controls.Add(this.lbApplicationFees);
            this.Controls.Add(this.lbApplicationFeesResult);
            this.Controls.Add(this.lbChangeApplicationsFeesScreen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmChangeApplicationFeesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Application Fees Screen";
            this.Load += new System.EventHandler(this.fmChangeApplicationFeesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChangeApplicationsFeesScreen;
        private System.Windows.Forms.Label lbSelectApplicationType;
        private System.Windows.Forms.ComboBox cbApplicationTypes;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbApplicationFeesResult;
        private System.Windows.Forms.Label lbEnterNewFees;
        private System.Windows.Forms.MaskedTextBox mtxtbNewFees;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}