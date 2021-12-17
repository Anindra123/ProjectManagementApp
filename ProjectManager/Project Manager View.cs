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
    //delegate signature which will store the reference
    //of all the removing task info from task table methods
    public delegate bool RemoveTaskFromTables();
    public partial class updatePManagerInfo : System.Windows.Forms.Form
    {
        ProjectManager pM;
        ProjectGroup pG = new ProjectGroup();
        Project project = new Project();
        ProjectTask pT = new ProjectTask();
        ProjectMember pMember = new ProjectMember();
        Validations validations = new Validations();
        BackLog bL = new BackLog();
        public updatePManagerInfo()
        {
            InitializeComponent();
        }
        //overloaded constructor
        public updatePManagerInfo(ProjectManager pM)
        {
            InitializeComponent();
            this.pM = pM;
        }
        void GotoStartPage()
        {
            //Goes to start form
            var form1 = (SignInForm)Tag;
            var form2 = (ProjectManagementStartForm)form1.Tag;
            form1.Close();
            form2.Show();
        }
        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }

        public void IntializeForm()
        {
            //will reset all grid view data and
            //disables some buttons
            groupAndProjectView.DataSource = null;
            currentTaskGridView.DataSource = null;
            completedTaskGridView.DataSource = null;
            viewCompletedTaskBtn.Enabled = false;

            assignTaskBtn.Enabled = false;
            sendToBacklogBtn.Enabled = false;
            if (pM != null)
            {
                pM.GetProjectGroups();
                pM.GetProjects();
                //pM.GetProjectManager();
                welcomeFullNameLabel.Text = $"Welcome, {pM.FirstName} {pM.LastName}";
                if (pM.ProjectGroups.Count > 0 && pM.Projects.Count > 0)
                {
                    groupAndProjectView.DataSource = pM.ViewProjectGroupInfo().Copy();
                    groupAndProjectView.ClearSelection();
                }
                else
                {
                    groupAndProjectView.DataSource = null;
                }
                if (pM.ViewCurrentTask(pM.UserID) != null)
                {
                    currentTaskGridView.DataSource = pM.ViewCurrentTask(pM.UserID).Copy();
                    currentTaskGridView.ClearSelection();
                }
                else
                {
                    currentTaskGridView.DataSource = null;
                }
                if (pM.ViewCompletedTask(pM.UserID) != null)
                {
                    completedTaskGridView.DataSource = pM.ViewCompletedTask(pM.UserID).Copy();
                    completedTaskGridView.ClearSelection();
                }
                else
                {
                    completedTaskGridView.DataSource = null;
                }
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            GotoStartPage();
            this.Close();
        }

        private void addNewFeatureBtn_Click(object sender, EventArgs e)
        {
            AddNewFeature aDF1 = new AddNewFeature(pM);
            if (aDF1.ShowDialog() == DialogResult.Cancel)
            {
                IntializeForm();
            }
        }

        private void updateGroupMembersBtn_Click(object sender, EventArgs e)
        {
            UpdateGroupInfo updateGroupInfo = new UpdateGroupInfo(pM);
            ShowNewMenu(updateGroupInfo);
        }

        private void viewProjectInfoBtn_Click(object sender, EventArgs e)
        {
            ViewProjectManagerGroupInfo groupInfo = new ViewProjectManagerGroupInfo(pM);
            ShowNewMenu(groupInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProjectInfo uPI1 = new UpdateProjectInfo(pM);
            ShowNewMenu(uPI1);
        }

        private void updatePManagerInfoBtn_Click(object sender, EventArgs e)
        {
            UpdateProjectManager uManager = new UpdateProjectManager(pM);
            ShowNewMenu(uManager);
        }

        private void updatePManagerInfo_Load(object sender, EventArgs e)
        {
            IntializeForm();
        }

        private void createNewGroupBtn_Click(object sender, EventArgs e)
        {
            CreateNewGroup createNewGroup = new CreateNewGroup(pM);
            ShowNewMenu(createNewGroup);
        }

        private void assignTaskBtn_Click(object sender, EventArgs e)
        {
            //checkes whether a task is click to be assinged 
            //show the assign task form
            if (pT.Task_ID > 0)
            {
                pG.GetProjectGroupFromTask(pT.Task_ID);
                project.GetProjectInfoFromTask(pT.Task_ID);
                AssignTask assignTask = new AssignTask(project, pG, pT);
                assignTask.ShowDialog();

            }
            else
            {
                assignTaskBtn.Enabled = false;
            }
        }

        private void currentTaskGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //updates the project task object information
            //when a row is selected
            assignTaskBtn.Enabled = true;
            DataGridViewRow row = currentTaskGridView.SelectedRows[0];
            pT.Task_ID = (int)row.Cells["ID"].Value;
            pT.Task_Title = (string)row.Cells["Title"].Value;
            pT.Task_Desc = (string)row.Cells["Description"].Value;
            string status = (string)row.Cells["Status"].Value;
            if (status == "Pending")
            {
                pT.Task_Completed = 1;
            }
        }

        private void viewCompletedTaskBtn_Click(object sender, EventArgs e)
        {
            //shows the completed task by member
            //information after a row is selected
            if (completedTaskGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = completedTaskGridView.SelectedRows[0];
                pT.Task_ID = (int)row.Cells["ID"].Value;
                pT.Task_Title = (string)row.Cells["Title"].Value;
                pT.Task_Desc = (string)row.Cells["Description"].Value;
                ViewCompletedTask vct = new ViewCompletedTask(pT);
                vct.ShowDialog();
            }
            else
            {
                validations.ShowAlert("Please Select a task to view");
            }
        }

        private void updatePManagerInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = (SignInForm)Tag;
            var form2 = (ProjectManagementStartForm)form1.Tag;
            form2.Show();
        }

        private void sendToBacklogBtn_Click(object sender, EventArgs e)
        {
            if (completedTaskGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = completedTaskGridView.SelectedRows[0];
                pT.Task_ID = (int)row.Cells["ID"].Value;
                pT.Task_Title = (string)row.Cells["Title"].Value;
                pT.Task_Desc = (string)row.Cells["Description"].Value;
                pG.GetProjectGroupFromTask(pT.Task_ID);
                project.GetProjectInfoFromTask(pT.Task_ID);
                pMember.GetProjectMemberFromTask(pT.Task_ID);
                DialogResult r = MessageBox.Show("Are you sure you want to place this task to backlog ?", "Send To Backlog",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    //setting the backlog object property values
                    //for the data to be inserted 
                    bL.BackLog_GroupName = pG.PGroup_Name;
                    bL.BackLog_ProjectTitle = project.Project_Title;
                    bL.BackLog_TaskTitle = pT.Task_Title;
                    bL.BackLog_TaskCompleted = $"{pMember.FirstName} {pMember.LastName}";
                    bL.PManager_ID = pM.UserID;
                    bL.InsertBackLogData();
                    //Multicasted deligate instance created
                    RemoveTaskFromTables removeTask = pT.DeleteFromPerformTaskTable;
                    removeTask += pT.DeleteFromAssignTaskTable;
                    removeTask += pT.DeleteFromTaskTable;
                    //deligate invoked
                    if (removeTask())
                    {
                        validations.ShowInfo("Task send to Backlogs");
                        if (pM.ViewCompletedTask(pM.UserID) != null)
                        {
                            completedTaskGridView.DataSource = pM.ViewCompletedTask(pM.UserID).Copy();
                            completedTaskGridView.ClearSelection();
                        }
                        else
                        {
                            completedTaskGridView.DataSource = null;
                        }
                    }
                }

            }
            else
            {
                validations.ShowAlert("Please Select a task to send to backlog");
            }
        }

        private void viewProjectBacklogBtn_Click(object sender, EventArgs e)
        {
            bL.PManager_ID = pM.UserID;
            BackLogTaskView backLog = new BackLogTaskView(bL);
            ShowNewMenu(backLog);

        }

        private void completedTaskGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viewCompletedTaskBtn.Enabled = true;
            sendToBacklogBtn.Enabled = true;
        }
    }
}
