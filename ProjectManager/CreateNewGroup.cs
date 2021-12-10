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
    public partial class CreateNewGroup : Form
    {
        Validations validations = new Validations();
        ProjectManager pM;
        ProjectMember pMember;
        DataTable dt = new DataTable();
        List<ProjectMember> projectMembers = new List<ProjectMember>();
        string gName;
        string gMCount;
        string pTitle;
        string pDesc;
        DateTime sDate;
        DateTime eDate;
        public CreateNewGroup()
        {
            InitializeComponent();
        }
        //overloaded constructor
        public CreateNewGroup(ProjectManager pM)
        {
            InitializeComponent();
            this.pM = pM;
            membersAddedGridView.DataSource = dt;
            membersAddedGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (updatePManagerInfo)Tag;
            form.IntializeForm();
            form.Show();
        }
        private bool Validations()
        {
            //validates the project and group
            //information check box and also verifies 
            //start date and end date and number of
            //members being added

            gName = proMGroupNameTextBox.Text.Trim();
            gMCount = membersCountTxtBox.Text.Trim();
            pTitle = projectTitleTxtBox.Text.Trim();
            pDesc = projDescTxtBox.Text.Trim();
            sDate = proMStartDatePicker.Value.Date;
            eDate = proMEndDatePicker.Value.Date;
            if (string.IsNullOrWhiteSpace(gName) ||
                string.IsNullOrWhiteSpace(gMCount) ||
                string.IsNullOrWhiteSpace(pTitle) ||
                string.IsNullOrWhiteSpace(pDesc))
            {
                validations.ShowAlert("Text feilds cannot be empty");
                return false;
            }
            else if (Convert.ToInt32(gMCount) <= 0)
            {
                validations.ShowAlert("Invalid number of members");
                return false;

            }
            else if (validations.VerifyDates(sDate, eDate))
            {
                return false;
            }
            return true;
        }
        private void ResetGroupMemberFeilds()
        {
            //resets the feilds where group members
            //being searched and added
            memberMailTxtBox.Text = "none";
            memberNameTxtBox.Text = "none";
            proMSearchMemTextBox.Text = null;
        }
        private void ResetCreateGroupForm()
        {
            //reset the information shown on the entire form
            proMGroupNameTextBox.Text = null;
            projectTitleTxtBox.Text = null;
            projDescTxtBox.Text = null;
            proMStartDatePicker.Value = DateTime.Today.Date;
            proMEndDatePicker.Value = DateTime.Today.Date;
            membersCountTxtBox.Text = null;
            dt.Rows.Clear();
            dt.Columns.Clear();
            dt.Clear();
            ResetGroupMemberFeilds();
        }
        private void createGroupBtn_Click(object sender, EventArgs e)
        {
            if (Validations())
            {
                if (pM.CreateGroup(gName, Convert.ToInt32(gMCount)) &&
                    pM.CreateProject(pTitle, pDesc, sDate, eDate) &&
                    pM.AssignGroup(gName, pM.PManager_ID) &&
                    pM.AssignProject(pTitle, pM.PManager_ID, gName))
                {
                    pM.GetProjectGroups();
                    pM.GetProjects();
                    if (projectMembers.Count > 0)
                    {
                        ProjectGroup pG = pM.ProjectGroups.Last();
                        pM.AddGroupMembers(projectMembers, pG.PGroup_ID);
                        Project p = pM.Projects.Last();
                        pM.AddProjectMembers(projectMembers, p.Project_ID);
                    }
                    validations.ShowInfo("Group created sucessfully");
                    ResetCreateGroupForm();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }

        private void CreateNewGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }


        private void proMSearchMemBtn_Click(object sender, EventArgs e)
        {
            //searches for the project member for the given email
            //on the search text box and assigns its data on the labels
            if (string.IsNullOrWhiteSpace(proMSearchMemTextBox.Text.Trim()))
            {
                validations.ShowAlert("Invalid Entry on Search field");
            }
            else if (pM.SearchPMember(proMSearchMemTextBox.Text.Trim()) == null)
            {
                validations.ShowAlert("Could not find member account / Invalid member mail.Try again");
                ResetGroupMemberFeilds();
            }
            else
            {
                pMember = pM.SearchPMember(proMSearchMemTextBox.Text.Trim());

                DialogResult result = MessageBox.Show($"Found {pMember.FirstName} {pMember.LastName}",
                    "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    memberNameTxtBox.Text = $"{pMember.FirstName} {pMember.LastName}";
                    memberMailTxtBox.Text = pMember.Email;
                }
            }
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            //searched member is added , checks whether a member
            // was found and whether the number of members in the group
            // is max and if the member is already member of another
            //group and if the current member count is valid
            if (memberNameTxtBox.Text == "none" && memberMailTxtBox.Text == "none")
            {
                validations.ShowAlert("No member added");
            }
            else if (string.IsNullOrWhiteSpace(membersCountTxtBox.Text.Trim()))
            {
                validations.ShowAlert("Member count feild is empty");
                ResetGroupMemberFeilds();

            }
            else if (Convert.ToInt32(membersCountTxtBox.Text.Trim()) <= 0)
            {
                validations.ShowAlert("Invalid Member Count");
                ResetGroupMemberFeilds();

            }
            else if (pMember != null && pM.CheckIfAlreadyGroupMember(pMember.PMemberID))
            {
                validations.ShowAlert("Selected user already a member of different group");

            }
            else if (dt.Rows.Count >= Convert.ToInt32(membersCountTxtBox.Text.Trim()))
            {
                validations.ShowAlert("Maximum group member reached");
            }
            else
            {
                if (pMember != null)
                {
                    DialogResult result = MessageBox.Show("Confirm Add ?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        pM.FillPmemberData(dt, pMember.PMemberID);
                        projectMembers.Add(pMember);
                    }
                    else
                    {
                        ResetGroupMemberFeilds();

                    }
                }
            }
        }
    }
}
