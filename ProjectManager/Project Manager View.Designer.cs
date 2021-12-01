
namespace ProjectManagement
{
    partial class ProjectManagerView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagerView));
            this.welcomeFullNameLabel = new System.Windows.Forms.Label();
            this.mainGroupbox = new System.Windows.Forms.GroupBox();
            this.currentFeatureList2Groupbox = new System.Windows.Forms.GroupBox();
            this.sendToBacklogBtn = new System.Windows.Forms.Button();
            this.implementedFeaturesListBox = new System.Windows.Forms.ListBox();
            this.currentFeatureListGroupbox1 = new System.Windows.Forms.GroupBox();
            this.assignTaskBtn = new System.Windows.Forms.Button();
            this.addNewFeatureBtn = new System.Windows.Forms.Button();
            this.currentFeatureListbox1 = new System.Windows.Forms.ListBox();
            this.currentProjectsLabel = new System.Windows.Forms.Label();
            this.projectManagerOfLabel = new System.Windows.Forms.Label();
            this.viewProjectBacklogBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.viewProjectInfoBtn = new System.Windows.Forms.Button();
            this.updateGroupMembersBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.mainGroupbox.SuspendLayout();
            this.currentFeatureList2Groupbox.SuspendLayout();
            this.currentFeatureListGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeFullNameLabel
            // 
            this.welcomeFullNameLabel.AutoSize = true;
            this.welcomeFullNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeFullNameLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeFullNameLabel.Location = new System.Drawing.Point(13, 18);
            this.welcomeFullNameLabel.Name = "welcomeFullNameLabel";
            this.welcomeFullNameLabel.Size = new System.Drawing.Size(328, 45);
            this.welcomeFullNameLabel.TabIndex = 0;
            this.welcomeFullNameLabel.Text = "Welcome, FullName";
            // 
            // mainGroupbox
            // 
            this.mainGroupbox.Controls.Add(this.dataGridView1);
            this.mainGroupbox.Controls.Add(this.currentFeatureList2Groupbox);
            this.mainGroupbox.Controls.Add(this.currentFeatureListGroupbox1);
            this.mainGroupbox.Controls.Add(this.currentProjectsLabel);
            this.mainGroupbox.Controls.Add(this.projectManagerOfLabel);
            this.mainGroupbox.Controls.Add(this.welcomeFullNameLabel);
            this.mainGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainGroupbox.Location = new System.Drawing.Point(10, 13);
            this.mainGroupbox.Name = "mainGroupbox";
            this.mainGroupbox.Size = new System.Drawing.Size(933, 629);
            this.mainGroupbox.TabIndex = 1;
            this.mainGroupbox.TabStop = false;
            // 
            // currentFeatureList2Groupbox
            // 
            this.currentFeatureList2Groupbox.Controls.Add(this.button3);
            this.currentFeatureList2Groupbox.Controls.Add(this.sendToBacklogBtn);
            this.currentFeatureList2Groupbox.Controls.Add(this.implementedFeaturesListBox);
            this.currentFeatureList2Groupbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFeatureList2Groupbox.ForeColor = System.Drawing.Color.White;
            this.currentFeatureList2Groupbox.Location = new System.Drawing.Point(446, 277);
            this.currentFeatureList2Groupbox.Name = "currentFeatureList2Groupbox";
            this.currentFeatureList2Groupbox.Size = new System.Drawing.Size(472, 336);
            this.currentFeatureList2Groupbox.TabIndex = 6;
            this.currentFeatureList2Groupbox.TabStop = false;
            this.currentFeatureList2Groupbox.Text = "Implemented Features";
            // 
            // sendToBacklogBtn
            // 
            this.sendToBacklogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sendToBacklogBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendToBacklogBtn.Location = new System.Drawing.Point(302, 256);
            this.sendToBacklogBtn.Name = "sendToBacklogBtn";
            this.sendToBacklogBtn.Size = new System.Drawing.Size(98, 58);
            this.sendToBacklogBtn.TabIndex = 1;
            this.sendToBacklogBtn.Text = "Send to backlog";
            this.sendToBacklogBtn.UseVisualStyleBackColor = false;
            this.sendToBacklogBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // implementedFeaturesListBox
            // 
            this.implementedFeaturesListBox.FormattingEnabled = true;
            this.implementedFeaturesListBox.ItemHeight = 23;
            this.implementedFeaturesListBox.Items.AddRange(new object[] {
            "listbox3"});
            this.implementedFeaturesListBox.Location = new System.Drawing.Point(19, 29);
            this.implementedFeaturesListBox.Name = "implementedFeaturesListBox";
            this.implementedFeaturesListBox.Size = new System.Drawing.Size(432, 211);
            this.implementedFeaturesListBox.TabIndex = 0;
            this.implementedFeaturesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // currentFeatureListGroupbox1
            // 
            this.currentFeatureListGroupbox1.Controls.Add(this.assignTaskBtn);
            this.currentFeatureListGroupbox1.Controls.Add(this.addNewFeatureBtn);
            this.currentFeatureListGroupbox1.Controls.Add(this.currentFeatureListbox1);
            this.currentFeatureListGroupbox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFeatureListGroupbox1.ForeColor = System.Drawing.Color.White;
            this.currentFeatureListGroupbox1.Location = new System.Drawing.Point(7, 277);
            this.currentFeatureListGroupbox1.Name = "currentFeatureListGroupbox1";
            this.currentFeatureListGroupbox1.Size = new System.Drawing.Size(422, 336);
            this.currentFeatureListGroupbox1.TabIndex = 5;
            this.currentFeatureListGroupbox1.TabStop = false;
            this.currentFeatureListGroupbox1.Text = "Current Feature List";
            // 
            // assignTaskBtn
            // 
            this.assignTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.assignTaskBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignTaskBtn.Location = new System.Drawing.Point(252, 259);
            this.assignTaskBtn.Name = "assignTaskBtn";
            this.assignTaskBtn.Size = new System.Drawing.Size(100, 54);
            this.assignTaskBtn.TabIndex = 2;
            this.assignTaskBtn.Text = "Assign Task";
            this.assignTaskBtn.UseVisualStyleBackColor = false;
            // 
            // addNewFeatureBtn
            // 
            this.addNewFeatureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addNewFeatureBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addNewFeatureBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewFeatureBtn.ForeColor = System.Drawing.Color.White;
            this.addNewFeatureBtn.Location = new System.Drawing.Point(38, 258);
            this.addNewFeatureBtn.Name = "addNewFeatureBtn";
            this.addNewFeatureBtn.Size = new System.Drawing.Size(100, 55);
            this.addNewFeatureBtn.TabIndex = 1;
            this.addNewFeatureBtn.Text = "Add New Task";
            this.addNewFeatureBtn.UseVisualStyleBackColor = false;
            this.addNewFeatureBtn.Click += new System.EventHandler(this.addNewFeatureBtn_Click);
            // 
            // currentFeatureListbox1
            // 
            this.currentFeatureListbox1.FormattingEnabled = true;
            this.currentFeatureListbox1.ItemHeight = 23;
            this.currentFeatureListbox1.Items.AddRange(new object[] {
            "listbox2"});
            this.currentFeatureListbox1.Location = new System.Drawing.Point(14, 29);
            this.currentFeatureListbox1.Name = "currentFeatureListbox1";
            this.currentFeatureListbox1.Size = new System.Drawing.Size(385, 211);
            this.currentFeatureListbox1.TabIndex = 0;
            // 
            // currentProjectsLabel
            // 
            this.currentProjectsLabel.AutoSize = true;
            this.currentProjectsLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentProjectsLabel.ForeColor = System.Drawing.Color.White;
            this.currentProjectsLabel.Location = new System.Drawing.Point(17, 113);
            this.currentProjectsLabel.Name = "currentProjectsLabel";
            this.currentProjectsLabel.Size = new System.Drawing.Size(137, 23);
            this.currentProjectsLabel.TabIndex = 3;
            this.currentProjectsLabel.Text = "Current Groups :";
            this.currentProjectsLabel.Click += new System.EventHandler(this.currentProjectsLabel_Click);
            // 
            // projectManagerOfLabel
            // 
            this.projectManagerOfLabel.AutoSize = true;
            this.projectManagerOfLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.projectManagerOfLabel.ForeColor = System.Drawing.Color.White;
            this.projectManagerOfLabel.Location = new System.Drawing.Point(15, 65);
            this.projectManagerOfLabel.Name = "projectManagerOfLabel";
            this.projectManagerOfLabel.Size = new System.Drawing.Size(231, 32);
            this.projectManagerOfLabel.TabIndex = 1;
            this.projectManagerOfLabel.Text = "Project Manager of :";
            // 
            // viewProjectBacklogBtn
            // 
            this.viewProjectBacklogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.viewProjectBacklogBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProjectBacklogBtn.ForeColor = System.Drawing.Color.White;
            this.viewProjectBacklogBtn.Location = new System.Drawing.Point(965, 326);
            this.viewProjectBacklogBtn.Name = "viewProjectBacklogBtn";
            this.viewProjectBacklogBtn.Size = new System.Drawing.Size(153, 69);
            this.viewProjectBacklogBtn.TabIndex = 6;
            this.viewProjectBacklogBtn.Text = "View Project Backlog";
            this.viewProjectBacklogBtn.UseVisualStyleBackColor = false;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Aqua;
            this.logOutBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(1004, 569);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(89, 57);
            this.logOutBtn.TabIndex = 7;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // viewProjectInfoBtn
            // 
            this.viewProjectInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.viewProjectInfoBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProjectInfoBtn.ForeColor = System.Drawing.Color.White;
            this.viewProjectInfoBtn.Location = new System.Drawing.Point(965, 238);
            this.viewProjectInfoBtn.Name = "viewProjectInfoBtn";
            this.viewProjectInfoBtn.Size = new System.Drawing.Size(153, 69);
            this.viewProjectInfoBtn.TabIndex = 8;
            this.viewProjectInfoBtn.Text = "View Group Info";
            this.viewProjectInfoBtn.UseVisualStyleBackColor = false;
            this.viewProjectInfoBtn.Click += new System.EventHandler(this.viewProjectInfoBtn_Click);
            // 
            // updateGroupMembersBtn
            // 
            this.updateGroupMembersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateGroupMembersBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGroupMembersBtn.ForeColor = System.Drawing.Color.White;
            this.updateGroupMembersBtn.Location = new System.Drawing.Point(965, 148);
            this.updateGroupMembersBtn.Name = "updateGroupMembersBtn";
            this.updateGroupMembersBtn.Size = new System.Drawing.Size(153, 70);
            this.updateGroupMembersBtn.TabIndex = 10;
            this.updateGroupMembersBtn.Text = "Update Group Info";
            this.updateGroupMembersBtn.UseVisualStyleBackColor = false;
            this.updateGroupMembersBtn.Click += new System.EventHandler(this.updateGroupMembersBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(965, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 69);
            this.button1.TabIndex = 11;
            this.button1.Text = "Update Project Info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(965, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 70);
            this.button2.TabIndex = 12;
            this.button2.Text = "Create New Group";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(21, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(897, 131);
            this.dataGridView1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(94, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "View Completed Task";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ProjectManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1150, 654);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateGroupMembersBtn);
            this.Controls.Add(this.viewProjectInfoBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.viewProjectBacklogBtn);
            this.Controls.Add(this.mainGroupbox);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectManagerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Manager Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.mainGroupbox.ResumeLayout(false);
            this.mainGroupbox.PerformLayout();
            this.currentFeatureList2Groupbox.ResumeLayout(false);
            this.currentFeatureListGroupbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeFullNameLabel;
        private System.Windows.Forms.GroupBox mainGroupbox;
        private System.Windows.Forms.GroupBox currentFeatureListGroupbox1;
        private System.Windows.Forms.Button assignTaskBtn;
        private System.Windows.Forms.Button addNewFeatureBtn;
        private System.Windows.Forms.ListBox currentFeatureListbox1;
        private System.Windows.Forms.Label currentProjectsLabel;
        private System.Windows.Forms.Label projectManagerOfLabel;
        private System.Windows.Forms.GroupBox currentFeatureList2Groupbox;
        private System.Windows.Forms.Button sendToBacklogBtn;
        private System.Windows.Forms.ListBox implementedFeaturesListBox;
        private System.Windows.Forms.Button viewProjectBacklogBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button viewProjectInfoBtn;
        private System.Windows.Forms.Button updateGroupMembersBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}