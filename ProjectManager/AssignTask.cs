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
    public partial class AssignTask : Form
    {
        Project project;
        ProjectGroup pG;
        ProjectTask pT;
        ProjectMember pMember = new ProjectMember();
        Validations validations = new Validations();
        public AssignTask()
        {
            InitializeComponent();
        }
        public AssignTask(Project project, ProjectGroup pG, ProjectTask pT)
        {
            InitializeComponent();
            this.project = project;
            this.pG = pG;
            this.pT = pT;
        }
        private void SBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AssignTask_Load(object sender, EventArgs e)
        {
            projNameLbl.Text = project.Project_Title;
            groupNameLbl.Text = pG.PGroup_Name;
            TaskTitleLabel.Text = pT.Task_Title;
            TaskStatusLbl.Text = pT.GetStatus();
            selectMemberComboBox.DisplayMember = "Name";
            selectMemberComboBox.ValueMember = "PMember_ID";
            selectMemberComboBox.DataSource = pG.FillMemberList(pG.PGroup_ID);
            selectMemberComboBox.SelectedIndex = -1;
        }

        private void AssignTaskBtn_Click(object sender, EventArgs e)
        {
            if (selectMemberComboBox.SelectedIndex < 0)
            {
                validations.ShowAlert("Please select a member to assign to");
            }
            else
            {
                int pM_id = (int)selectMemberComboBox.SelectedValue;
                try
                {
                    if (pMember.AssignTask(pT.Task_Title, pT.Task_Desc, pT.Task_ID, pT.Task_Completed, pM_id))
                    {
                        if (validations.ShowInfo("Assigned to member sucessfully") == DialogResult.OK)
                        {
                            Close();
                        }
                    }
                }
                catch
                {
                    if (validations.ShowAlert("Task Already Assigned") == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
        }
    }
}
