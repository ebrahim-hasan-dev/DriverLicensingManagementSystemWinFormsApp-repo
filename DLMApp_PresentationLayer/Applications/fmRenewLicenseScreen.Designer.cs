namespace DLMApp_PresentationLayer
{
    partial class fmRenewLicenseScreen
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
            this.lbEnterLicenseID = new System.Windows.Forms.Label();
            this.mtxtbLicenseID = new System.Windows.Forms.MaskedTextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.lbRenewLicenseScreen = new System.Windows.Forms.Label();
            this.uctrlLisenseInfo1 = new DLMApp_PresentationLayer.uctrlLisenseInfo();
            this.uctrlApplicationInfo1 = new DLMApp_PresentationLayer.uctrlApplicationInfo();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEnterLicenseID
            // 
            this.lbEnterLicenseID.AutoSize = true;
            this.lbEnterLicenseID.Location = new System.Drawing.Point(17, 123);
            this.lbEnterLicenseID.Name = "lbEnterLicenseID";
            this.lbEnterLicenseID.Size = new System.Drawing.Size(163, 20);
            this.lbEnterLicenseID.TabIndex = 1;
            this.lbEnterLicenseID.Text = "Enter License ID :";
            // 
            // mtxtbLicenseID
            // 
            this.mtxtbLicenseID.AllowPromptAsInput = false;
            this.mtxtbLicenseID.Location = new System.Drawing.Point(224, 120);
            this.mtxtbLicenseID.Mask = "000000000";
            this.mtxtbLicenseID.Name = "mtxtbLicenseID";
            this.mtxtbLicenseID.PromptChar = ' ';
            this.mtxtbLicenseID.Size = new System.Drawing.Size(109, 27);
            this.mtxtbLicenseID.TabIndex = 0;
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
            this.btSave.Location = new System.Drawing.Point(1139, 682);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 40);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
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
            this.btCancel.Location = new System.Drawing.Point(1017, 682);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.Silver;
            this.btFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFind.ForeColor = System.Drawing.Color.Black;
            this.btFind.Image = global::DLMApp_PresentationLayer.Properties.Resources.License_View_32;
            this.btFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFind.Location = new System.Drawing.Point(340, 113);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(120, 40);
            this.btFind.TabIndex = 5;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // lbRenewLicenseScreen
            // 
            this.lbRenewLicenseScreen.AutoSize = true;
            this.lbRenewLicenseScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewLicenseScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbRenewLicenseScreen.Location = new System.Drawing.Point(323, 9);
            this.lbRenewLicenseScreen.Name = "lbRenewLicenseScreen";
            this.lbRenewLicenseScreen.Size = new System.Drawing.Size(485, 51);
            this.lbRenewLicenseScreen.TabIndex = 22;
            this.lbRenewLicenseScreen.Text = "Renew License Screen";
            // 
            // uctrlLisenseInfo1
            // 
            this.uctrlLisenseInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlLisenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlLisenseInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlLisenseInfo1.Location = new System.Drawing.Point(11, 378);
            this.uctrlLisenseInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlLisenseInfo1.Name = "uctrlLisenseInfo1";
            this.uctrlLisenseInfo1.Size = new System.Drawing.Size(1236, 294);
            this.uctrlLisenseInfo1.TabIndex = 6;
            // 
            // uctrlApplicationInfo1
            // 
            this.uctrlApplicationInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlApplicationInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlApplicationInfo1.Location = new System.Drawing.Point(11, 169);
            this.uctrlApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlApplicationInfo1.Name = "uctrlApplicationInfo1";
            this.uctrlApplicationInfo1.Size = new System.Drawing.Size(568, 176);
            this.uctrlApplicationInfo1.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(187, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 129;
            this.pictureBox4.TabStop = false;
            // 
            // fmRenewLicenseScreen
            // 
            this.AcceptButton = this.btFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1260, 722);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbRenewLicenseScreen);
            this.Controls.Add(this.uctrlLisenseInfo1);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.uctrlApplicationInfo1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.mtxtbLicenseID);
            this.Controls.Add(this.lbEnterLicenseID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmRenewLicenseScreen";
            this.Text = "Renew License Screen";
            this.Load += new System.EventHandler(this.fmRenewLicenseScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterLicenseID;
        private System.Windows.Forms.MaskedTextBox mtxtbLicenseID;
        private System.Windows.Forms.Button btSave;
        private uctrlApplicationInfo uctrlApplicationInfo1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btFind;
        private uctrlLisenseInfo uctrlLisenseInfo1;
        private System.Windows.Forms.Label lbRenewLicenseScreen;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}