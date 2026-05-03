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
using static System.Net.Mime.MediaTypeNames;

namespace DLMApp_PresentationLayer
{
    public partial class fmRetakeTestScreen : Form
    {
        // ==========================================================

        float _ApplicationFees = 0;
        int _OriginalApplicationID = 0;
        int _RetakeTestApplicationID = 0;
        clsPerson _Person = null;

        // ==========================================================


        public fmRetakeTestScreen()
        {
            InitializeComponent();
        }

        private void fmRetakeTestScreen_Load(object sender, EventArgs e)
        {
            clsApplicationType ApplicationType = ApplicationService.GetApplicationType(enApplicationTypes.RetakeTest);
            uctrlApplicationInfo1.SetApplicationInfo(ApplicationType);
            _ApplicationFees = ApplicationType.ApplicationTypeFees;

            clsGlobal.MakeTitleInCenterScreen(this.Width, lbRetakeTestScreen);
        }
        
        private void btSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtxtbOriginalApplicationID.Text))
            {
                _OriginalApplicationID = int.Parse(mtxtbOriginalApplicationID.Text);

                _Person = PersonService.FindByApplicationID(_OriginalApplicationID);

                if (_Person != null)
                {
                    clsApplication Application = clsGlobal.FillAndGetApplication(_Person.PersonID, enApplicationStatus.New,
                        enApplicationTypes.RetakeTest, _ApplicationFees);

                    if (ApplicationService.AddNewApplication(Application))
                    {
                        _RetakeTestApplicationID = Application.ApplicationID;

                        uctrlApplicationInfo1.lbApplicationIDResult.Text = _RetakeTestApplicationID.ToString();
                        MessageBox.Show($"The Save operation successfully with Application ID ({_RetakeTestApplicationID})", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        btContinue.Enabled = true;
                        this.AcceptButton = btContinue;
                    }
                    else
                    {
                        MessageBox.Show("The Save operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"There is no Application ID like this {mtxtbOriginalApplicationID.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Original Application ID is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            fmTestsScreen testsScreen = new fmTestsScreen(_RetakeTestApplicationID, _OriginalApplicationID, _Person, true);
            testsScreen.ShowDialog();
        }



        


    }

}
