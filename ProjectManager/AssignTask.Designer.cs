
namespace ProjectManagement
{
    partial class AssignTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignTask));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AssignTaskBtn = new System.Windows.Forms.Button();
            this.SBtn = new System.Windows.Forms.Button();
            this.selectMemberComboBox = new System.Windows.Forms.ComboBox();
            this.TaskTitleLabel = new System.Windows.Forms.Label();
            this.TaskStatusLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupNameLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.projNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Title : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assign To :";
            // 
            // AssignTaskBtn
            // 
            this.AssignTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AssignTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignTaskBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignTaskBtn.Location = new System.Drawing.Point(45, 312);
            this.AssignTaskBtn.Name = "AssignTaskBtn";
            this.AssignTaskBtn.Size = new System.Drawing.Size(146, 58);
            this.AssignTaskBtn.TabIndex = 3;
            this.AssignTaskBtn.Text = "Assign Task";
            this.AssignTaskBtn.UseVisualStyleBackColor = false;
            this.AssignTaskBtn.Click += new System.EventHandler(this.AssignTaskBtn_Click);
            // 
            // SBtn
            // 
            this.SBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBtn.Location = new System.Drawing.Point(360, 312);
            this.SBtn.Name = "SBtn";
            this.SBtn.Size = new System.Drawing.Size(146, 58);
            this.SBtn.TabIndex = 4;
            this.SBtn.Text = "Cancel";
            this.SBtn.UseVisualStyleBackColor = false;
            this.SBtn.Click += new System.EventHandler(this.SBtn_Click);
            // 
            // selectMemberComboBox
            // 
            this.selectMemberComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectMemberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectMemberComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMemberComboBox.FormattingEnabled = true;
            this.selectMemberComboBox.Location = new System.Drawing.Point(159, 224);
            this.selectMemberComboBox.Name = "selectMemberComboBox";
            this.selectMemberComboBox.Size = new System.Drawing.Size(261, 31);
            this.selectMemberComboBox.TabIndex = 5;
            // 
            // TaskTitleLabel
            // 
            this.TaskTitleLabel.AutoSize = true;
            this.TaskTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskTitleLabel.Location = new System.Drawing.Point(168, 118);
            this.TaskTitleLabel.Name = "TaskTitleLabel";
            this.TaskTitleLabel.Size = new System.Drawing.Size(49, 23);
            this.TaskTitleLabel.TabIndex = 7;
            this.TaskTitleLabel.Text = "none";
            // 
            // TaskStatusLbl
            // 
            this.TaskStatusLbl.AutoSize = true;
            this.TaskStatusLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskStatusLbl.Location = new System.Drawing.Point(168, 173);
            this.TaskStatusLbl.Name = "TaskStatusLbl";
            this.TaskStatusLbl.Size = new System.Drawing.Size(49, 23);
            this.TaskStatusLbl.TabIndex = 8;
            this.TaskStatusLbl.Text = "none";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Group Name : ";
            // 
            // groupNameLbl
            // 
            this.groupNameLbl.AutoSize = true;
            this.groupNameLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLbl.Location = new System.Drawing.Point(168, 25);
            this.groupNameLbl.Name = "groupNameLbl";
            this.groupNameLbl.Size = new System.Drawing.Size(49, 23);
            this.groupNameLbl.TabIndex = 10;
            this.groupNameLbl.Text = "none";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Project Title: ";
            // 
            // projNameLbl
            // 
            this.projNameLbl.AutoSize = true;
            this.projNameLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projNameLbl.Location = new System.Drawing.Point(168, 70);
            this.projNameLbl.Name = "projNameLbl";
            this.projNameLbl.Size = new System.Drawing.Size(49, 23);
            this.projNameLbl.TabIndex = 12;
            this.projNameLbl.Text = "none";
            // 
            // AssignTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(585, 405);
            this.Controls.Add(this.projNameLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupNameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TaskStatusLbl);
            this.Controls.Add(this.TaskTitleLabel);
            this.Controls.Add(this.selectMemberComboBox);
            this.Controls.Add(this.SBtn);
            this.Controls.Add(this.AssignTaskBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AssignTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Task";
            this.Load += new System.EventHandler(this.AssignTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AssignTaskBtn;
        private System.Windows.Forms.Button SBtn;
        private System.Windows.Forms.ComboBox selectMemberComboBox;
        private System.Windows.Forms.Label TaskTitleLabel;
        private System.Windows.Forms.Label TaskStatusLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label groupNameLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label projNameLbl;
    }
}