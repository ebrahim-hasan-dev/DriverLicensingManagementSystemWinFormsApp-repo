namespace DLMApp_PresentationLayer
{
    partial class fmChangePasswordScreen
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
            this.lbChangePasswordScreen = new System.Windows.Forms.Label();
            this.lbEnterCurrentPassword = new System.Windows.Forms.Label();
            this.lbEnterNewPassword = new System.Windows.Forms.Label();
            this.lbConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtbCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtbNewPassword = new System.Windows.Forms.TextBox();
            this.txtbConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.uctrlPersonInfo1 = new DLMApp_PresentationLayer.uctrlPersonInfo();
            this.lbIsActiveResult = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbUsernameResult = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChangePasswordScreen
            // 
            this.lbChangePasswordScreen.AutoSize = true;
            this.lbChangePasswordScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangePasswordScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbChangePasswordScreen.Location = new System.Drawing.Point(365, 9);
            this.lbChangePasswordScreen.Name = "lbChangePasswordScreen";
            this.lbChangePasswordScreen.Size = new System.Drawing.Size(544, 51);
            this.lbChangePasswordScreen.TabIndex = 34;
            this.lbChangePasswordScreen.Text = "Change Password Screen";
            // 
            // lbEnterCurrentPassword
            // 
            this.lbEnterCurrentPassword.AutoSize = true;
            this.lbEnterCurrentPassword.Location = new System.Drawing.Point(20, 412);
            this.lbEnterCurrentPassword.Name = "lbEnterCurrentPassword";
            this.lbEnterCurrentPassword.Size = new System.Drawing.Size(223, 20);
            this.lbEnterCurrentPassword.TabIndex = 35;
            this.lbEnterCurrentPassword.Text = "Enter Current Password :";
            // 
            // lbEnterNewPassword
            // 
            this.lbEnterNewPassword.AutoSize = true;
            this.lbEnterNewPassword.Location = new System.Drawing.Point(20, 453);
            this.lbEnterNewPassword.Name = "lbEnterNewPassword";
            this.lbEnterNewPassword.Size = new System.Drawing.Size(196, 20);
            this.lbEnterNewPassword.TabIndex = 36;
            this.lbEnterNewPassword.Text = "Enter New Password :";
            // 
            // lbConfirmNewPassword
            // 
            this.lbConfirmNewPassword.AutoSize = true;
            this.lbConfirmNewPassword.Location = new System.Drawing.Point(20, 494);
            this.lbConfirmNewPassword.Name = "lbConfirmNewPassword";
            this.lbConfirmNewPassword.Size = new System.Drawing.Size(217, 20);
            this.lbConfirmNewPassword.TabIndex = 37;
            this.lbConfirmNewPassword.Text = "Confirm New Password :";
            // 
            // txtbCurrentPassword
            // 
            this.txtbCurrentPassword.Location = new System.Drawing.Point(284, 409);
            this.txtbCurrentPassword.Name = "txtbCurrentPassword";
            this.txtbCurrentPassword.Size = new System.Drawing.Size(253, 27);
            this.txtbCurrentPassword.TabIndex = 0;
            this.txtbCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtbNewPassword
            // 
            this.txtbNewPassword.Location = new System.Drawing.Point(284, 450);
            this.txtbNewPassword.Name = "txtbNewPassword";
            this.txtbNewPassword.Size = new System.Drawing.Size(253, 27);
            this.txtbNewPassword.TabIndex = 1;
            this.txtbNewPassword.UseSystemPasswordChar = true;
            // 
            // txtbConfirmNewPassword
            // 
            this.txtbConfirmNewPassword.Location = new System.Drawing.Point(284, 491);
            this.txtbConfirmNewPassword.Name = "txtbConfirmNewPassword";
            this.txtbConfirmNewPassword.Size = new System.Drawing.Size(253, 27);
            this.txtbConfirmNewPassword.TabIndex = 2;
            this.txtbConfirmNewPassword.UseSystemPasswordChar = true;
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
            this.btSave.Location = new System.Drawing.Point(1048, 491);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 40);
            this.btSave.TabIndex = 4;
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
            this.btCancel.Location = new System.Drawing.Point(927, 491);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // uctrlPersonInfo1
            // 
            this.uctrlPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.uctrlPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlPersonInfo1.ForeColor = System.Drawing.Color.White;
            this.uctrlPersonInfo1.Location = new System.Drawing.Point(11, 105);
            this.uctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlPersonInfo1.Name = "uctrlPersonInfo1";
            this.uctrlPersonInfo1.Size = new System.Drawing.Size(1150, 225);
            this.uctrlPersonInfo1.TabIndex = 38;
            // 
            // lbIsActiveResult
            // 
            this.lbIsActiveResult.AutoSize = true;
            this.lbIsActiveResult.Location = new System.Drawing.Point(644, 356);
            this.lbIsActiveResult.Name = "lbIsActiveResult";
            this.lbIsActiveResult.Size = new System.Drawing.Size(39, 20);
            this.lbIsActiveResult.TabIndex = 59;
            this.lbIsActiveResult.Text = "???";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Location = new System.Drawing.Point(515, 356);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(94, 20);
            this.lbIsActive.TabIndex = 58;
            this.lbIsActive.Text = "Is Active :";
            // 
            // lbUsernameResult
            // 
            this.lbUsernameResult.AutoSize = true;
            this.lbUsernameResult.Location = new System.Drawing.Point(159, 356);
            this.lbUsernameResult.Name = "lbUsernameResult";
            this.lbUsernameResult.Size = new System.Drawing.Size(39, 20);
            this.lbUsernameResult.TabIndex = 57;
            this.lbUsernameResult.Text = "???";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(20, 356);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(112, 20);
            this.lbUsername.TabIndex = 56;
            this.lbUsername.Text = "Username : ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::DLMApp_PresentationLayer.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(248, 448);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 119;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::DLMApp_PresentationLayer.Properties.Resources.Password_32;
            this.pictureBox2.Location = new System.Drawing.Point(248, 494);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 118;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Password_32;
            this.pictureBox1.Location = new System.Drawing.Point(249, 411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::DLMApp_PresentationLayer.Properties.Resources.Person_32;
            this.pictureBox4.Location = new System.Drawing.Point(127, 354);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 121;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Image = global::DLMApp_PresentationLayer.Properties.Resources.edit_32;
            this.pictureBox5.Location = new System.Drawing.Point(610, 354);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 122;
            this.pictureBox5.TabStop = false;
            // 
            // fmChangePasswordScreen
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1170, 534);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbIsActiveResult);
            this.Controls.Add(this.lbIsActive);
            this.Controls.Add(this.lbUsernameResult);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.uctrlPersonInfo1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtbConfirmNewPassword);
            this.Controls.Add(this.txtbNewPassword);
            this.Controls.Add(this.txtbCurrentPassword);
            this.Controls.Add(this.lbConfirmNewPassword);
            this.Controls.Add(this.lbEnterNewPassword);
            this.Controls.Add(this.lbEnterCurrentPassword);
            this.Controls.Add(this.lbChangePasswordScreen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmChangePasswordScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password Screen";
            this.Load += new System.EventHandler(this.fmUdateUserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChangePasswordScreen;
        private System.Windows.Forms.Label lbEnterCurrentPassword;
        private System.Windows.Forms.Label lbEnterNewPassword;
        private System.Windows.Forms.Label lbConfirmNewPassword;
        private System.Windows.Forms.TextBox txtbCurrentPassword;
        private System.Windows.Forms.TextBox txtbNewPassword;
        private System.Windows.Forms.TextBox txtbConfirmNewPassword;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private uctrlPersonInfo uctrlPersonInfo1;
        private System.Windows.Forms.Label lbIsActiveResult;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbUsernameResult;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}