
namespace ProjectManagement
{
    partial class CreateNewGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewGroup));
            this.proMSearchMemBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.proMSearchMemTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proMGroupNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.membersAddedGridView = new System.Windows.Forms.DataGridView();
            this.membersCountTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.proMEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.proMStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.projDescTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.projectTitleTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createGroupBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.memberNameTxtBox = new System.Windows.Forms.Label();
            this.memberMailTxtBox = new System.Windows.Forms.Label();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersAddedGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // proMSearchMemBtn
            // 
            this.proMSearchMemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.proMSearchMemBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proMSearchMemBtn.Location = new System.Drawing.Point(501, 113);
            this.proMSearchMemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.proMSearchMemBtn.Name = "proMSearchMemBtn";
            this.proMSearchMemBtn.Size = new System.Drawing.Size(128, 42);
            this.proMSearchMemBtn.TabIndex = 21;
            this.proMSearchMemBtn.Text = "Search";
            this.proMSearchMemBtn.UseVisualStyleBackColor = false;
            this.proMSearchMemBtn.Click += new System.EventHandler(this.proMSearchMemBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Current Members";
            // 
            // proMSearchMemTextBox
            // 
            this.proMSearchMemTextBox.Location = new System.Drawing.Point(166, 119);
            this.proMSearchMemTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.proMSearchMemTextBox.Name = "proMSearchMemTextBox";
            this.proMSearchMemTextBox.Size = new System.Drawing.Size(321, 30);
            this.proMSearchMemTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search Members";
            // 
            // proMGroupNameTextBox
            // 
            this.proMGroupNameTextBox.Location = new System.Drawing.Point(219, 34);
            this.proMGroupNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.proMGroupNameTextBox.Name = "proMGroupNameTextBox";
            this.proMGroupNameTextBox.Size = new System.Drawing.Size(321, 30);
            this.proMGroupNameTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Group Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addMemberBtn);
            this.groupBox1.Controls.Add(this.memberMailTxtBox);
            this.groupBox1.Controls.Add(this.memberNameTxtBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.membersAddedGridView);
            this.groupBox1.Controls.Add(this.membersCountTxtBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.proMSearchMemBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.proMGroupNameTextBox);
            this.groupBox1.Controls.Add(this.proMSearchMemTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 353);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group Info";
            // 
            // membersAddedGridView
            // 
            this.membersAddedGridView.AllowUserToAddRows = false;
            this.membersAddedGridView.AllowUserToDeleteRows = false;
            this.membersAddedGridView.AllowUserToResizeColumns = false;
            this.membersAddedGridView.AllowUserToResizeRows = false;
            this.membersAddedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.membersAddedGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.membersAddedGridView.Location = new System.Drawing.Point(22, 254);
            this.membersAddedGridView.Name = "membersAddedGridView";
            this.membersAddedGridView.ReadOnly = true;
            this.membersAddedGridView.RowHeadersWidth = 51;
            this.membersAddedGridView.RowTemplate.Height = 24;
            this.membersAddedGridView.Size = new System.Drawing.Size(518, 84);
            this.membersAddedGridView.TabIndex = 22;
            // 
            // membersCountTxtBox
            // 
            this.membersCountTxtBox.Location = new System.Drawing.Point(219, 75);
            this.membersCountTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.membersCountTxtBox.Name = "membersCountTxtBox";
            this.membersCountTxtBox.Size = new System.Drawing.Size(321, 30);
            this.membersCountTxtBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Number of Member";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.proMEndDatePicker);
            this.groupBox2.Controls.Add(this.startDate);
            this.groupBox2.Controls.Add(this.proMStartDatePicker);
            this.groupBox2.Controls.Add(this.projDescTxtBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.projectTitleTxtBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(10, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 311);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "End Date";
            // 
            // proMEndDatePicker
            // 
            this.proMEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.proMEndDatePicker.Location = new System.Drawing.Point(249, 248);
            this.proMEndDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.proMEndDatePicker.Name = "proMEndDatePicker";
            this.proMEndDatePicker.Size = new System.Drawing.Size(265, 30);
            this.proMEndDatePicker.TabIndex = 29;
            this.proMEndDatePicker.Value = new System.DateTime(2021, 12, 2, 0, 0, 0, 0);
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(30, 203);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(86, 23);
            this.startDate.TabIndex = 28;
            this.startDate.Text = "Start Date";
            // 
            // proMStartDatePicker
            // 
            this.proMStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.proMStartDatePicker.Location = new System.Drawing.Point(249, 195);
            this.proMStartDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.proMStartDatePicker.Name = "proMStartDatePicker";
            this.proMStartDatePicker.Size = new System.Drawing.Size(265, 30);
            this.proMStartDatePicker.TabIndex = 27;
            // 
            // projDescTxtBox
            // 
            this.projDescTxtBox.Location = new System.Drawing.Point(28, 107);
            this.projDescTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.projDescTxtBox.Multiline = true;
            this.projDescTxtBox.Name = "projDescTxtBox";
            this.projDescTxtBox.Size = new System.Drawing.Size(601, 70);
            this.projDescTxtBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Project Description";
            // 
            // projectTitleTxtBox
            // 
            this.projectTitleTxtBox.Location = new System.Drawing.Point(219, 35);
            this.projectTitleTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.projectTitleTxtBox.Name = "projectTitleTxtBox";
            this.projectTitleTxtBox.Size = new System.Drawing.Size(321, 30);
            this.projectTitleTxtBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Project Title";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(409, 705);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(151, 60);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // createGroupBtn
            // 
            this.createGroupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.createGroupBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGroupBtn.ForeColor = System.Drawing.Color.White;
            this.createGroupBtn.Location = new System.Drawing.Point(73, 705);
            this.createGroupBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createGroupBtn.Name = "createGroupBtn";
            this.createGroupBtn.Size = new System.Drawing.Size(151, 60);
            this.createGroupBtn.TabIndex = 24;
            this.createGroupBtn.Text = "Create Group";
            this.createGroupBtn.UseVisualStyleBackColor = false;
            this.createGroupBtn.Click += new System.EventHandler(this.createGroupBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Member Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 195);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Member Mail :";
            // 
            // memberNameTxtBox
            // 
            this.memberNameTxtBox.AutoSize = true;
            this.memberNameTxtBox.Location = new System.Drawing.Point(177, 164);
            this.memberNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberNameTxtBox.Name = "memberNameTxtBox";
            this.memberNameTxtBox.Size = new System.Drawing.Size(49, 23);
            this.memberNameTxtBox.TabIndex = 25;
            this.memberNameTxtBox.Text = "none";
            // 
            // memberMailTxtBox
            // 
            this.memberMailTxtBox.AutoSize = true;
            this.memberMailTxtBox.Location = new System.Drawing.Point(177, 195);
            this.memberMailTxtBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberMailTxtBox.Name = "memberMailTxtBox";
            this.memberMailTxtBox.Size = new System.Drawing.Size(49, 23);
            this.memberMailTxtBox.TabIndex = 26;
            this.memberMailTxtBox.Text = "none";
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addMemberBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberBtn.Location = new System.Drawing.Point(399, 176);
            this.addMemberBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(98, 42);
            this.addMemberBtn.TabIndex = 27;
            this.addMemberBtn.Text = "Add";
            this.addMemberBtn.UseVisualStyleBackColor = false;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
            // 
            // CreateNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(671, 778);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createGroupBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateNewGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Group";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateNewGroup_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersAddedGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button proMSearchMemBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox proMSearchMemTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox proMGroupNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView membersAddedGridView;
        private System.Windows.Forms.TextBox membersCountTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox projDescTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectTitleTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker proMEndDatePicker;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.DateTimePicker proMStartDatePicker;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createGroupBtn;
        private System.Windows.Forms.Button addMemberBtn;
        private System.Windows.Forms.Label memberMailTxtBox;
        private System.Windows.Forms.Label memberNameTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}