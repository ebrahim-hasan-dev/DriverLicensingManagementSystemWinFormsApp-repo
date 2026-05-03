namespace DLMApp_PresentationLayer
{
    partial class fmShowUserInfoScreen
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
            this.uctrlPersonInfo1 = new DLMApp_PresentationLayer.uctrlPersonInfo();
            this.lbUserInfoScreen = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbUsernameResult = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbIsActiveResult = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // uctrlPersonInfo1
            // 
            this.uctrlPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlPersonInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlPersonInfo1.Location = new System.Drawing.Point(9, 87);
            this.uctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlPersonInfo1.Name = "uctrlPersonInfo1";
            this.uctrlPersonInfo1.Size = new System.Drawing.Size(1150, 225);
            this.uctrlPersonInfo1.TabIndex = 50;
            // 
            // lbUserInfoScreen
            // 
            this.lbUserInfoScreen.AutoSize = true;
            this.lbUserInfoScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserInfoScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbUserInfoScreen.Location = new System.Drawing.Point(421, 9);
            this.lbUserInfoScreen.Name = "lbUserInfoScreen";
            this.lbUserInfoScreen.Size = new System.Drawing.Size(360, 51);
            this.lbUserInfoScreen.TabIndex = 51;
            this.lbUserInfoScreen.Text = "User Info Screen";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(20, 344);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(112, 20);
            this.lbUsername.TabIndex = 52;
            this.lbUsername.Text = "Username : ";
            // 
            // lbUsernameResult
            // 
            this.lbUsernameResult.AutoSize = true;
            this.lbUsernameResult.Location = new System.Drawing.Point(188, 344);
            this.lbUsernameResult.Name = "lbUsernameResult";
            this.lbUsernameResult.Size = new System.Drawing.Size(39, 20);
            this.lbUsernameResult.TabIndex = 53;
            this.lbUsernameResult.Text = "???";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Location = new System.Drawing.Point(513, 344);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(94, 20);
            this.lbIsActive.TabIndex = 54;
            this.lbIsActive.Text = "Is Active :";
            // 
            // lbIsActiveResult
            // 
            this.lbIsActiveResult.AutoSize = true;
            this.lbIsActiveResult.Location = new System.Drawing.Point(665, 344);
            this.lbIsActiveResult.Name = "lbIsActiveResult";
            this.lbIsActiveResult.Size = new System.Drawing.Size(39, 20);
            this.lbIsActiveResult.TabIndex = 55;
            this.lbIsActiveResult.Text = "???";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Image = global::DLMApp_PresentationLayer.Properties.Resources.edit_32;
            this.pictureBox5.Location = new System.Drawing.Point(621, 342);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 123;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Person_32;
            this.pictureBox4.Location = new System.Drawing.Point(143, 342);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 124;
            this.pictureBox4.TabStop = false;
            // 
            // fmShowUserInfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1169, 373);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbIsActiveResult);
            this.Controls.Add(this.lbIsActive);
            this.Controls.Add(this.lbUsernameResult);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbUserInfoScreen);
            this.Controls.Add(this.uctrlPersonInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmShowUserInfoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show User Info Screen";
            this.Load += new System.EventHandler(this.fmShowPersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlPersonInfo uctrlPersonInfo1;
        private System.Windows.Forms.Label lbUserInfoScreen;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbUsernameResult;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbIsActiveResult;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}