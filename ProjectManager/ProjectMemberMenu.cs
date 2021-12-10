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
    //delegate signature to set project and group info for
    //current project member
    public delegate void SetProjectAndGroup(int id);
    public partial class ProjectMemberMenu : Form
    {
        ProjectMember projectMember;
        ProjectMember compTask;
        ProjectMember assignedTask;
        Project project = new Project();
        ProjectGroup projGroup = new ProjectGroup();
        ProjectManager projectManager = new ProjectManager();


        void ShowNewMenu(Form obj)
        {
            //Give control to the nextform
            obj.Tag = this;
            obj.Show(this);
            this.Hide();
        }
        public void SetMember(ProjectMember pm)
        {
            projectMember = pm;
        }

        public void SetDashboardlabels(string groupName, string firstName, string LastName,
            string title)
        {
            //set the labels information at top left corner 
            //of project member dashboard
            projectGroupNameLabel.Text = $"{groupName}";
            projectLeaderNameLabel.Text = $"{firstName} {LastName}";
            projectTitleLabel.Text = $"{title}";
        }
        public void IntializeGroup(ProjectGroup pg, Project p, ProjectManager pm)
        {
            projGroup = pg;
            project = p;
            projectManager = pm;
        }
        public void InitializeDashBoard()
        {
            //sets required lists, objects, datasource
            //and enables or disables required buttons
            projectMember.tasks.Clear();
            assignedTasksListBox.DataSource = projectMember.tasks;
            completedTasksListBox.DataSource = projectMember.tasks;
            assignedTasksListBox.SelectedIndex = -1;
            completedTasksListBox.SelectedIndex = -1;
            removeTaskCompletedBtn.Enabled = false;
            viewTaskdetailBtn.Enabled = false;
            completedTaskDetailBtn.Enabled = false;
            displayMemberTitleLabel.Text = $"Hello, {projectMember.FirstName} {projectMember.LastName}";
            if (projectMember.CheckifGroupMember(projectMember.PMemberID))
            {
                AssignObjectsValues();
                SetDashboardlabels(projGroup.PGroup_Name, projectManager.FirstName, projectManager.LastName, project.Project_Title);

            }
            else
            {
                SetDashboardlabels("none", "none", "", "none");
                projGroup = null;
                projectManager = null;
                project = null;
            }
            List<ProjectTask> pMemberTask = projectMember.GetTaskList(projectMember.PMemberID);
            if (projectMember.tasks.Count >= 1)
            {
                FilterTaskList();
            }

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

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            GotoContinuePage();
        }
        private void AssignObjectsValues()
        {
            //creates a multicasted deligate instance
            //which will set the current project and group and 
            //project manager object to their required values
            SetProjectAndGroup setProjectAndGroup = project.GetProjectInfo;
            setProjectAndGroup += projGroup.GetPGroupInfo;
            setProjectAndGroup(projectMember.PMemberID);
            projectManager.GetProjectManagerInfo(project.Project_ID);

        }
        public void FilterTaskList()
        {
            //filters tasks based on project currently 
            //completed and projects that are assigned 
            //and updates the list box view
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
            InitializeDashBoard();
        }

        private void viewGroupInfoBtn_Click(object sender, EventArgs e)
        {

            if (projGroup != null)
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



        private void viewTaskdetailBtn_Click(object sender, EventArgs e)
        {

            SubmitTaskForm submitTask = new SubmitTaskForm((ProjectTask)assignedTasksListBox.SelectedItem,
                projectMember, this);
            submitTask.ShowDialog();

        }

        private void taskCompBtn_Click(object sender, EventArgs e)
        {
            FilterTaskList();

        }

        private void assignedTasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when an item in listbox is clicked it will enable
            //or disable button according to that
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
            //if a member already completed a task
            //and want to update it he/she can reassign the 
            //task again , it will remove all the previous progress
            //of the task 
            if (completedTasksListBox.SelectedItem != null)
            {
                int val = (int)completedTasksListBox.SelectedValue;
                // => lamda expression
                //says that to retrive a ProjectTask object whose task id matches val
                //same as delegate(r) {return r.Task_ID ==val;}
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
            //when an item in listbox is clicked it will enable
            //or disable button according to that
            if (completedTasksListBox.SelectedIndex == -1)
            {
                removeTaskCompletedBtn.Enabled = false;
                completedTaskDetailBtn.Enabled = false;
            }
            else
            {
                removeTaskCompletedBtn.Enabled = true;
                completedTaskDetailBtn.Enabled = true;
            }
        }


        private void updateProjMemberInfo_Click(object sender, EventArgs e)
        {
            UpdateMemberInfo updateMember = new UpdateMemberInfo(projectMember,
                projGroup, projectManager, project);
            ShowNewMenu(updateMember);

        }

        private void joinProjectGroupBtn_Click(object sender, EventArgs e)
        {
            if (projGroup != null)
            {
                JoinNewGroup joinG = new JoinNewGroup(
                projectMember, project, projGroup, projectManager
                );
                ShowNewMenu(joinG);
            }
            else
            {
                JoinNewGroup joinG = new JoinNewGroup(
                                projectMember, null, null, null
                                );
                ShowNewMenu(joinG);
            }

        }

        private void viewProjectInfoBtn_Click(object sender, EventArgs e)
        {
            ViewMemberProjectInfo viewProjectInfo = new ViewMemberProjectInfo(project, projectMember, projectManager);
            ShowNewMenu(viewProjectInfo);
            this.Hide();
        }

        private void ProjectMemberMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = (ProjectMemberSignIn)Tag;
            var form2 = (ContinueAsProjectMemberForm)form1.Tag;
            form2.Show();
        }

        private void completedTaskDetailBtn_Click(object sender, EventArgs e)
        {
            if (completedTasksListBox.SelectedItem != null)
            {
                int val = (int)completedTasksListBox.SelectedValue;
                ProjectTask pTask = projectMember.tasks.Find(r => r.Task_ID == val);
                ViewCompletedTask viewCompleted = new ViewCompletedTask(pTask);
                viewCompleted.ShowDialog();
            }
        }
    }
}
