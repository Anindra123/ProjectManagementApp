using ProjectManagement.ClassFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class AdminDashboardForm : Form
    {
        Admin admin;
        int updatedStatus = 1;
        Validations validations = new Validations();
        public AdminDashboardForm()
        {
            InitializeComponent();
        }
        public AdminDashboardForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }
        void GotoStartPage()
        {
            //Goes to start form
            var form1 = (AdminLoginForm)Tag;
            var form2 = (ProjectManagementStartForm)form1.Tag;
            form1.Close();
            form2.Show();
        }
        private void ChangeBtnState(bool state)
        {
            updateStatusBtn.Enabled = state;
            deleteAccountBtn.Enabled = state;
            verifiedRadioBtn.Enabled = state;
            unVerifiedRadioBtn.Enabled = state;
            blockRadioBtn.Enabled = state;
        }
        private void IntializeAdminDashBoard()
        {
            updatedStatus = 1;
            currentUsersGridView.DataSource = null;
            if (admin.GetUserList() != null)
            {
                currentUsersGridView.DataSource = admin.GetUserList().Copy();
                currentUsersGridView.ClearSelection();
            }

            fullNameTextBox.Text = null;
            emailTexbox.Text = null;
            ChangeBtnState(false);
        }
        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            IntializeAdminDashBoard();
        }

        private void currentUsersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeBtnState(true);
            DataGridViewRow row = currentUsersGridView.SelectedRows[0];
            int u_id = (int)row.Cells["User ID"].Value;
            admin.FillUserInfo(u_id);
            fullNameTextBox.Text = $"{admin.FirstName} {admin.LastName}";
            emailTexbox.Text = admin.Email;
            if (admin.UserStatus == "Unverified")
            {
                unVerifiedRadioBtn.Checked = true;
                updateStatusBtn.Enabled = false;
            }
            else if (admin.UserStatus == "Verified")
            {
                verifiedRadioBtn.Checked = true;
            }
            else
            {
                blockRadioBtn.Checked = true;
            }
        }

        private void verifiedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (verifiedRadioBtn.Checked == true)
            {
                updatedStatus = 2;
                updateStatusBtn.Enabled = true;
            }
        }

        private void blockRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (blockRadioBtn.Checked == true)
            {
                updatedStatus = 3;
                updateStatusBtn.Enabled = true;
            }
        }

        private void updateStatusBtn_Click(object sender, EventArgs e)
        {
            if (admin.UpdateUserStatus(updatedStatus))
            {
                DialogResult r = validations.ShowInfo("Updated Status Sucessfully");
                if (r == DialogResult.OK)
                {
                    IntializeAdminDashBoard();
                }
            }
            else
            {
                validations.ShowAlert("Error while updating user status");
            }
        }

        private void unVerifiedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (unVerifiedRadioBtn.Checked == true)
            {
                updatedStatus = 1;
                updateStatusBtn.Enabled = false;
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            GotoStartPage();
        }

        private void AdminDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = (AdminLoginForm)Tag;
            var form2 = (ProjectManagementStartForm)form1.Tag;
            form2.Show();
        }
    }
}
