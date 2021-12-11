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
    //deligate signature to update infromation from all
    //the project tables
    public delegate bool UpdateProjectTables(string pTitle, string pDesc, DateTime sDate, DateTime eDate,
        int status);
    public partial class UpdateProjectInfo : Form
    {
        ProjectManager pM;
        Project project = new Project();
        ProjectGroup pG = new ProjectGroup();
        ProjectTask pT = new ProjectTask();
        Validations validations = new Validations();
        BackLog backLog = new BackLog();
        ProjectMember pMember = new ProjectMember();
        public UpdateProjectInfo()
        {
            InitializeComponent();
        }
        public UpdateProjectInfo(ProjectManager pM)
        {
            InitializeComponent();
            this.pM = pM;
        }
        void ShowPreviousMenu()
        {
            //Goes to the previous control
            var form = (updatePManagerInfo)Tag;
            form.IntializeForm();
            form.Show();
        }
        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            ShowPreviousMenu();
            this.Close();
        }
        private void ResetFormData()
        {
            projectTitleTxtBox.Text = null;
            projectDescTextBox.Text = null;
            startDatepicker.Value = DateTime.Today.Date;
            endDatePicker.Value = DateTime.Today.Date;
            pNotCompletedRadioBtn.Checked = true;
            currentProjectTaskGridView.DataSource = null;
            updateTaskInfoBtn.Enabled = false;
            removeTaskBtn.Enabled = false;
            projectTitleTxtBox.Enabled = false;
            projectDescTextBox.Enabled = false;
            startDatepicker.Enabled = false;
            endDatePicker.Enabled = false;
            pCompletedRadioBtn.Enabled = false;
            pNotCompletedRadioBtn.Enabled = false;
            UpdateBtn.Enabled = false;
        }
        private void UpdateProjectInfo_Load(object sender, EventArgs e)
        {
            ResetFormData();
            currentPManagerGroupsComboBox.DisplayMember = "PGroup_Name";
            currentPManagerGroupsComboBox.ValueMember = "PGroup_ID";
            currentPManagerGroupsComboBox.DataSource = pM.ProjectGroups;
            currentPManagerGroupsComboBox.SelectedIndex = -1;

        }

        private void UpdateProjectInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPreviousMenu();
        }

        private void currentPManagerGroupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentPManagerGroupsComboBox.SelectedIndex >= 0)
            {
                int g_id = (int)currentPManagerGroupsComboBox.SelectedValue;
                project = pM.GetProject(g_id);
                projectTitleTxtBox.Enabled = true;
                projectDescTextBox.Enabled = true;
                startDatepicker.Enabled = true;
                endDatePicker.Enabled = true;
                pCompletedRadioBtn.Enabled = true;
                pNotCompletedRadioBtn.Enabled = true;
                UpdateBtn.Enabled = true;
                projectTitleTxtBox.Text = project.Project_Title;
                projectDescTextBox.Text = project.Project_Desc;
                startDatepicker.Value = project.Project_StartDate;
                endDatePicker.Value = project.Project_EndDate;
                if (project.GetProjectStatus() == "Not Completed")
                {
                    pNotCompletedRadioBtn.Checked = true;
                }
                if (project.GetProjectStatus() == "Completed")
                {
                    pCompletedRadioBtn.Checked = true;
                }
                if (pT.GetTaskListFromProject(project.Project_ID) != null)
                {
                    currentProjectTaskGridView.DataSource = pT.GetTaskListFromProject(project.Project_ID).Copy();
                    removeTaskBtn.Enabled = true;
                    updateTaskInfoBtn.Enabled = true;
                }
                else
                {
                    currentProjectTaskGridView.DataSource = null;
                    removeTaskBtn.Enabled = false;
                    updateTaskInfoBtn.Enabled = false;
                }
            }
            else
            {
                ResetFormData();
            }
        }
        private bool Validations()
        {
            //verify whether text feilds are empty,
            //whether start date and end dates are correct
            //whether the project title is duplicate
            if (string.IsNullOrWhiteSpace(projectTitleTxtBox.Text.Trim())
                && string.IsNullOrWhiteSpace(projectDescTextBox.Text.Trim()))
            {
                validations.ShowAlert("Text feild cannot be empty");
                return false;
            }
            else if (validations.VerifyDates(startDatepicker.Value.Date, endDatePicker.Value.Date))
            {
                return false;
            }
            else if (projectTitleTxtBox.Text.Trim() != project.Project_Title &&
                project.CheckIfProjectExist(projectTitleTxtBox.Text.Trim()))
            {
                validations.ShowAlert("Project with same title already exists");
                return false;
            }
            return true;
        }
        private void SendTasksToBackLog()
        {
            //if a project is set to completed
            //will remove all the task information and 
            //send it to backlog
            foreach (DataGridViewRow row in currentProjectTaskGridView.Rows)
            {
                pT.Task_ID = (int)row.Cells["ID"].Value;
                pT.Task_Title = (string)row.Cells["Title"].Value;
                string status = (string)row.Cells["Status"].Value;
                pG.GetProjectGroupFromTask(pT.Task_ID);
                project.GetProjectInfoFromTask(pT.Task_ID);
                pMember.GetProjectMemberFromTask(pT.Task_ID);
                backLog.BackLog_GroupName = pG.PGroup_Name;
                backLog.BackLog_ProjectTitle = project.Project_Title;
                if (status == "Pending")
                {
                    backLog.BackLog_TaskCompleted = "None";
                }
                if (status == "Completed")
                {
                    backLog.BackLog_TaskCompleted = $"{pMember.FirstName} {pMember.LastName}";
                }
                backLog.BackLog_TaskTitle = pT.Task_Title;
                backLog.PManager_ID = pM.PManager_ID;
                backLog.InsertBackLogData();
                //RemoveTaskFromTables deligate instance created
                //and invoked here aswell
                RemoveTaskFromTables removeTask = pT.DeleteFromAssignTaskTable;
                removeTask += pT.DeleteFromPerformTaskTable;
                removeTask += pT.DeleteFromTaskTable;
                removeTask();
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Validations())
            {
                if (!pCompletedRadioBtn.Checked)
                {
                    //UpdateProjectTables deligate instance created
                    UpdateProjectTables updateProject = project.UpdateProjectTable;
                    updateProject += project.UpdateManageProjectTable;
                    if (updateProject(projectTitleTxtBox.Text.Trim(), projectDescTextBox.Text.Trim(),
                        startDatepicker.Value.Date, endDatePicker.Value.Date, 2))
                    {
                        DialogResult r = validations.ShowInfo("Updated Sucessfully");
                        if (r == DialogResult.OK)
                        {
                            ResetFormData();
                            currentPManagerGroupsComboBox.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    //if tasks under this project is still pending
                    if (project.GetCurrentTaskCountForProject())
                    {
                        DialogResult r = MessageBox.Show("Some task under this project hasn't been completed. If you set this project as complete those task data will be lost.Continue ?"
                            , "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            SendTasksToBackLog();
                            UpdateProjectTables updateProject = project.UpdateProjectTable;
                            updateProject += project.UpdateManageProjectTable;
                            if (updateProject(projectTitleTxtBox.Text.Trim(), projectDescTextBox.Text.Trim(),
                                startDatepicker.Value.Date, endDatePicker.Value.Date, 1))
                            {
                                DialogResult result = validations.ShowInfo("Updated Sucessfully");
                                if (result == DialogResult.OK)
                                {
                                    ResetFormData();
                                    currentPManagerGroupsComboBox.SelectedIndex = -1;
                                }
                            }
                        }
                    }
                    else
                    {
                        //if all tasks under this project are completed
                        DialogResult r = MessageBox.Show("Confirm Project Completed ?"
                            , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            SendTasksToBackLog();
                            UpdateProjectTables updateProject = project.UpdateProjectTable;
                            updateProject += project.UpdateManageProjectTable;
                            if (updateProject(projectTitleTxtBox.Text.Trim(), projectDescTextBox.Text.Trim(),
                                startDatepicker.Value.Date, endDatePicker.Value.Date, 1))
                            {
                                DialogResult result = validations.ShowInfo("Updated Sucessfully");
                                if (result == DialogResult.OK)
                                {
                                    ResetFormData();
                                    currentPManagerGroupsComboBox.SelectedIndex = -1;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void updateTaskInfoBtn_Click(object sender, EventArgs e)
        {

            if (currentProjectTaskGridView.Rows.Count > 0)
            {
                DataGridViewRow row = currentProjectTaskGridView.SelectedRows[0];
                pT.Task_ID = (int)row.Cells["ID"].Value;
                pT.Task_Title = (string)row.Cells["Title"].Value;
                pT.Task_Desc = (string)row.Cells["Description"].Value;
                UpdateTaskInfo updateTaskInfo = new UpdateTaskInfo(pT);

                if (updateTaskInfo.ShowDialog() == DialogResult.Cancel)
                {

                    if (pT.GetTaskListFromProject(project.Project_ID) != null)
                    {
                        currentProjectTaskGridView.DataSource = pT.GetTaskListFromProject(project.Project_ID).Copy();
                        currentProjectTaskGridView.Update();
                        currentProjectTaskGridView.Refresh();
                    }
                    else
                    {
                        currentProjectTaskGridView.DataSource = null;
                    }

                }
            }
            else
            {
                validations.ShowAlert("Select a task to update");
            }
        }

        private void removeTaskBtn_Click(object sender, EventArgs e)
        {
            if (currentProjectTaskGridView.Rows.Count > 0)
            {
                DataGridViewRow row = currentProjectTaskGridView.SelectedRows[0];
                pT.Task_ID = (int)row.Cells["ID"].Value;
                pT.Task_Title = (string)row.Cells["Title"].Value;
                pT.Task_Desc = (string)row.Cells["Description"].Value;
                DialogResult r = MessageBox.Show("Confirm Remove ?.Changes at this task will not be recorded.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    //RemoveTaskFromTables deligate instance created
                    //and invoked here aswell
                    RemoveTaskFromTables removeTask = pT.DeleteFromAssignTaskTable;
                    removeTask += pT.DeleteFromPerformTaskTable;
                    removeTask += pT.DeleteFromTaskTable;
                    if (removeTask())
                    {
                        DialogResult result = validations.ShowInfo("Task removed");
                        if (result == DialogResult.OK)
                        {
                            if (pT.GetTaskListFromProject(project.Project_ID) != null)
                            {
                                currentProjectTaskGridView.DataSource = pT.GetTaskListFromProject(project.Project_ID).Copy();
                                currentProjectTaskGridView.Update();
                                currentProjectTaskGridView.Refresh();
                            }
                            else
                            {
                                currentProjectTaskGridView.DataSource = null;
                            }


                        }
                    }
                }
            }
        }
    }
}
