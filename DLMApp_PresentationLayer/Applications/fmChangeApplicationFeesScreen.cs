using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLMApp_PresentationLayer
{
    public partial class fmChangeApplicationFeesScreen : Form
    {
        // =============================================

        List<clsApplicationType> _ListOfApplicationTypes = null;

        byte _ApplicationTypeID = 0;
        float _ApplicationTypeFees = 0;

        // =============================================


        public fmChangeApplicationFeesScreen()
        {
            InitializeComponent();
        }


        void LoadAllApplicationTypes()
        {
            _ListOfApplicationTypes = ApplicationService.GetAllApplicationTypes();

            for (byte i = 0; i < _ListOfApplicationTypes.Count; i++)
            {
                cbApplicationTypes.Items.Add(_ListOfApplicationTypes[i].ApplicationTypeName);
            }

            cbApplicationTypes.SelectedIndex = 0;
        }

        private void fmChangeApplicationFeesScreen_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbChangeApplicationsFeesScreen);

            LoadAllApplicationTypes();
        }

        void SetApplicationTypeInfo(clsApplicationType ApplicationType)
        {
            _ApplicationTypeID = ApplicationType.ApplicationTypeID;
            _ApplicationTypeFees = ApplicationType.ApplicationTypeFees;

            lbApplicationFeesResult.Text = ApplicationType.ApplicationTypeFees.ToString();
        }

        private void cbApplicationTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetApplicationTypeInfo(_ListOfApplicationTypes.Find(x => x.ApplicationTypeName == cbApplicationTypes.Text));
            mtxtbNewFees.Focus();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtbNewFees.Text))
            {
                MessageBox.Show("box is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtbNewFees.Focus();
            }
            else
            {
                _ApplicationTypeFees = float.Parse(mtxtbNewFees.Text);

                if (ApplicationService.UpdateApplicationTypeFees(_ApplicationTypeID, _ApplicationTypeFees))
                {
                    UpdateUI();
                    MessageBox.Show("Operation completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Reset();
            }
        }

        void Reset()
        {
            mtxtbNewFees.Clear();
            mtxtbNewFees.Focus();
        }

        void UpdateUI()
        {
            lbApplicationFeesResult.Text = _ApplicationTypeFees.ToString();

            _ListOfApplicationTypes.Find(x => x.ApplicationTypeID == _ApplicationTypeID).ApplicationTypeFees = _ApplicationTypeFees;
        }







    }
}
