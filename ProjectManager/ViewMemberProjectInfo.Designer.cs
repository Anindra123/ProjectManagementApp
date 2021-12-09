
namespace ProjectManagement
{
    partial class ViewMemberProjectInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMemberProjectInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.projEndDate = new System.Windows.Forms.Label();
            this.projStartDate = new System.Windows.Forms.Label();
            this.projManagerLbl = new System.Windows.Forms.Label();
            this.projectDescLbl = new System.Windows.Forms.Label();
            this.projectTitleLbl = new System.Windows.Forms.Label();
            this.projectTaskGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectTaskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.goBackBtn);
            this.groupBox1.Controls.Add(this.projEndDate);
            this.groupBox1.Controls.Add(this.projStartDate);
            this.groupBox1.Controls.Add(this.projManagerLbl);
            this.groupBox1.Controls.Add(this.projectDescLbl);
            this.groupBox1.Controls.Add(this.projectTitleLbl);
            this.groupBox1.Controls.Add(this.projectTaskGridView);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 665);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Info";
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.goBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.ForeColor = System.Drawing.Color.White;
            this.goBackBtn.Location = new System.Drawing.Point(649, 580);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(127, 59);
            this.goBackBtn.TabIndex = 14;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = false;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // projEndDate
            // 
            this.projEndDate.AutoSize = true;
            this.projEndDate.Location = new System.Drawing.Point(171, 297);
            this.projEndDate.Name = "projEndDate";
            this.projEndDate.Size = new System.Drawing.Size(49, 23);
            this.projEndDate.TabIndex = 12;
            this.projEndDate.Text = "none";
            // 
            // projStartDate
            // 
            this.projStartDate.AutoSize = true;
            this.projStartDate.Location = new System.Drawing.Point(171, 246);
            this.projStartDate.Name = "projStartDate";
            this.projStartDate.Size = new System.Drawing.Size(49, 23);
            this.projStartDate.TabIndex = 11;
            this.projStartDate.Text = "none";
            // 
            // projManagerLbl
            // 
            this.projManagerLbl.AutoSize = true;
            this.projManagerLbl.Location = new System.Drawing.Point(171, 199);
            this.projManagerLbl.Name = "projManagerLbl";
            this.projManagerLbl.Size = new System.Drawing.Size(49, 23);
            this.projManagerLbl.TabIndex = 10;
            this.projManagerLbl.Text = "none";
            // 
            // projectDescLbl
            // 
            this.projectDescLbl.AutoSize = true;
            this.projectDescLbl.Location = new System.Drawing.Point(40, 126);
            this.projectDescLbl.Name = "projectDescLbl";
            this.projectDescLbl.Size = new System.Drawing.Size(49, 23);
            this.projectDescLbl.TabIndex = 9;
            this.projectDescLbl.Text = "none";
            // 
            // projectTitleLbl
            // 
            this.projectTitleLbl.AutoSize = true;
            this.projectTitleLbl.Location = new System.Drawing.Point(171, 50);
            this.projectTitleLbl.Name = "projectTitleLbl";
            this.projectTitleLbl.Size = new System.Drawing.Size(49, 23);
            this.projectTitleLbl.TabIndex = 8;
            this.projectTitleLbl.Text = "none";
            // 
            // projectTaskGridView
            // 
            this.projectTaskGridView.AllowUserToAddRows = false;
            this.projectTaskGridView.AllowUserToDeleteRows = false;
            this.projectTaskGridView.AllowUserToResizeColumns = false;
            this.projectTaskGridView.AllowUserToResizeRows = false;
            this.projectTaskGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectTaskGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.projectTaskGridView.Location = new System.Drawing.Point(44, 433);
            this.projectTaskGridView.Name = "projectTaskGridView";
            this.projectTaskGridView.ReadOnly = true;
            this.projectTaskGridView.RowHeadersWidth = 51;
            this.projectTaskGridView.RowTemplate.Height = 24;
            this.projectTaskGridView.Size = new System.Drawing.Size(534, 154);
            this.projectTaskGridView.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Current Project Task :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Title  :";
            // 
            // ViewMemberProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(827, 690);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewMemberProjectInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Info";
            this.Load += new System.EventHandler(this.ViewMemberProjectInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectTaskGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label projEndDate;
        private System.Windows.Forms.Label projStartDate;
        private System.Windows.Forms.Label projManagerLbl;
        private System.Windows.Forms.Label projectDescLbl;
        private System.Windows.Forms.Label projectTitleLbl;
        private System.Windows.Forms.DataGridView projectTaskGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBackBtn;
    }
}