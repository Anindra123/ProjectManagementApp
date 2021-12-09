
namespace ProjectManagement
{
    partial class ViewGroupInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewGroupInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupManagerLabel = new System.Windows.Forms.Label();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.groupMemberGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMemberGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupManagerLabel);
            this.groupBox1.Controls.Add(this.groupNameLabel);
            this.groupBox1.Controls.Add(this.goBackBtn);
            this.groupBox1.Controls.Add(this.groupMemberGridView);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group Info";
            // 
            // groupManagerLabel
            // 
            this.groupManagerLabel.AutoSize = true;
            this.groupManagerLabel.Location = new System.Drawing.Point(165, 93);
            this.groupManagerLabel.Name = "groupManagerLabel";
            this.groupManagerLabel.Size = new System.Drawing.Size(49, 23);
            this.groupManagerLabel.TabIndex = 6;
            this.groupManagerLabel.Text = "none";
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Location = new System.Drawing.Point(165, 43);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(49, 23);
            this.groupNameLabel.TabIndex = 5;
            this.groupNameLabel.Text = "none";
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.goBackBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.ForeColor = System.Drawing.Color.White;
            this.goBackBtn.Location = new System.Drawing.Point(660, 396);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(126, 59);
            this.goBackBtn.TabIndex = 4;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = false;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // groupMemberGridView
            // 
            this.groupMemberGridView.AllowUserToAddRows = false;
            this.groupMemberGridView.AllowUserToDeleteRows = false;
            this.groupMemberGridView.AllowUserToResizeColumns = false;
            this.groupMemberGridView.AllowUserToResizeRows = false;
            this.groupMemberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupMemberGridView.Location = new System.Drawing.Point(35, 168);
            this.groupMemberGridView.MultiSelect = false;
            this.groupMemberGridView.Name = "groupMemberGridView";
            this.groupMemberGridView.ReadOnly = true;
            this.groupMemberGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.groupMemberGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.groupMemberGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.groupMemberGridView.RowTemplate.Height = 24;
            this.groupMemberGridView.Size = new System.Drawing.Size(509, 222);
            this.groupMemberGridView.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Members :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name :";
            // 
            // ViewGroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(851, 506);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewGroupInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Group Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewGroupInfo_FormClosed);
            this.Load += new System.EventHandler(this.ViewGroupInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupMemberGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView groupMemberGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label groupManagerLabel;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Button goBackBtn;
    }
}