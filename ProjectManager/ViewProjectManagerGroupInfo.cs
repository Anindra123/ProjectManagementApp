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
    public partial class ViewProjectManagerGroupInfo : Form
    {
        ProjectGroup pG = new ProjectGroup();
        ProjectManager pM;
        ProjectMember pMemeber = new ProjectMember();
        ProjectTask pT = new ProjectTask();
        Project project = new Project();

        public ViewProjectManagerGroupInfo()
        {
            InitializeComponent();
        }
        public ViewProjectManagerGroupInfo(ProjectManager pM)
        {
            InitializeComponent();
            this.pM = pM;
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (updatePManagerInfo)Tag;
            form.Show();
        }

        private void ViewProjectManagerGroupInfo_Load(object sender, EventArgs e)
        {
            if (pM != null)
            {
                pM.GetProjectGroups();
                currentPManagerGroupsComboBox.DisplayMember = "PGroup_Name";
                currentPManagerGroupsComboBox.DataSource = pM.ProjectGroups;
                currentPManagerGroupsComboBox.SelectedIndex = -1;
                currentActiveTaskDataGridView.DataSource = null;
                currentMembersGridView.DataSource = null;
                groupNameLabel.Text = "none";
                noOfMemberLbl.Text = "none";
                projectTitleLbl.Text = "none";
                projDescLabel.Text = "none";
                projStatusLabl.Text = "none";
                startDateLabl.Text = "none";
                endDateLabl.Text = "none";
            }
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            Close();
        }

        private void ViewProjectManagerGroupInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }

        private void currentPManagerGroupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentPManagerGroupsComboBox.SelectedIndex >= 0)
            {
                pG = (ProjectGroup)currentPManagerGroupsComboBox.SelectedItem;
                project = pM.GetProject(pG.PGroup_ID);
                groupNameLabel.Text = pG.PGroup_Name;
                noOfMemberLbl.Text = $"{pG.MembersCount}";
                if (pG.FillMemberList() != null)
                {
                    currentMembersGridView.DataSource = pG.FillMemberList();
                }
                else
                {
                    currentMembersGridView.DataSource = null;
                }
                projectTitleLbl.Text = project.Project_Title;
                projDescLabel.Text = project.Project_Desc;
                projStatusLabl.Text = project.GetProjectStatus();
                startDateLabl.Text = project.Project_StartDate.ToShortDateString();
                endDateLabl.Text = project.Project_EndDate.ToShortDateString();
                if (pT.GetTaskListFromProject(project.Project_ID) != null)
                {
                    currentActiveTaskDataGridView.DataSource = pT.GetTaskListFromProject(project.Project_ID);
                }
                else
                {
                    currentActiveTaskDataGridView.DataSource = null;
                }
            }
        }
    }
}
