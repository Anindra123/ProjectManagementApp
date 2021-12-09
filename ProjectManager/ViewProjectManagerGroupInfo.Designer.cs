
namespace ProjectManagement
{
    partial class ViewProjectManagerGroupInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProjectManagerGroupInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noOfMemberLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentPManagerGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.currentMembersGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentActiveTaskDataGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.endDateLabl = new System.Windows.Forms.Label();
            this.startDateLabl = new System.Windows.Forms.Label();
            this.projStatusLabl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.projDescLabel = new System.Windows.Forms.Label();
            this.projectTitleLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labe11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentMembersGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentActiveTaskDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noOfMemberLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.currentPManagerGroupsComboBox);
            this.groupBox1.Controls.Add(this.groupNameLabel);
            this.groupBox1.Controls.Add(this.currentMembersGridView);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 283);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group Info";
            // 
            // noOfMemberLbl
            // 
            this.noOfMemberLbl.AutoSize = true;
            this.noOfMemberLbl.Location = new System.Drawing.Point(215, 125);
            this.noOfMemberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noOfMemberLbl.Name = "noOfMemberLbl";
            this.noOfMemberLbl.Size = new System.Drawing.Size(49, 23);
            this.noOfMemberLbl.TabIndex = 26;
            this.noOfMemberLbl.Text = "none";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Select Group :";
            // 
            // currentPManagerGroupsComboBox
            // 
            this.currentPManagerGroupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentPManagerGroupsComboBox.FormattingEnabled = true;
            this.currentPManagerGroupsComboBox.Location = new System.Drawing.Point(31, 52);
            this.currentPManagerGroupsComboBox.Name = "currentPManagerGroupsComboBox";
            this.currentPManagerGroupsComboBox.Size = new System.Drawing.Size(523, 31);
            this.currentPManagerGroupsComboBox.TabIndex = 24;
            this.currentPManagerGroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.currentPManagerGroupsComboBox_SelectedIndexChanged);
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Location = new System.Drawing.Point(149, 95);
            this.groupNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(49, 23);
            this.groupNameLabel.TabIndex = 23;
            this.groupNameLabel.Text = "none";
            // 
            // currentMembersGridView
            // 
            this.currentMembersGridView.AllowUserToAddRows = false;
            this.currentMembersGridView.AllowUserToDeleteRows = false;
            this.currentMembersGridView.AllowUserToResizeColumns = false;
            this.currentMembersGridView.AllowUserToResizeRows = false;
            this.currentMembersGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentMembersGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.currentMembersGridView.Location = new System.Drawing.Point(36, 181);
            this.currentMembersGridView.Name = "currentMembersGridView";
            this.currentMembersGridView.ReadOnly = true;
            this.currentMembersGridView.RowHeadersWidth = 51;
            this.currentMembersGridView.RowTemplate.Height = 24;
            this.currentMembersGridView.Size = new System.Drawing.Size(518, 84);
            this.currentMembersGridView.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Current Members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Number of Member :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Group Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.currentActiveTaskDataGridView);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.endDateLabl);
            this.groupBox2.Controls.Add(this.startDateLabl);
            this.groupBox2.Controls.Add(this.projStatusLabl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.projDescLabel);
            this.groupBox2.Controls.Add(this.projectTitleLbl);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.labe11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 393);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Info";
            // 
            // currentActiveTaskDataGridView
            // 
            this.currentActiveTaskDataGridView.AllowUserToAddRows = false;
            this.currentActiveTaskDataGridView.AllowUserToDeleteRows = false;
            this.currentActiveTaskDataGridView.AllowUserToResizeColumns = false;
            this.currentActiveTaskDataGridView.AllowUserToResizeRows = false;
            this.currentActiveTaskDataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentActiveTaskDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.currentActiveTaskDataGridView.Location = new System.Drawing.Point(29, 262);
            this.currentActiveTaskDataGridView.Name = "currentActiveTaskDataGridView";
            this.currentActiveTaskDataGridView.ReadOnly = true;
            this.currentActiveTaskDataGridView.RowHeadersWidth = 51;
            this.currentActiveTaskDataGridView.RowTemplate.Height = 24;
            this.currentActiveTaskDataGridView.Size = new System.Drawing.Size(620, 119);
            this.currentActiveTaskDataGridView.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(29, 240);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "Current Active Task";
            // 
            // endDateLabl
            // 
            this.endDateLabl.AutoSize = true;
            this.endDateLabl.Location = new System.Drawing.Point(129, 208);
            this.endDateLabl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLabl.Name = "endDateLabl";
            this.endDateLabl.Size = new System.Drawing.Size(49, 23);
            this.endDateLabl.TabIndex = 36;
            this.endDateLabl.Text = "none";
            // 
            // startDateLabl
            // 
            this.startDateLabl.AutoSize = true;
            this.startDateLabl.Location = new System.Drawing.Point(129, 174);
            this.startDateLabl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLabl.Name = "startDateLabl";
            this.startDateLabl.Size = new System.Drawing.Size(49, 23);
            this.startDateLabl.TabIndex = 35;
            this.startDateLabl.Text = "none";
            // 
            // projStatusLabl
            // 
            this.projStatusLabl.AutoSize = true;
            this.projStatusLabl.Location = new System.Drawing.Point(157, 138);
            this.projStatusLabl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projStatusLabl.Name = "projStatusLabl";
            this.projStatusLabl.Size = new System.Drawing.Size(49, 23);
            this.projStatusLabl.TabIndex = 34;
            this.projStatusLabl.Text = "none";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Project Status :";
            // 
            // projDescLabel
            // 
            this.projDescLabel.AutoSize = true;
            this.projDescLabel.Location = new System.Drawing.Point(31, 99);
            this.projDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projDescLabel.Name = "projDescLabel";
            this.projDescLabel.Size = new System.Drawing.Size(49, 23);
            this.projDescLabel.TabIndex = 32;
            this.projDescLabel.Text = "none";
            // 
            // projectTitleLbl
            // 
            this.projectTitleLbl.AutoSize = true;
            this.projectTitleLbl.Location = new System.Drawing.Point(156, 28);
            this.projectTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectTitleLbl.Name = "projectTitleLbl";
            this.projectTitleLbl.Size = new System.Drawing.Size(49, 23);
            this.projectTitleLbl.TabIndex = 31;
            this.projectTitleLbl.Text = "none";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 208);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "End Date :";
            // 
            // labe11
            // 
            this.labe11.AutoSize = true;
            this.labe11.Location = new System.Drawing.Point(26, 174);
            this.labe11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labe11.Name = "labe11";
            this.labe11.Size = new System.Drawing.Size(95, 23);
            this.labe11.TabIndex = 28;
            this.labe11.Text = "Start Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Project Description :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Project Title :";
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.goBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.ForeColor = System.Drawing.Color.White;
            this.goBackBtn.Location = new System.Drawing.Point(545, 715);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(116, 53);
            this.goBackBtn.TabIndex = 25;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = false;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // ViewProjectManagerGroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(704, 780);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewProjectManagerGroupInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewProjectManagerGroupInfo_FormClosed);
            this.Load += new System.EventHandler(this.ViewProjectManagerGroupInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentMembersGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentActiveTaskDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView currentMembersGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox currentPManagerGroupsComboBox;
        private System.Windows.Forms.Label noOfMemberLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView currentActiveTaskDataGridView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label endDateLabl;
        private System.Windows.Forms.Label startDateLabl;
        private System.Windows.Forms.Label projStatusLabl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label projDescLabel;
        private System.Windows.Forms.Label projectTitleLbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labe11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button goBackBtn;
    }
}