using DLMApp_ModulesLayer;
using DLMApp_BusinessLayer;
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
    public partial class fmMainScreen : Form
    {
        fmLoginScreen _loginScreen = null;

        
        public fmMainScreen(fmLoginScreen loginScreen)
        {
            _loginScreen = loginScreen;

            InitializeComponent();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmTestsScreen testsScreenc = new fmTestsScreen(false);
            testsScreenc.ShowDialog();


        }

        private void setResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmTestsScreen testsScreen = new fmTestsScreen(true);
            testsScreen.ShowDialog();
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmTestsScreen testsScreen = new fmTestsScreen(true);
            testsScreen.ShowDialog();
        }

        private void issuingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmIssuingLicenseScreen issuingNewLicense = new fmIssuingLicenseScreen(true);
            issuingNewLicense.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmRetakeTestScreen retakeTestScreen = new fmRetakeTestScreen();
            retakeTestScreen.ShowDialog();
        }

        private void damagedReplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDamagedReplacementScreen damagedReplacementScreen = new fmDamagedReplacementScreen();
            damagedReplacementScreen.ShowDialog();
        }

        private void lostReplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmLostReplacementScreen lostReplacementScreen = new fmLostReplacementScreen();
            lostReplacementScreen.ShowDialog();
        }

        private void detainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDetainedLicenseScreen detainedLicenseScreen = new fmDetainedLicenseScreen();
            detainedLicenseScreen.ShowDialog();
        }
      
        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmReleaseDetainedLicenseScreen releaseDetainedLicenseScreen = new fmReleaseDetainedLicenseScreen();
            releaseDetainedLicenseScreen.ShowDialog();
        }

        private void renewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmRenewLicenseScreen renewLicenseScreen = new fmRenewLicenseScreen();
            renewLicenseScreen.ShowDialog();
        }

        private void issuingLicenseRenewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmIssuingLicenseScreen IssuingRenewLicenseScreen = new fmIssuingLicenseScreen(false);
            IssuingRenewLicenseScreen.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNewLocalLicenseScreen newLocalLicense = new fmNewLocalLicenseScreen();
            newLocalLicense.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNewInternationalLicenseScreen newInternationalLicenseScreen = new fmNewInternationalLicenseScreen();
            newInternationalLicenseScreen.ShowDialog();
        }

        private void manageLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmManageLicensesScreen ManageLicensesScreen = new fmManageLicensesScreen();
            ManageLicensesScreen.ShowDialog();
        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmManageApplicationsScreen manageApplicationsScreen = new fmManageApplicationsScreen();
            manageApplicationsScreen.ShowDialog();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmManageUsersScreen ManageUsersScreen = new fmManageUsersScreen();
            ManageUsersScreen.ShowDialog();
        }

        private void managePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmManagePeopleScreen managePeopleScreen = new fmManagePeopleScreen();
            managePeopleScreen.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAdd_UpdatePersonScreen add_UpdatePersonScreen = new fmAdd_UpdatePersonScreen();
            add_UpdatePersonScreen.ShowDialog();
        }

        private void manageTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmManageTestsScreen manageTestsScreen = new fmManageTestsScreen();
            manageTestsScreen.ShowDialog();
        }

        private void manageLicenseClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmManageLicenseClassesScreen manageLicenseClassesScreen = new fmManageLicenseClassesScreen();
            manageLicenseClassesScreen.ShowDialog();
        }

        private void changeApplicationTypeFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmChangeApplicationFeesScreen changeApplicationFeesScreen = new fmChangeApplicationFeesScreen();
            changeApplicationFeesScreen.ShowDialog();
        }

        private void newPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fmAddNewUserScreen addNewUserScreen = new fmAddNewUserScreen();
            addNewUserScreen.ShowDialog();
        }

        private void findPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmFindPersonScreen findPersonScreen = new fmFindPersonScreen();
            findPersonScreen.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsGlobal.CurrentUser = null;

            _loginScreen.Show();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPerson Person = PersonService.FindByPersonID(clsGlobal.CurrentUser.PersonID);

            fmShowUserInfoScreen showPersonInfo = new fmShowUserInfoScreen(Person, clsGlobal.CurrentUser.UserName, clsGlobal.CurrentUser.IsActive);
            showPersonInfo.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPerson Person = PersonService.FindByPersonID(clsGlobal.CurrentUser.PersonID);

            fmChangePasswordScreen udateUserScreen = new fmChangePasswordScreen(clsGlobal.CurrentUser, Person);
            udateUserScreen.ShowDialog();
        }




    }
}
