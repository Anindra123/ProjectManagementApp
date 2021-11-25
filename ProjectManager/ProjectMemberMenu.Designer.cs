﻿
namespace ProjectManagement
{
    partial class ProjectMemberMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMemberMenu));
            this.displayMemberTitleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.projectLeaderNameLabel = new System.Windows.Forms.Label();
            this.projectTitleLabel = new System.Windows.Forms.Label();
            this.projectGroupNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskInfo = new System.Windows.Forms.GroupBox();
            this.removeTaskCompletedBtn = new System.Windows.Forms.Button();
            this.taskCompletedBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.completedTasksListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assignedTasksListBox = new System.Windows.Forms.ListBox();
            this.updateTaskInfoBtn = new System.Windows.Forms.Button();
            this.viewGroupInfoBtn = new System.Windows.Forms.Button();
            this.joinProjectGroupBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.TaskInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayMemberTitleLabel
            // 
            this.displayMemberTitleLabel.AutoSize = true;
            this.displayMemberTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMemberTitleLabel.ForeColor = System.Drawing.Color.White;
            this.displayMemberTitleLabel.Location = new System.Drawing.Point(34, 26);
            this.displayMemberTitleLabel.Name = "displayMemberTitleLabel";
            this.displayMemberTitleLabel.Size = new System.Drawing.Size(291, 38);
            this.displayMemberTitleLabel.TabIndex = 0;
            this.displayMemberTitleLabel.Text = "Hello, MemberName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.projectLeaderNameLabel);
            this.groupBox1.Controls.Add(this.projectTitleLabel);
            this.groupBox1.Controls.Add(this.projectGroupNameLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(41, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Info";
            // 
            // projectLeaderNameLabel
            // 
            this.projectLeaderNameLabel.AutoSize = true;
            this.projectLeaderNameLabel.Location = new System.Drawing.Point(157, 129);
            this.projectLeaderNameLabel.Name = "projectLeaderNameLabel";
            this.projectLeaderNameLabel.Size = new System.Drawing.Size(45, 20);
            this.projectLeaderNameLabel.TabIndex = 6;
            this.projectLeaderNameLabel.Text = "none";
            // 
            // projectTitleLabel
            // 
            this.projectTitleLabel.AutoSize = true;
            this.projectTitleLabel.Location = new System.Drawing.Point(137, 99);
            this.projectTitleLabel.Name = "projectTitleLabel";
            this.projectTitleLabel.Size = new System.Drawing.Size(45, 20);
            this.projectTitleLabel.TabIndex = 5;
            this.projectTitleLabel.Text = "none";
            // 
            // projectGroupNameLabel
            // 
            this.projectGroupNameLabel.AutoSize = true;
            this.projectGroupNameLabel.Location = new System.Drawing.Point(201, 69);
            this.projectGroupNameLabel.Name = "projectGroupNameLabel";
            this.projectGroupNameLabel.Size = new System.Drawing.Size(45, 20);
            this.projectGroupNameLabel.TabIndex = 4;
            this.projectGroupNameLabel.Text = "none";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Project Group Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Leader :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Title :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currently working for :";
            // 
            // TaskInfo
            // 
            this.TaskInfo.Controls.Add(this.removeTaskCompletedBtn);
            this.TaskInfo.Controls.Add(this.taskCompletedBtn);
            this.TaskInfo.Controls.Add(this.label6);
            this.TaskInfo.Controls.Add(this.completedTasksListBox);
            this.TaskInfo.Controls.Add(this.label5);
            this.TaskInfo.Controls.Add(this.assignedTasksListBox);
            this.TaskInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskInfo.ForeColor = System.Drawing.Color.White;
            this.TaskInfo.Location = new System.Drawing.Point(41, 286);
            this.TaskInfo.Name = "TaskInfo";
            this.TaskInfo.Size = new System.Drawing.Size(830, 384);
            this.TaskInfo.TabIndex = 2;
            this.TaskInfo.TabStop = false;
            this.TaskInfo.Text = "TaskInfo";
            // 
            // removeTaskCompletedBtn
            // 
            this.removeTaskCompletedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.removeTaskCompletedBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTaskCompletedBtn.ForeColor = System.Drawing.Color.White;
            this.removeTaskCompletedBtn.Location = new System.Drawing.Point(511, 295);
            this.removeTaskCompletedBtn.Name = "removeTaskCompletedBtn";
            this.removeTaskCompletedBtn.Size = new System.Drawing.Size(193, 63);
            this.removeTaskCompletedBtn.TabIndex = 5;
            this.removeTaskCompletedBtn.Text = "Remove Task Completed";
            this.removeTaskCompletedBtn.UseVisualStyleBackColor = false;
            // 
            // taskCompletedBtn
            // 
            this.taskCompletedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.taskCompletedBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskCompletedBtn.ForeColor = System.Drawing.Color.White;
            this.taskCompletedBtn.Location = new System.Drawing.Point(110, 301);
            this.taskCompletedBtn.Name = "taskCompletedBtn";
            this.taskCompletedBtn.Size = new System.Drawing.Size(174, 57);
            this.taskCompletedBtn.TabIndex = 4;
            this.taskCompletedBtn.Text = "Task Completed";
            this.taskCompletedBtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Completed Tasks";
            // 
            // completedTasksListBox
            // 
            this.completedTasksListBox.FormattingEnabled = true;
            this.completedTasksListBox.ItemHeight = 23;
            this.completedTasksListBox.Location = new System.Drawing.Point(435, 60);
            this.completedTasksListBox.Name = "completedTasksListBox";
            this.completedTasksListBox.Size = new System.Drawing.Size(369, 211);
            this.completedTasksListBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Assigned Tasks";
            // 
            // assignedTasksListBox
            // 
            this.assignedTasksListBox.FormattingEnabled = true;
            this.assignedTasksListBox.ItemHeight = 23;
            this.assignedTasksListBox.Location = new System.Drawing.Point(25, 60);
            this.assignedTasksListBox.Name = "assignedTasksListBox";
            this.assignedTasksListBox.Size = new System.Drawing.Size(369, 211);
            this.assignedTasksListBox.TabIndex = 0;
            // 
            // updateTaskInfoBtn
            // 
            this.updateTaskInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateTaskInfoBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTaskInfoBtn.ForeColor = System.Drawing.Color.White;
            this.updateTaskInfoBtn.Location = new System.Drawing.Point(920, 119);
            this.updateTaskInfoBtn.Name = "updateTaskInfoBtn";
            this.updateTaskInfoBtn.Size = new System.Drawing.Size(174, 57);
            this.updateTaskInfoBtn.TabIndex = 6;
            this.updateTaskInfoBtn.Text = "Update Task Status";
            this.updateTaskInfoBtn.UseVisualStyleBackColor = false;
            // 
            // viewGroupInfoBtn
            // 
            this.viewGroupInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.viewGroupInfoBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewGroupInfoBtn.ForeColor = System.Drawing.Color.White;
            this.viewGroupInfoBtn.Location = new System.Drawing.Point(920, 198);
            this.viewGroupInfoBtn.Name = "viewGroupInfoBtn";
            this.viewGroupInfoBtn.Size = new System.Drawing.Size(174, 57);
            this.viewGroupInfoBtn.TabIndex = 7;
            this.viewGroupInfoBtn.Text = "View Group Info";
            this.viewGroupInfoBtn.UseVisualStyleBackColor = false;
            this.viewGroupInfoBtn.Click += new System.EventHandler(this.viewGroupInfoBtn_Click);
            // 
            // joinProjectGroupBtn
            // 
            this.joinProjectGroupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.joinProjectGroupBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinProjectGroupBtn.ForeColor = System.Drawing.Color.White;
            this.joinProjectGroupBtn.Location = new System.Drawing.Point(920, 274);
            this.joinProjectGroupBtn.Name = "joinProjectGroupBtn";
            this.joinProjectGroupBtn.Size = new System.Drawing.Size(174, 57);
            this.joinProjectGroupBtn.TabIndex = 9;
            this.joinProjectGroupBtn.Text = "Join Project Group";
            this.joinProjectGroupBtn.UseVisualStyleBackColor = false;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logOutBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(941, 627);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(135, 57);
            this.logOutBtn.TabIndex = 11;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(920, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "View Task Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectMemberMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1132, 709);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.joinProjectGroupBtn);
            this.Controls.Add(this.viewGroupInfoBtn);
            this.Controls.Add(this.updateTaskInfoBtn);
            this.Controls.Add(this.TaskInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displayMemberTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectMemberMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Member Dashboard";
            this.Load += new System.EventHandler(this.ProjectMemberMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TaskInfo.ResumeLayout(false);
            this.TaskInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayMemberTitleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label projectLeaderNameLabel;
        private System.Windows.Forms.Label projectTitleLabel;
        private System.Windows.Forms.Label projectGroupNameLabel;
        private System.Windows.Forms.GroupBox TaskInfo;
        private System.Windows.Forms.Button removeTaskCompletedBtn;
        private System.Windows.Forms.Button taskCompletedBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox completedTasksListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox assignedTasksListBox;
        private System.Windows.Forms.Button updateTaskInfoBtn;
        private System.Windows.Forms.Button viewGroupInfoBtn;
        private System.Windows.Forms.Button joinProjectGroupBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button button1;
    }
}