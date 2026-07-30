using DLMApp_ModulesLayer;
using System;
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

            SetPersonInfo(Person);
        }

        public fmShowUserInfoScreen(clsPerson Person, string Username, bool IsActive)
        {
            InitializeComponent();

            SetUserInfo(Person, Username, IsActive);
        }

        async void SetUserInfo(clsPerson Person, string Username, bool IsActive)
        {
            await uctrlPersonInfo1.SetPersonInfo(Person);

            lbUsernameResult.Text = Username;

            if (IsActive)
                lbIsActiveResult.Text = "Yes";
            else
                lbIsActiveResult.Text = "No";
        }

        async void SetPersonInfo(clsPerson Person)
        {
            await uctrlPersonInfo1.SetPersonInfo(Person);
        }

        private void fmShowPersonInfo_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbUserInfoScreen);
        }



    }
}
