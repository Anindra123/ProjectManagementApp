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
        ProjectTask pT = new ProjectTask();
        Validations validations = new Validations();
        bool leaveGroup = false;


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
            form.IntializeGroup(pG, project, pMang);
            form.InitializeDashBoard();
            form.Show();

        }
        private void updateCnfirmBtn_Click(object sender, EventArgs e)
        {
            string fName = projectMemberFirstNameTxtBox.Text.Trim();
            string lName = projectMemberLastNameTxtBox.Text.Trim();
            string password = projMemberPasswordTextBox.Text.Trim();
            string email = projMemberEmailTxtBox.Text.Trim();
            pM.FirstName = fName;
            pM.LastName = lName;
            pM.Email = email;
            pM.password = password;
            //since it is updating , true is passed on the method 
            //paramenter
            if (validations.SignUpAndUpdateValidation<ProjectMember>(true,
                fName, lName, email, password, pM))
            {
                //if a member has left the group whilst updating
                //his/her account info
                //removes all assigned task when leaving a group
                if (leaveGroup == true && pM.UpdateMemberInfo())
                {
                    int pMemberID = pM.PMemberID;
                    DataTable dt = pT.CheckTaskAssingedToMember(pMemberID);
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            int t_id = (int)row["Task_ID"];
                            pM.RemoveAllAssignedTask(t_id);
                        }
                        if (pM.DeleteMemberGroupInfoTable(pMemberID)
                        && pM.DeleteMemberProjInfoTable(pMemberID)
                       )
                        {
                            MessageBox.Show("Updated Sucessfully", "Sucess",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pG = null;
                            pMang = null;
                            project = null;
                            leaveGroup = false;
                        }
                    }


                }
                else if (pM.UpdateMemberInfo())
                {

                    MessageBox.Show("Updated Sucessfully", "Sucess",
             MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error during update", "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void UpdateMemberInfo_Load(object sender, EventArgs e)
        {
            projectMemberFirstNameTxtBox.Text = pM.FirstName;
            projectMemberLastNameTxtBox.Text = pM.LastName;
            projMemberEmailTxtBox.Text = pM.Email;
            projMemberPasswordTextBox.Text = pM.password;
            if (pMang != null)
            {
                projManagerLabel.Text = $"{pMang.FirstName} {pMang.LastName}";
                groupNameLabel.Text = pG.PGroup_Name;
                projNameLabel.Text = project.Project_Title;
            }
            else
            {
                projManagerLabel.Text = "none";
                groupNameLabel.Text = "none";
                projNameLabel.Text = "none";
                leaveGroupBtn.Enabled = false;
            }

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
            DialogResult dr = MessageBox.Show("Confirm Leave you might loose project progress?", "Leave Group",
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
