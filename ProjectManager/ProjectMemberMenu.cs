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
    public delegate void SetProjectAndGroup(int id);
    public partial class ProjectMemberMenu : Form
    {
        static ProjectMember projectMember;
        ProjectMember compTask;
        ProjectMember assignedTask;
        Project project = new Project();
        ProjectGroup projGroup = new ProjectGroup();
        ProjectManager projectManager = new ProjectManager();
        ProjectTask pTask = new ProjectTask();

        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }
        public static void SetMember(ProjectMember pm)
        {
            projectMember = pm;
        }
        private void SetDashboardlabels(string groupName, string firstName, string LastName,
            string title)
        {
            projectGroupNameLabel.Text = $"{groupName}";
            projectLeaderNameLabel.Text = $"{firstName} {LastName}";
            projectTitleLabel.Text = $"{title}";
        }

        public ProjectMemberMenu()
        {
            InitializeComponent();

        }

        void GotoContinuePage()
        {
            //Goes to project manager continue form
            var form1 = (ProjectMemberSignIn)Tag;
            var form2 = (ContinueAsProjectMemberForm)form1.Tag;
            form1.Close();
            form2.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            GotoContinuePage();
        }
        private void AssignObjectsValues()
        {
            SetProjectAndGroup setProjectAndGroup = project.GetProjectInfo;
            setProjectAndGroup += projGroup.GetPGroupInfo;
            setProjectAndGroup(projectMember.PMemberID);
            projectManager.GetProjectManagerInfo(project.Project_ID);

        }
        public void FilterTaskList()
        {
            compTask = new ProjectMember();
            compTask.tasks.AddRange(projectMember.tasks.FindAll(x => x.Task_Completed == 2));
            completedTasksListBox.DataSource = null;
            completedTasksListBox.ValueMember = "Task_ID";
            completedTasksListBox.DisplayMember = "Task_Title";
            completedTasksListBox.DataSource = compTask.tasks;
            completedTasksListBox.SelectedIndex = -1;
            assignedTask = new ProjectMember();
            assignedTask.tasks.AddRange(projectMember.tasks.FindAll(x => x.Task_Completed == 1));
            assignedTasksListBox.DataSource = null;
            assignedTasksListBox.ValueMember = "Task_ID";
            assignedTasksListBox.DisplayMember = "Task_Title";
            assignedTasksListBox.DataSource = assignedTask.tasks;
            assignedTasksListBox.SelectedIndex = -1;

        }
        private void ProjectMemberMenu_Load(object sender, EventArgs e)
        {
            displayMemberTitleLabel.Text = $"Hello, {projectMember.FirstName} {projectMember.LastName}";
            if (projectMember.CheckifGroupMember(projectMember.PMemberID))
            {
                AssignObjectsValues();
                SetDashboardlabels(projGroup.PGroup_Name, projectManager.FirstName, projectManager.LastName, project.Project_Title);
            }
            else
            {
                SetDashboardlabels("none", "none", "", "none");
            }
            List<ProjectTask> pMemberTask = projectMember.GetTaskList(projectMember.PMemberID);
            if (pMemberTask.Count > 1)
            {
                FilterTaskList();
                assignedTasksListBox.SelectedIndex = -1;

            }
        }

        private void viewGroupInfoBtn_Click(object sender, EventArgs e)
        {
            if (projGroup.PGroup_Name != null)
            {
                ViewGroupInfo viewGroup = new ViewGroupInfo(projectManager, projGroup);
                ShowNewMenu(viewGroup);
            }
            else
            {
                ViewGroupInfo viewGroup = new ViewGroupInfo(null, null);
                ShowNewMenu(viewGroup);
            }


        }

        private void assignedTasksListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ProjectMemberMenu_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void assignedTasksListBox_Click(object sender, EventArgs e)
        {


        }



        private void viewTaskdetailBtn_Click(object sender, EventArgs e)
        {

            SubmitTaskForm submitTask = new SubmitTaskForm((ProjectTask)assignedTasksListBox.SelectedItem,
                projectMember, this);
            submitTask.Show();

        }

        private void taskCompBtn_Click(object sender, EventArgs e)
        {
            FilterTaskList();

        }

        private void assignedTasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (assignedTasksListBox.SelectedIndex == -1)
            {
                viewTaskdetailBtn.Enabled = false;
            }
            else
            {
                viewTaskdetailBtn.Enabled = true;
            }

        }

        private void removeTaskCompletedBtn_Click(object sender, EventArgs e)
        {
            if (completedTasksListBox.SelectedItem != null)
            {
                int val = (int)completedTasksListBox.SelectedValue;
                ProjectTask pTask = projectMember.tasks.Find(r => r.Task_ID == val);
                pTask.Task_Completed = 1;
                pTask.Task_Comment = null;
                pTask.Task_Attached = null;
                projectMember.RemoveTaskComplete(pTask.Task_ID);
                FilterTaskList();
            }
        }

        private void completedTasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (completedTasksListBox.SelectedIndex == -1)
            {
                removeTaskCompletedBtn.Enabled = false;
            }
            else
            {
                removeTaskCompletedBtn.Enabled = true;
            }
        }

        private void joinProjectGroupBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
