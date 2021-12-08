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
    public partial class SearchAndAddMember : Form
    {
        ProjectGroup pG;
        Project project;
        ProjectMember pMember = new ProjectMember();
        Validations validations = new Validations();
        public SearchAndAddMember()
        {
            InitializeComponent();
        }
        public SearchAndAddMember(ProjectGroup pG, Project project)
        {
            InitializeComponent();
            this.pG = pG;
            this.project = project;
        }
        private void proMSearchMemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void proMSearchAndAddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(proMSearchMemTextBox.Text.Trim()))
            {
                validations.ShowAlert("Not a valid mail");
                proMSearchMemTextBox.Text = null;
            }
            else if (!pMember.SearchMember(proMSearchMemTextBox.Text.Trim()))
            {
                validations.ShowAlert("User doesn't exist or invalid mail");
                proMSearchMemTextBox.Text = null;
            }
            else if (pMember.CheckifGroupMember(pMember.PMemberID))
            {
                validations.ShowAlert("User is already a member of different group");
                proMSearchMemTextBox.Text = null;
            }
            else if (project.Project_Completed == 1)
            {
                validations.ShowAlert("Project is completed so further member cannot be added");
                proMSearchMemTextBox.Text = null;
            }
            else if (pG.FillMemberList().Rows.Count >= pG.MembersCount)
            {
                validations.ShowAlert("Maximum group member reached");
                proMSearchMemTextBox.Text = null;
            }
            else
            {
                pMember.SaveGroupInfo(pG.PGroup_ID);
                pMember.SaveProjectInfo(project.Project_ID);
                DialogResult r = validations.ShowInfo("Member added sucessfully");
                if (r == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
