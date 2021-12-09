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
    public partial class AddNewFeature : System.Windows.Forms.Form
    {
        ProjectManager pM;
        int memberID;
        ProjectMember pMem = new ProjectMember();
        Project project;
        ProjectGroup pG = new ProjectGroup();
        Validations validations = new Validations();
        public AddNewFeature()
        {
            InitializeComponent();
        }
        public AddNewFeature(ProjectManager pM)
        {
            InitializeComponent();
            this.pM = pM;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddNewFeature_Load(object sender, EventArgs e)
        {
            groupsComboBox.DisplayMember = "PGroup_Name";
            groupsComboBox.ValueMember = "PGroup_ID";
            groupsComboBox.DataSource = pM.ProjectGroups;
            groupsComboBox.SelectedIndex = -1;
            assignToComboBox.DataSource = null;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text.Trim()))
            {

                validations.ShowAlert("Text feilds cannot be empty");
            }
            else if (groupsComboBox.SelectedIndex < 0)
            {
                validations.ShowAlert("A group must be selected");
            }
            else if (assignToComboBox.SelectedIndex < 0 && assignSelectionYesRadioBtn.Checked)
            {
                validations.ShowAlert("Must select a member");
            }
            else if (pM.CheckTaskExist(titleTextBox.Text.Trim()))
            {
                validations.ShowAlert("A task with the same title already exists.");
            }
            else if (project.Project_Completed == 1)
            {
                validations.ShowAlert("Cannot add task to this project as it is completed");
            }
            else
            {
                string tTitle = titleTextBox.Text.Trim();
                string tDesc = taskDescriptionTextBox.Text.Trim();
                if (project != null)
                {

                    if (pM.CreateTask(tTitle, tDesc, project.Project_ID)
                           && pM.AssignTask(tTitle, tDesc, pM.PManager_ID))
                    {
                        if (assignSelectionYesRadioBtn.Checked == false)
                        {
                            pM.AssignTaskToMember(tTitle, tDesc, -1);
                            DialogResult result = MessageBox.Show("Task Created Sucessfully", "Sucess",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            if (pMem.CheckifGroupMember(memberID, pG.PGroup_ID))
                            {
                                pM.AssignTaskToMember(tTitle, tDesc, pMem.PMemberID);
                                DialogResult result = MessageBox.Show("Task Created Sucessfully", "Sucess",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (result == DialogResult.OK)
                                {
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void assignSelectionNoRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void assignSelectionYesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (assignSelectionYesRadioBtn.Checked)
            {
                assignToComboBox.Enabled = true;


            }
            else
            {
                assignToComboBox.Enabled = false;
            }

        }

        private void groupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupsComboBox.SelectedIndex >= 0 && groupsComboBox.SelectedItem != null)
            {
                int g_id = (int)groupsComboBox.SelectedValue;
                pG.PGroup_ID = g_id;
                project = pM.GetProject(g_id);
                projectTitleLbl.Text = project.Project_Title;
                assignToComboBox.DisplayMember = "Name";
                assignToComboBox.ValueMember = "PMember_ID";
                assignToComboBox.DataSource = pG.FillMemberList(g_id);
                assignToComboBox.SelectedIndex = -1;
            }
            else
            {
                projectTitleLbl.Text = null;
            }
        }

        private void assignToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (assignToComboBox.SelectedIndex >= 0)
            {
                memberID = (int)assignToComboBox.SelectedValue;
            }
        }
    }
}
