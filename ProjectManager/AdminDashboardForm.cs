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
using Tulpep.NotificationWindow;

namespace ProjectManagement
{
    public partial class AdminDashboardForm : Form
    {
        Admin admin;
        int updatedStatus = 1;
        static bool newNotfication = false;
        Validations validations = new Validations();
        static PopupNotifier popupNotifier = new PopupNotifier();
        static List<string> messages = new List<string>();
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
        public void ShowAllNotification()
        {
            if (messages.Count > 0)
            {
                foreach (string item in messages)
                {
                    popupNotifier.ContentText = item;
                    popupNotifier.Popup();
                }
            }
        }
        public static void SetNotification(bool notify, string msg)
        {
            newNotfication = notify;
            messages.Add(msg);

        }
        public void SetNewNotification()
        {
            if (newNotfication)
            {
                notificationsBtn.Image = Properties.Resources.Bell_Active;
                ShowAllNotification();
            }
            else
            {
                notificationsBtn.Image = Properties.Resources.Bell_Inactive;
            }
        }
        private void IntializeAdminDashBoard()
        {
            popupNotifier.ContentColor = Color.White;
            popupNotifier.BodyColor = Color.Black;
            popupNotifier.TitleText = "New notification";
            popupNotifier.TitleColor = Color.White;
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
            SetNewNotification();
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

        private void searchUserNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchUserNameTxtBox.Text.Trim()))
            {
                if (admin.GetUserByName(searchUserNameTxtBox.Text.Trim()) != null)
                {
                    currentUsersGridView.DataSource = admin.GetUserByName(searchUserNameTxtBox.Text.Trim()).Copy();
                    currentUsersGridView.ClearSelection();
                }
                else
                {
                    IntializeAdminDashBoard();
                }
            }
            else
            {
                IntializeAdminDashBoard();
            }
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = validations.ConfirmationMessage("Are you sure you want to remove this account ?");
            if (r == DialogResult.Yes)
            {
                if (admin.DeleteUserAccount())
                {
                    validations.ShowInfo("Account removed sucessfully");
                    searchUserNameTxtBox.Text = null;
                    IntializeAdminDashBoard();
                }
                else
                {
                    validations.ShowError("Error while removing account");
                }
            }
        }

        private void notificationsBtn_Click(object sender, EventArgs e)
        {
            newNotfication = false;
            messages.Clear();
            SetNewNotification();
            NotificationsForm notificationsForm = new NotificationsForm();
            notificationsForm.ShowDialog();
        }
    }
}
