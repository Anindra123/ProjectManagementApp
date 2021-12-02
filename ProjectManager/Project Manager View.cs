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
    public partial class updatePManagerInfo : System.Windows.Forms.Form
    {
        ProjectManager pM;
        ProjectGroup pG = new ProjectGroup();
        Project project = new Project();
        ProjectTask pT = new ProjectTask();

        public updatePManagerInfo()
        {
            InitializeComponent();
        }
        public updatePManagerInfo(ProjectManager pM)
        {
            InitializeComponent();
            this.pM = pM;
        }
        void GotoContinuePage()
        {
            //Goes to project manager continue form
            var form1 = (ProjectManagerSignIn)Tag;
            var form2 = (ContinueAsProjectManagerForm)form1.Tag;
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
            groupAndProjectView.DataSource = null;
            currentTaskGridView.DataSource = null;
            completedTaskGridView.DataSource = null;
            if (pM != null)
            {
                pM.GetProjectGroups();
                pM.GetProjects();
                pM.GetProjectManager();
                welcomeFullNameLabel.Text = $"Welcome, {pM.FirstName} {pM.LastName}";
                if (pM.ProjectGroups.Count > 0 && pM.Projects.Count > 0)
                {
                    groupAndProjectView.DataSource = pM.ViewProjectGroupInfo().Copy();
                    groupAndProjectView.ClearSelection();
                }
                if (pM.ViewCurrentTask(pM.PManager_ID) != null)
                {
                    currentTaskGridView.DataSource = pM.ViewCurrentTask(pM.PManager_ID).Copy();
                    currentTaskGridView.ClearSelection();
                }
                if (pM.ViewCompletedTask(pM.PManager_ID) != null)
                {
                    completedTaskGridView.DataSource = pM.ViewCompletedTask(pM.PManager_ID).Copy();
                    completedTaskGridView.ClearSelection();
                }
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void currentProjectsLabel_Click(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            GotoContinuePage();
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
            UpdateGroupInfo uGI1 = new UpdateGroupInfo();
            ShowNewMenu(uGI1);
        }

        private void viewProjectInfoBtn_Click(object sender, EventArgs e)
        {
            ViewProjectInfo vPI1 = new ViewProjectInfo();
            ShowNewMenu(vPI1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProjectInfo uPI1 = new UpdateProjectInfo();
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
            if (pT.Task_ID > 0)
            {
                pG.GetProjectGroup(pT.Task_ID);
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
    }
}
