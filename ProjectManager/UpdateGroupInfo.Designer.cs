
namespace ProjectManagement
{
    partial class UpdateGroupInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateGroupInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.AddMemberBtn = new System.Windows.Forms.Button();
            this.RemoveMemberBtn = new System.Windows.Forms.Button();
            this.groupNameTxtBox = new System.Windows.Forms.TextBox();
            this.memberCountTextBox = new System.Windows.Forms.TextBox();
            this.discardGroupBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.currentPManagerGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.currentMembersGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.currentMembersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group Members Count :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Members";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(48, 469);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(123, 67);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GoBackBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackBtn.ForeColor = System.Drawing.Color.White;
            this.GoBackBtn.Location = new System.Drawing.Point(524, 469);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(123, 67);
            this.GoBackBtn.TabIndex = 5;
            this.GoBackBtn.Text = "Go Back";
            this.GoBackBtn.UseVisualStyleBackColor = false;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddMemberBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberBtn.ForeColor = System.Drawing.Color.White;
            this.AddMemberBtn.Location = new System.Drawing.Point(554, 255);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.Size = new System.Drawing.Size(123, 67);
            this.AddMemberBtn.TabIndex = 6;
            this.AddMemberBtn.Text = "Add Member";
            this.AddMemberBtn.UseVisualStyleBackColor = false;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // RemoveMemberBtn
            // 
            this.RemoveMemberBtn.BackColor = System.Drawing.Color.Red;
            this.RemoveMemberBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveMemberBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveMemberBtn.Location = new System.Drawing.Point(554, 343);
            this.RemoveMemberBtn.Name = "RemoveMemberBtn";
            this.RemoveMemberBtn.Size = new System.Drawing.Size(123, 67);
            this.RemoveMemberBtn.TabIndex = 7;
            this.RemoveMemberBtn.Text = "Remove Member";
            this.RemoveMemberBtn.UseVisualStyleBackColor = false;
            this.RemoveMemberBtn.Click += new System.EventHandler(this.RemoveMemberBtn_Click);
            // 
            // groupNameTxtBox
            // 
            this.groupNameTxtBox.Location = new System.Drawing.Point(213, 99);
            this.groupNameTxtBox.Name = "groupNameTxtBox";
            this.groupNameTxtBox.Size = new System.Drawing.Size(346, 22);
            this.groupNameTxtBox.TabIndex = 8;
            // 
            // memberCountTextBox
            // 
            this.memberCountTextBox.Location = new System.Drawing.Point(213, 146);
            this.memberCountTextBox.Name = "memberCountTextBox";
            this.memberCountTextBox.Size = new System.Drawing.Size(346, 22);
            this.memberCountTextBox.TabIndex = 9;
            // 
            // discardGroupBtn
            // 
            this.discardGroupBtn.BackColor = System.Drawing.Color.Red;
            this.discardGroupBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.discardGroupBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardGroupBtn.ForeColor = System.Drawing.Color.White;
            this.discardGroupBtn.Location = new System.Drawing.Point(290, 469);
            this.discardGroupBtn.Name = "discardGroupBtn";
            this.discardGroupBtn.Size = new System.Drawing.Size(123, 67);
            this.discardGroupBtn.TabIndex = 10;
            this.discardGroupBtn.Text = "Discard Group";
            this.discardGroupBtn.UseVisualStyleBackColor = false;
            this.discardGroupBtn.Click += new System.EventHandler(this.discardGroupBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Select Group :";
            // 
            // currentPManagerGroupsComboBox
            // 
            this.currentPManagerGroupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentPManagerGroupsComboBox.FormattingEnabled = true;
            this.currentPManagerGroupsComboBox.Location = new System.Drawing.Point(37, 46);
            this.currentPManagerGroupsComboBox.Name = "currentPManagerGroupsComboBox";
            this.currentPManagerGroupsComboBox.Size = new System.Drawing.Size(523, 24);
            this.currentPManagerGroupsComboBox.TabIndex = 28;
            this.currentPManagerGroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.currentPManagerGroupsComboBox_SelectedIndexChanged);
            // 
            // currentMembersGridView
            // 
            this.currentMembersGridView.AllowUserToAddRows = false;
            this.currentMembersGridView.AllowUserToDeleteRows = false;
            this.currentMembersGridView.AllowUserToResizeColumns = false;
            this.currentMembersGridView.AllowUserToResizeRows = false;
            this.currentMembersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentMembersGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.currentMembersGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.currentMembersGridView.Location = new System.Drawing.Point(37, 244);
            this.currentMembersGridView.Name = "currentMembersGridView";
            this.currentMembersGridView.ReadOnly = true;
            this.currentMembersGridView.RowHeadersWidth = 51;
            this.currentMembersGridView.RowTemplate.Height = 24;
            this.currentMembersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currentMembersGridView.Size = new System.Drawing.Size(463, 187);
            this.currentMembersGridView.TabIndex = 30;
            // 
            // UpdateGroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(703, 566);
            this.Controls.Add(this.currentMembersGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.currentPManagerGroupsComboBox);
            this.Controls.Add(this.discardGroupBtn);
            this.Controls.Add(this.memberCountTextBox);
            this.Controls.Add(this.groupNameTxtBox);
            this.Controls.Add(this.RemoveMemberBtn);
            this.Controls.Add(this.AddMemberBtn);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateGroupInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Group Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateGroupInfo_FormClosed);
            this.Load += new System.EventHandler(this.UpdateGroupInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentMembersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.Button AddMemberBtn;
        private System.Windows.Forms.Button RemoveMemberBtn;
        private System.Windows.Forms.TextBox groupNameTxtBox;
        private System.Windows.Forms.TextBox memberCountTextBox;
        private System.Windows.Forms.Button discardGroupBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox currentPManagerGroupsComboBox;
        private System.Windows.Forms.DataGridView currentMembersGridView;
    }
}