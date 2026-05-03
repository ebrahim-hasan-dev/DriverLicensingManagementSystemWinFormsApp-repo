namespace DLMApp_PresentationLayer
{
    partial class fmAdd_UpdatePersonScreen
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
            this.lbAddOrUpdatePerson = new System.Windows.Forms.Label();
            this.uctrlAddOrUpdatePerson1 = new DLMApp_PresentationLayer.uctrlAddOrUpdatePerson();
            this.SuspendLayout();
            // 
            // lbAddOrUpdatePerson
            // 
            this.lbAddOrUpdatePerson.AutoSize = true;
            this.lbAddOrUpdatePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddOrUpdatePerson.ForeColor = System.Drawing.Color.Lime;
            this.lbAddOrUpdatePerson.Location = new System.Drawing.Point(280, 9);
            this.lbAddOrUpdatePerson.Name = "lbAddOrUpdatePerson";
            this.lbAddOrUpdatePerson.Size = new System.Drawing.Size(513, 51);
            this.lbAddOrUpdatePerson.TabIndex = 61;
            this.lbAddOrUpdatePerson.Text = "Add New Person Screen";
            // 
            // uctrlAddOrUpdatePerson1
            // 
            this.uctrlAddOrUpdatePerson1.BackColor = System.Drawing.Color.Black;
            this.uctrlAddOrUpdatePerson1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlAddOrUpdatePerson1.ForeColor = System.Drawing.Color.White;
            this.uctrlAddOrUpdatePerson1.Location = new System.Drawing.Point(10, 100);
            this.uctrlAddOrUpdatePerson1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlAddOrUpdatePerson1.Name = "uctrlAddOrUpdatePerson1";
            this.uctrlAddOrUpdatePerson1.PersonID = 0;
            this.uctrlAddOrUpdatePerson1.Size = new System.Drawing.Size(1046, 544);
            this.uctrlAddOrUpdatePerson1.TabIndex = 62;
            this.uctrlAddOrUpdatePerson1.AddedEventHandler += new System.Action<DLMApp_ModulesLayer.clsPerson>(this.uctrlAddOrUpdatePerson1_AddedEventHandler);
            // 
            // fmAdd_UpdatePersonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1066, 651);
            this.Controls.Add(this.uctrlAddOrUpdatePerson1);
            this.Controls.Add(this.lbAddOrUpdatePerson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmAdd_UpdatePersonScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Or Update Person Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UctrlAddOrUpdatePerson1_AddedEventHandler(DLMApp_ModulesLayer.clsPerson obj)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lbAddOrUpdatePerson;
        private uctrlAddOrUpdatePerson uctrlAddOrUpdatePerson1;
    }
}