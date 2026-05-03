namespace DLMApp_PresentationLayer
{
    partial class fmAddNewUserScreen
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
            this.components = new System.ComponentModel.Container();
            this.lbAddNewUserScreen = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.txtbConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUserName = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.lbEnterPassword = new System.Windows.Forms.Label();
            this.lbEnterUserName = new System.Windows.Forms.Label();
            this.uctrlAddOrUpdatePerson1 = new DLMApp_PresentationLayer.uctrlAddOrUpdatePerson();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddNewUserScreen
            // 
            this.lbAddNewUserScreen.AutoSize = true;
            this.lbAddNewUserScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddNewUserScreen.ForeColor = System.Drawing.Color.Lime;
            this.lbAddNewUserScreen.Location = new System.Drawing.Point(279, 7);
            this.lbAddNewUserScreen.Name = "lbAddNewUserScreen";
            this.lbAddNewUserScreen.Size = new System.Drawing.Size(465, 51);
            this.lbAddNewUserScreen.TabIndex = 34;
            this.lbAddNewUserScreen.Text = "Add New User Screen";
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
            this.btCancel.Location = new System.Drawing.Point(821, 734);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 40);
            this.btCancel.TabIndex = 43;
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
            this.btSave.Location = new System.Drawing.Point(943, 734);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 40);
            this.btSave.TabIndex = 42;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // chbActive
            // 
            this.chbActive.AutoSize = true;
            this.chbActive.Checked = true;
            this.chbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActive.Location = new System.Drawing.Point(288, 752);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(83, 24);
            this.chbActive.TabIndex = 41;
            this.chbActive.Text = "Active";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // txtbConfirmPassword
            // 
            this.txtbConfirmPassword.Location = new System.Drawing.Point(288, 706);
            this.txtbConfirmPassword.Name = "txtbConfirmPassword";
            this.txtbConfirmPassword.Size = new System.Drawing.Size(253, 27);
            this.txtbConfirmPassword.TabIndex = 40;
            this.txtbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(288, 660);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(253, 27);
            this.txtbPassword.TabIndex = 39;
            this.txtbPassword.UseSystemPasswordChar = true;
            // 
            // txtbUserName
            // 
            this.txtbUserName.Location = new System.Drawing.Point(288, 614);
            this.txtbUserName.Name = "txtbUserName";
            this.txtbUserName.Size = new System.Drawing.Size(253, 27);
            this.txtbUserName.TabIndex = 38;
            this.txtbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtbUserName_Validating);
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Location = new System.Drawing.Point(12, 709);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(175, 20);
            this.lbConfirmPassword.TabIndex = 46;
            this.lbConfirmPassword.Text = "Confirm Password :";
            // 
            // lbEnterPassword
            // 
            this.lbEnterPassword.AutoSize = true;
            this.lbEnterPassword.Location = new System.Drawing.Point(12, 663);
            this.lbEnterPassword.Name = "lbEnterPassword";
            this.lbEnterPassword.Size = new System.Drawing.Size(154, 20);
            this.lbEnterPassword.TabIndex = 45;
            this.lbEnterPassword.Text = "Enter Password :";
            // 
            // lbEnterUserName
            // 
            this.lbEnterUserName.AutoSize = true;
            this.lbEnterUserName.Location = new System.Drawing.Point(12, 617);
            this.lbEnterUserName.Name = "lbEnterUserName";
            this.lbEnterUserName.Size = new System.Drawing.Size(166, 20);
            this.lbEnterUserName.TabIndex = 44;
            this.lbEnterUserName.Text = "Enter User Name :";
            // 
            // uctrlAddOrUpdatePerson1
            // 
            this.uctrlAddOrUpdatePerson1.BackColor = System.Drawing.Color.Black;
            this.uctrlAddOrUpdatePerson1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlAddOrUpdatePerson1.ForeColor = System.Drawing.Color.White;
            this.uctrlAddOrUpdatePerson1.Location = new System.Drawing.Point(9, 60);
            this.uctrlAddOrUpdatePerson1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlAddOrUpdatePerson1.Name = "uctrlAddOrUpdatePerson1";
            this.uctrlAddOrUpdatePerson1.PersonID = 0;
            this.uctrlAddOrUpdatePerson1.Size = new System.Drawing.Size(1046, 544);
            this.uctrlAddOrUpdatePerson1.TabIndex = 35;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DLMApp_PresentationLayer.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(252, 615);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::DLMApp_PresentationLayer.Properties.Resources.Password_32;
            this.pictureBox2.Location = new System.Drawing.Point(252, 707);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 115;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::DLMApp_PresentationLayer.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(252, 661);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 116;
            this.pictureBox3.TabStop = false;
            // 
            // fmAddNewUserScreen
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1065, 778);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.chbActive);
            this.Controls.Add(this.txtbConfirmPassword);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUserName);
            this.Controls.Add(this.lbConfirmPassword);
            this.Controls.Add(this.lbEnterPassword);
            this.Controls.Add(this.lbEnterUserName);
            this.Controls.Add(this.uctrlAddOrUpdatePerson1);
            this.Controls.Add(this.lbAddNewUserScreen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmAddNewUserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User Screen";
            this.Load += new System.EventHandler(this.fmAddNewUserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddNewUserScreen;
        private uctrlAddOrUpdatePerson uctrlAddOrUpdatePerson1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.TextBox txtbConfirmPassword;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbUserName;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Label lbEnterPassword;
        private System.Windows.Forms.Label lbEnterUserName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}