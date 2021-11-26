using ProjectManagement.ClassFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class UpdateMemberInfo : Form
    {
        ProjectMember pM;
        ProjectGroup pG;
        ProjectManager pMang;
        Project project;
        bool leaveGroup = false;

        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public UpdateMemberInfo()
        {
            InitializeComponent();
        }
        public UpdateMemberInfo(ProjectMember pM, ProjectGroup pG,
            ProjectManager pMang, Project project)
        {
            InitializeComponent();
            this.pM = pM;
            this.pG = pG;
            this.pMang = pMang;
            this.project = project;
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (ProjectMemberMenu)Tag;
            form.InitializeDashBoard();
            form.Show();

        }
        private void updateCnfirmBtn_Click(object sender, EventArgs e)
        {

            //main form validation
            if (!string.IsNullOrWhiteSpace(projectMemberFirstNameTxtBox.Text.Trim())
                && !string.IsNullOrWhiteSpace(projectMemberLastNameTxtBox.Text.Trim())
                && !string.IsNullOrWhiteSpace(projMemberPasswordTextBox.Text)
                && !string.IsNullOrWhiteSpace(projMemberEmailTxtBox.Text.Trim())
                )
            {
                //Email validation
                if (Regex.IsMatch(projMemberEmailTxtBox.Text.Trim(), pattern))
                {
                    pM.FirstName = projectMemberFirstNameTxtBox.Text.Trim();
                    pM.LastName = projectMemberLastNameTxtBox.Text.Trim();
                    pM.Email = projMemberEmailTxtBox.Text.Trim();
                    pM.password = projMemberPasswordTextBox.Text.Trim();
                    if (pM.UpdateMemberInfo())
                    {
                        if (leaveGroup == true)
                        {
                            UpdateGroupAndProject updateGroupAndProject = pM.UpdateMemberGroupInfoTable;
                            updateGroupAndProject += pM.UpdateMemberProjInfoTable;
                            if (updateGroupAndProject(pM.PMemberID) && pM.UpdateMemberAssignedTask(project.Project_ID))
                            {
                                MessageBox.Show("Updated Sucessfully", "Sucess",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        MessageBox.Show("Updated Sucessfully", "Sucess",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error during update", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email Is Invalid", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Text fields Cannot Be Empty", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateMemberInfo_Load(object sender, EventArgs e)
        {
            projectMemberFirstNameTxtBox.Text = pM.FirstName;
            projectMemberLastNameTxtBox.Text = pM.LastName;
            projMemberEmailTxtBox.Text = pM.Email;
            projMemberPasswordTextBox.Text = pM.password;
            projManagerLabel.Text = $"{pMang.FirstName} {pMang.LastName}";
            groupNameLabel.Text = pG.PGroup_Name;
            projNameLabel.Text = project.Project_Title;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            ShowPreviousMenu();
            this.Close();
        }

        private void UpdateMemberInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }

        private void leaveGroupBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm Leave ?", "Leave Group",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                groupNameLabel.Text = "none";
                projNameLabel.Text = "none";
                projManagerLabel.Text = "none";
                leaveGroup = true;

            }
            else
            {
                leaveGroup = false;
            }
        }
    }
}
