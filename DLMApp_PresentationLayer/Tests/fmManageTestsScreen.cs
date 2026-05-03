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
    public partial class fmManageTestsScreen : Form
    {
        // =============================================

        List<clsTest> _ListOfTests = null;

        byte _TestID = 0;
        float _TestFees = 0;
        short _MaxNumberOfPeople = 0;

        // =============================================
        public fmManageTestsScreen()
        {
            InitializeComponent();
        }


        void LoadAllTests()
        {
            _ListOfTests = TestService.GetAllTests();

            for (byte i = 0; i < _ListOfTests.Count; i++)
            {
                cbTests.Items.Add(_ListOfTests[i].Test);
            }

            cbTests.SelectedIndex = 0;
        }

        void SetTestInfo(clsTest test)
        {
            _TestID = test.ID;
            _TestFees = test.Fees;
            _MaxNumberOfPeople = test.MaxNumberOfPeople;

            lbTestFeesResult.Text = test.Fees.ToString();
            lbTestDescriptionResult.Text = test.Description.ToString();
            lbMaxNubmerOfPeopleResult.Text = test.MaxNumberOfPeople.ToString();
        }

        private void fmManageTestsScreen_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbManageTestsScreen);

            LoadAllTests();
        }

        private void cbTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTestInfo(_ListOfTests.Find(x => x.Test == cbTests.Text));
            mtxtbNewFees.Focus();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtbNewFees.Text) && string.IsNullOrWhiteSpace(mtxtbNewMaxNumberOfPeople.Text))
            {
                MessageBox.Show("Both boxes are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(mtxtbNewFees.Text))
            {
                _TestFees = float.Parse(mtxtbNewFees.Text);
            }

            if (!string.IsNullOrWhiteSpace(mtxtbNewMaxNumberOfPeople.Text))
            {
                _MaxNumberOfPeople = short.Parse(mtxtbNewMaxNumberOfPeople.Text);
            }

            if (TestService.UpdateTest(_TestID, _TestFees, _MaxNumberOfPeople))
            {
                UpdateUI();
                MessageBox.Show("Operation completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Reset();
        }

        void Reset()
        {
            mtxtbNewFees.Clear();
            mtxtbNewMaxNumberOfPeople.Clear();
            mtxtbNewFees.Focus();
        }

        void UpdateUI()
        {
            lbMaxNubmerOfPeopleResult.Text = _MaxNumberOfPeople.ToString();
            lbTestFeesResult.Text = _TestFees.ToString();

            clsTest Test = _ListOfTests.Find(x => x.ID == _TestID);

            Test.Fees = _TestFees;
            Test.MaxNumberOfPeople = _MaxNumberOfPeople;
        }






    }
}
