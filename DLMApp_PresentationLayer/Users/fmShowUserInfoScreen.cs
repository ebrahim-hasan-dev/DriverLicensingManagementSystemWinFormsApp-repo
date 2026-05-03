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
    public partial class fmShowUserInfoScreen : Form
    {
        public fmShowUserInfoScreen(clsPerson Person)
        {
            InitializeComponent();

            lbIsActive.Visible = false;
            lbIsActiveResult.Visible = false;
            lbUsername.Visible = false;
            lbUsernameResult.Visible = false;
            lbUserInfoScreen.Text = "Person Info Screen";

            uctrlPersonInfo1.SetPersonInfo(Person);
        }

        public fmShowUserInfoScreen(clsPerson Person, string Username, bool IsActive)
        {
            InitializeComponent();

            SetUserInfo(Person, Username, IsActive);
        }

        void SetUserInfo(clsPerson Person, string Username, bool IsActive)
        {
            uctrlPersonInfo1.SetPersonInfo(Person);

            lbUsernameResult.Text = Username;

            if (IsActive)
                lbIsActiveResult.Text = "Yes";
            else
                lbIsActiveResult.Text = "No";
        }

        private void fmShowPersonInfo_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbUserInfoScreen);
        }






    }
}
