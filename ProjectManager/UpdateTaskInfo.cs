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
    //deligate signature which will hold reference for updating
    //task information from all the task related tables
    public delegate bool UpdateTasks(string tTitle, string tDesc);
    public partial class UpdateTaskInfo : Form
    {
        ProjectTask pT;
        Validations validations = new Validations();
        public UpdateTaskInfo()
        {
            InitializeComponent();
        }
        public UpdateTaskInfo(ProjectTask pT)
        {
            InitializeComponent();
            this.pT = pT;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tasktitleTextBox.Text.Trim()) &&
                string.IsNullOrWhiteSpace(taskDescriptionTextBox.Text.Trim()))
            {
                validations.ShowAlert("Text feilds cannot be empty");
            }
            else if (tasktitleTextBox.Text.Trim() != pT.Task_Title && pT.CheckTaskExist(tasktitleTextBox.Text.Trim()))
            {
                validations.ShowAlert("Task with same name already exists");

            }
            else
            {
                //UpdateTasks multicasted deiligate instance created
                UpdateTasks updateTasks = pT.UpdateAssignTaskTable;
                updateTasks += pT.UpdatePerformTaskTable;
                updateTasks += pT.UpdateTaskTable;
                if (updateTasks(tasktitleTextBox.Text.Trim(), taskDescriptionTextBox.Text.Trim()))
                {
                    DialogResult r = validations.ShowInfo("Task updated sucessfully");
                    if (r == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
        }

        private void UpdateTaskInfo_Load(object sender, EventArgs e)
        {
            tasktitleTextBox.Text = pT.Task_Title;
            taskDescriptionTextBox.Text = pT.Task_Desc;
        }
    }
}
