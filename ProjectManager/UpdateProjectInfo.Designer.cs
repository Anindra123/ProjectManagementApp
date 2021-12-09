
namespace ProjectManagement
{
    partial class UpdateProjectInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProjectInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.projectTitleTxtBox = new System.Windows.Forms.TextBox();
            this.startDatepicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.projectDescTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pCompletedRadioBtn = new System.Windows.Forms.RadioButton();
            this.pNotCompletedRadioBtn = new System.Windows.Forms.RadioButton();
            this.currentProjectTaskGridView = new System.Windows.Forms.DataGridView();
            this.updateTaskInfoBtn = new System.Windows.Forms.Button();
            this.removeTaskBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currentPManagerGroupsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.currentProjectTaskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date :";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(66, 646);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(133, 60);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GoBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackBtn.Location = new System.Drawing.Point(403, 646);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(133, 60);
            this.GoBackBtn.TabIndex = 5;
            this.GoBackBtn.Text = "Go Back";
            this.GoBackBtn.UseVisualStyleBackColor = false;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // projectTitleTxtBox
            // 
            this.projectTitleTxtBox.Location = new System.Drawing.Point(148, 85);
            this.projectTitleTxtBox.Name = "projectTitleTxtBox";
            this.projectTitleTxtBox.Size = new System.Drawing.Size(388, 27);
            this.projectTitleTxtBox.TabIndex = 6;
            // 
            // startDatepicker
            // 
            this.startDatepicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatepicker.Location = new System.Drawing.Point(148, 271);
            this.startDatepicker.Name = "startDatepicker";
            this.startDatepicker.Size = new System.Drawing.Size(200, 27);
            this.startDatepicker.TabIndex = 8;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(148, 329);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 27);
            this.endDatePicker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Project Description :";
            // 
            // projectDescTextBox
            // 
            this.projectDescTextBox.Location = new System.Drawing.Point(40, 160);
            this.projectDescTextBox.Multiline = true;
            this.projectDescTextBox.Name = "projectDescTextBox";
            this.projectDescTextBox.Size = new System.Drawing.Size(536, 78);
            this.projectDescTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Completed :";
            // 
            // pCompletedRadioBtn
            // 
            this.pCompletedRadioBtn.AutoSize = true;
            this.pCompletedRadioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pCompletedRadioBtn.Location = new System.Drawing.Point(148, 400);
            this.pCompletedRadioBtn.Name = "pCompletedRadioBtn";
            this.pCompletedRadioBtn.Size = new System.Drawing.Size(51, 24);
            this.pCompletedRadioBtn.TabIndex = 13;
            this.pCompletedRadioBtn.TabStop = true;
            this.pCompletedRadioBtn.Text = "Yes";
            this.pCompletedRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pNotCompletedRadioBtn
            // 
            this.pNotCompletedRadioBtn.AutoSize = true;
            this.pNotCompletedRadioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pNotCompletedRadioBtn.Location = new System.Drawing.Point(269, 400);
            this.pNotCompletedRadioBtn.Name = "pNotCompletedRadioBtn";
            this.pNotCompletedRadioBtn.Size = new System.Drawing.Size(50, 24);
            this.pNotCompletedRadioBtn.TabIndex = 14;
            this.pNotCompletedRadioBtn.TabStop = true;
            this.pNotCompletedRadioBtn.Text = "No";
            this.pNotCompletedRadioBtn.UseVisualStyleBackColor = true;
            // 
            // currentProjectTaskGridView
            // 
            this.currentProjectTaskGridView.AllowUserToAddRows = false;
            this.currentProjectTaskGridView.AllowUserToDeleteRows = false;
            this.currentProjectTaskGridView.AllowUserToResizeColumns = false;
            this.currentProjectTaskGridView.AllowUserToResizeRows = false;
            this.currentProjectTaskGridView.ColumnHeadersHeight = 29;
            this.currentProjectTaskGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentProjectTaskGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.currentProjectTaskGridView.Location = new System.Drawing.Point(40, 473);
            this.currentProjectTaskGridView.Name = "currentProjectTaskGridView";
            this.currentProjectTaskGridView.ReadOnly = true;
            this.currentProjectTaskGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.currentProjectTaskGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.currentProjectTaskGridView.RowTemplate.Height = 24;
            this.currentProjectTaskGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currentProjectTaskGridView.Size = new System.Drawing.Size(308, 150);
            this.currentProjectTaskGridView.TabIndex = 15;
            // 
            // updateTaskInfoBtn
            // 
            this.updateTaskInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateTaskInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateTaskInfoBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTaskInfoBtn.Location = new System.Drawing.Point(432, 483);
            this.updateTaskInfoBtn.Name = "updateTaskInfoBtn";
            this.updateTaskInfoBtn.Size = new System.Drawing.Size(118, 48);
            this.updateTaskInfoBtn.TabIndex = 16;
            this.updateTaskInfoBtn.Text = "Update Task Info";
            this.updateTaskInfoBtn.UseVisualStyleBackColor = false;
            this.updateTaskInfoBtn.Click += new System.EventHandler(this.updateTaskInfoBtn_Click);
            // 
            // removeTaskBtn
            // 
            this.removeTaskBtn.BackColor = System.Drawing.Color.Red;
            this.removeTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTaskBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTaskBtn.Location = new System.Drawing.Point(432, 558);
            this.removeTaskBtn.Name = "removeTaskBtn";
            this.removeTaskBtn.Size = new System.Drawing.Size(118, 45);
            this.removeTaskBtn.TabIndex = 17;
            this.removeTaskBtn.Text = "Remove Task";
            this.removeTaskBtn.UseVisualStyleBackColor = false;
            this.removeTaskBtn.Click += new System.EventHandler(this.removeTaskBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Current Project Tasks :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Select Group :";
            // 
            // currentPManagerGroupsComboBox
            // 
            this.currentPManagerGroupsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentPManagerGroupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentPManagerGroupsComboBox.FormattingEnabled = true;
            this.currentPManagerGroupsComboBox.Location = new System.Drawing.Point(40, 44);
            this.currentPManagerGroupsComboBox.Name = "currentPManagerGroupsComboBox";
            this.currentPManagerGroupsComboBox.Size = new System.Drawing.Size(523, 28);
            this.currentPManagerGroupsComboBox.TabIndex = 26;
            this.currentPManagerGroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.currentPManagerGroupsComboBox_SelectedIndexChanged);
            // 
            // UpdateProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(609, 731);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.currentPManagerGroupsComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.removeTaskBtn);
            this.Controls.Add(this.updateTaskInfoBtn);
            this.Controls.Add(this.currentProjectTaskGridView);
            this.Controls.Add(this.pNotCompletedRadioBtn);
            this.Controls.Add(this.pCompletedRadioBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.projectDescTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatepicker);
            this.Controls.Add(this.projectTitleTxtBox);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UpdateProjectInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Project Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateProjectInfo_FormClosed);
            this.Load += new System.EventHandler(this.UpdateProjectInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentProjectTaskGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.TextBox projectTitleTxtBox;
        private System.Windows.Forms.DateTimePicker startDatepicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox projectDescTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton pCompletedRadioBtn;
        private System.Windows.Forms.RadioButton pNotCompletedRadioBtn;
        private System.Windows.Forms.DataGridView currentProjectTaskGridView;
        private System.Windows.Forms.Button updateTaskInfoBtn;
        private System.Windows.Forms.Button removeTaskBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox currentPManagerGroupsComboBox;
    }
}