namespace DLMApp_PresentationLayer
{
    partial class fmRetakeTestScreen
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
            this.mtxtbOriginalApplicationID = new System.Windows.Forms.MaskedTextBox();
            this.lbEnterOriginalApplicationID = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btContinue = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.uctrlApplicationInfo1 = new DLMApp_PresentationLayer.uctrlApplicationInfo();
            this.lbRetakeTestScreen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtbOriginalApplicationID
            // 
            this.mtxtbOriginalApplicationID.AllowPromptAsInput = false;
            this.mtxtbOriginalApplicationID.Location = new System.Drawing.Point(312, 97);
            this.mtxtbOriginalApplicationID.Mask = "000000000";
            this.mtxtbOriginalApplicationID.Name = "mtxtbOriginalApplicationID";
            this.mtxtbOriginalApplicationID.PromptChar = ' ';
            this.mtxtbOriginalApplicationID.Size = new System.Drawing.Size(221, 27);
            this.mtxtbOriginalApplicationID.SkipLiterals = false;
            this.mtxtbOriginalApplicationID.TabIndex = 0;
            // 
            // lbEnterOriginalApplicationID
            // 
            this.lbEnterOriginalApplicationID.AutoSize = true;
            this.lbEnterOriginalApplicationID.Location = new System.Drawing.Point(17, 100);
            this.lbEnterOriginalApplicationID.Name = "lbEnterOriginalApplicationID";
            this.lbEnterOriginalApplicationID.Size = new System.Drawing.Size(262, 20);
            this.lbEnterOriginalApplicationID.TabIndex = 10;
            this.lbEnterOriginalApplicationID.Text = "Enter Original Application ID :";
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
            this.btSave.Location = new System.Drawing.Point(584, 410);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 40);
            this.btSave.TabIndex = 28;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btContinue
            // 
            this.btContinue.BackColor = System.Drawing.Color.Silver;
            this.btContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContinue.ForeColor = System.Drawing.Color.Black;
            this.btContinue.Image = global::DLMApp_PresentationLayer.Properties.Resources.Next_32;
            this.btContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btContinue.Location = new System.Drawing.Point(463, 410);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(120, 40);
            this.btContinue.TabIndex = 29;
            this.btContinue.Text = "Continue";
            this.btContinue.UseVisualStyleBackColor = false;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
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
            this.btCancel.Location = new System.Drawing.Point(342, 410);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 30;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // uctrlApplicationInfo1
            // 
            this.uctrlApplicationInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlApplicationInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlApplicationInfo1.Location = new System.Drawing.Point(11, 168);
            this.uctrlApplicationInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlApplicationInfo1.Name = "uctrlApplicationInfo1";
            this.uctrlApplicationInfo1.Size = new System.Drawing.Size(568, 176);
            this.uctrlApplicationInfo1.TabIndex = 2;
            // 
            // lbRetakeTestScreen
            // 
            this.lbRetakeTestScreen.AutoSize = true;
            this.lbRetakeTestScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetakeTestScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbRetakeTestScreen.Location = new System.Drawing.Point(94, 9);
            this.lbRetakeTestScreen.Name = "lbRetakeTestScreen";
            this.lbRetakeTestScreen.Size = new System.Drawing.Size(420, 51);
            this.lbRetakeTestScreen.TabIndex = 31;
            this.lbRetakeTestScreen.Text = "Retake Test Screen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(278, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // fmRetakeTestScreen
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbRetakeTestScreen);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btContinue);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.mtxtbOriginalApplicationID);
            this.Controls.Add(this.lbEnterOriginalApplicationID);
            this.Controls.Add(this.uctrlApplicationInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmRetakeTestScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retake Test Screen";
            this.Load += new System.EventHandler(this.fmRetakeTestScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlApplicationInfo uctrlApplicationInfo1;
        private System.Windows.Forms.MaskedTextBox mtxtbOriginalApplicationID;
        private System.Windows.Forms.Label lbEnterOriginalApplicationID;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbRetakeTestScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}