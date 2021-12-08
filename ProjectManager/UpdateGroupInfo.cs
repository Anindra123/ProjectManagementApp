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
    public delegate bool UpdateGroups(string gName, int memCount);
    public partial class UpdateGroupInfo : Form
    {
        ProjectManager pM;
        ProjectGroup pG = new ProjectGroup();
        Validations validations = new Validations();
        public UpdateGroupInfo()
        {
            InitializeComponent();
        }
        public UpdateGroupInfo(ProjectManager pM)
        {
            InitializeComponent();
            this.pM = pM;
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (updatePManagerInfo)Tag;
            form.IntializeForm();
            form.Show();
        }
        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            Project proj = pM.GetProject(pG.PGroup_ID);
            SearchAndAddMember addMember = new SearchAndAddMember(pG, proj);
            if (addMember.ShowDialog() == DialogResult.Cancel)
            {
                currentMembersGridView.DataSource = pG.FillMemberList();
                currentMembersGridView.Update();
                currentMembersGridView.Refresh();
            }
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {

        }
        private void ResetForm()
        {
            currentPManagerGroupsComboBox.DataSource = null;
            pM.GetProjectGroups();
            currentPManagerGroupsComboBox.DisplayMember = "PGroup_Name";
            currentPManagerGroupsComboBox.ValueMember = "PGroup_ID";
            currentPManagerGroupsComboBox.DataSource = pM.ProjectGroups;
            currentPManagerGroupsComboBox.SelectedIndex = -1;
            groupNameTxtBox.Text = null;
            memberCountTextBox.Text = null;
            currentMembersGridView.DataSource = null;

        }
        private void UpdateGroupInfo_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void UpdateGroupInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }

        private void currentPManagerGroupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentPManagerGroupsComboBox.SelectedIndex >= 0)
            {
                pG = (ProjectGroup)currentPManagerGroupsComboBox.SelectedItem;
                groupNameTxtBox.Text = pG.PGroup_Name;
                memberCountTextBox.Text = $"{pG.MembersCount}";
                if (pG.FillMemberList() != null)
                {
                    currentMembersGridView.DataSource = pG.FillMemberList();
                    currentMembersGridView.ClearSelection();
                }
                else
                {
                    currentMembersGridView.DataSource = null;
                }

            }
            else
            {
                currentPManagerGroupsComboBox.SelectedIndex = -1;
                groupNameTxtBox.Text = null;
                memberCountTextBox.Text = null;
                currentMembersGridView.DataSource = null;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(groupNameTxtBox.Text.Trim()) ||
                string.IsNullOrWhiteSpace(memberCountTextBox.Text.Trim()))
            {
                validations.ShowAlert("Text feilds cannot be empty");
            }
            else if (Convert.ToInt32(memberCountTextBox.Text.Trim()) <= 0)
            {

                validations.ShowAlert("Invalid Member Count");

            }
            else if (groupNameTxtBox.Text.Trim() != pG.PGroup_Name &&
               pG.SearchGroup(groupNameTxtBox.Text.Trim()))
            {
                validations.ShowAlert("A group with the same name already exists");

            }
            else
            {
                string gName = groupNameTxtBox.Text.Trim();
                int memCount = Convert.ToInt32(memberCountTextBox.Text.Trim());
                UpdateGroups updateGroups = pG.UpdateGroupContainsProjectTable;
                updateGroups += pG.UpdatePManagerGroupInfoTable;
                updateGroups += pG.UpdatePGroupTable;
                if (updateGroups(gName, memCount))
                {
                    DialogResult r = validations.ShowInfo("Updated Sucessfully");
                    if (r == DialogResult.OK)
                    {
                        ResetForm();
                    }
                }
            }
        }
    }
}
