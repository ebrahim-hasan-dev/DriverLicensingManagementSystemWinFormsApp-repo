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
    public partial class fmManageUsersScreen : Form
    {
        public fmManageUsersScreen()
        {
            InitializeComponent();
        }

        void FillDataGridView(List<clsUser> ListOfUsers)
        {
            if (ListOfUsers.Count > 0)
            {
                dgvUsers.Rows.Clear();

                lbNumberOfRowsResult.Text = ListOfUsers.Count.ToString();

                for (int i = 0; i < ListOfUsers.Count; i++)
                {
                    dgvUsers.Rows.Add(ListOfUsers[i].UserID, ListOfUsers[i].UserName, ListOfUsers[i].IsActive, ListOfUsers[i].PersonID);
                }
            }
            else
            {
                MessageBox.Show("No Results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillComboBox()
        {
            cbFilter.Items.Add("All");
            cbFilter.Items.Add("User Name");
            cbFilter.Items.Add("National Number");

            cbFilter.SelectedIndex = 0;
        }

        private void fmManageUsersScreen_Load(object sender, EventArgs e)
        {
            clsGlobal.MakeTitleInCenterScreen(this.Width, lbManageUsersScreen);

            dgvUsers.ForeColor = Color.Black;

            FillComboBox();

            FillDataGridView(UserService.GetAllUsers());
        }
     
        private void showUserInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int.TryParse(dgvUsers.SelectedRows[0].Cells[3].Value.ToString(), out int PersonID);
            bool IsActive = (bool)dgvUsers.SelectedRows[0].Cells[2].Value;

            clsPerson Person = PersonService.FindByPersonID(PersonID);

            fmShowUserInfoScreen showPersonInfo = new fmShowUserInfoScreen(Person, dgvUsers.SelectedRows[0].Cells[1].Value.ToString(), IsActive);
            showPersonInfo.ShowDialog();
        }

        private void makeUserInactiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int.TryParse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), out int UserID);

            if (UserService.UpdateActiveUser(UserID, false))
            {
                MessageBox.Show("Operation completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvUsers.SelectedRows[0].Cells[2].Value = false;
            }
        }

        private void makeUserActiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int.TryParse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), out int UserID);

            if (UserService.UpdateActiveUser(UserID, true))
            {
                MessageBox.Show("Operation completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvUsers.SelectedRows[0].Cells[2].Value = true;
            }
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int.TryParse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), out int UserID);

            int.TryParse(dgvUsers.SelectedRows[0].Cells[3].Value.ToString(), out int PersonID);

            clsPerson Person = PersonService.FindByPersonID(PersonID);

            clsUser User = UserService.Find(UserID);

            fmChangePasswordScreen udateUserScreen = new fmChangePasswordScreen(User, Person);
            udateUserScreen.ShowDialog();
        }

        void AddNewUser(clsUser User)
        {
            dgvUsers.Rows.Add(User.UserID, User.UserName, User.IsActive, User.PersonID);

            int NumberOfRows = int.Parse(lbNumberOfRowsResult.Text);
            NumberOfRows++;
            lbNumberOfRowsResult.Text = NumberOfRows.ToString();
        }

        private void contextMenuStrip1_Opening_2(object sender, CancelEventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                showUserInfoToolStripMenuItem1.Enabled = true;
                makeUserInactiveToolStripMenuItem1.Enabled = true;
                makeUserActiveToolStripMenuItem1.Enabled = true;
                ChangePasswordToolStripMenuItem1.Enabled = true;

                if ((bool)dgvUsers.SelectedRows[0].Cells[2].Value == true)
                {
                    makeUserInactiveToolStripMenuItem1.Enabled = true;
                    makeUserActiveToolStripMenuItem1.Enabled = false;
                }
                else
                {
                    makeUserInactiveToolStripMenuItem1.Enabled = false;
                    makeUserActiveToolStripMenuItem1.Enabled = true;
                }
            }
            else
            {
                showUserInfoToolStripMenuItem1.Enabled = false;
                makeUserInactiveToolStripMenuItem1.Enabled = false;
                makeUserActiveToolStripMenuItem1.Enabled = false;
                ChangePasswordToolStripMenuItem1.Enabled = false;
            }
        }

        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            fmAddNewUserScreen addNewUserScreen = new fmAddNewUserScreen();
            addNewUserScreen.AddedEventHandler += AddNewUser;
            addNewUserScreen.ShowDialog();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if (cbFilter.Text == "All")
            {
                FillDataGridView(UserService.GetAllUsers());
            }
            else
            {
                if (cbFilter.Text == "User Name")
                {
                    if (!string.IsNullOrWhiteSpace(mtxtbFilter.Text))
                    {
                        dgvUsers.Rows.Clear();

                        clsUser User = UserService.FindWithoutPass(mtxtbFilter.Text);

                        if (User != null)
                        {
                            lbNumberOfRowsResult.Text = 1.ToString();

                            dgvUsers.Rows.Add(User.UserID, User.UserName, User.IsActive, User.PersonID);
                        }
                        else
                        {
                            MessageBox.Show("No Results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cbFilter.Text == "National Number")
                {
                    if (mtxtbFilter.MaskCompleted)
                    {
                        dgvUsers.Rows.Clear();

                        clsUser User = UserService.FindByNationalNumber(mtxtbFilter.Text);

                        if (User != null)
                        {
                            lbNumberOfRowsResult.Text = 1.ToString();

                            dgvUsers.Rows.Add(User.UserID, User.UserName, User.IsActive, User.PersonID);
                        }
                        else
                        {
                            MessageBox.Show("No Results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("National number not completed or empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            mtxtbFilter.Focus();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "User Name")
            {
                mtxtbFilter.Mask = "&&&&&&&&&&&&&&&&&&&&";
            }
            else if (cbFilter.Text == "National Number")
            {
                mtxtbFilter.Mask = "00000000000000";
            }

            mtxtbFilter.Clear();
            mtxtbFilter.Focus();
        }

        private void newPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAddNewUserScreen addNewUserScreen = new fmAddNewUserScreen();
            addNewUserScreen.AddedEventHandler += AddNewUser;
            addNewUserScreen.ShowDialog();
        }

        private void findPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmFindPersonScreen findPersonScreen = new fmFindPersonScreen();
            findPersonScreen.ShowDialog();
        }











    }
}
