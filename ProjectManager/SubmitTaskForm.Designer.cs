
namespace ProjectManagement
{
    partial class SubmitTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitTaskForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taskCmntTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseFilesBtn = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taskDescLabel = new System.Windows.Forms.Label();
            this.taskTitleLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.statusPendingRadioBtn = new System.Windows.Forms.RadioButton();
            this.statusCompletedRadioBtn = new System.Windows.Forms.RadioButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taskCmntTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.browseFilesBtn);
            this.groupBox1.Controls.Add(this.fileNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.taskDescLabel);
            this.groupBox1.Controls.Add(this.taskTitleLabel);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.statusPendingRadioBtn);
            this.groupBox1.Controls.Add(this.statusCompletedRadioBtn);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.descriptionLabel);
            this.groupBox1.Controls.Add(this.titleLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 625);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // taskCmntTxtBox
            // 
            this.taskCmntTxtBox.Location = new System.Drawing.Point(42, 380);
            this.taskCmntTxtBox.Multiline = true;
            this.taskCmntTxtBox.Name = "taskCmntTxtBox";
            this.taskCmntTxtBox.Size = new System.Drawing.Size(629, 111);
            this.taskCmntTxtBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Comment :";
            // 
            // browseFilesBtn
            // 
            this.browseFilesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.browseFilesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseFilesBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseFilesBtn.ForeColor = System.Drawing.Color.White;
            this.browseFilesBtn.Location = new System.Drawing.Point(545, 269);
            this.browseFilesBtn.Name = "browseFilesBtn";
            this.browseFilesBtn.Size = new System.Drawing.Size(133, 56);
            this.browseFilesBtn.TabIndex = 20;
            this.browseFilesBtn.Text = "Browse Files";
            this.browseFilesBtn.UseVisualStyleBackColor = false;
            this.browseFilesBtn.Click += new System.EventHandler(this.browseFilesBtn_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Enabled = false;
            this.fileNameTextBox.Location = new System.Drawing.Point(175, 283);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(345, 30);
            this.fileNameTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Upload file :";
            // 
            // taskDescLabel
            // 
            this.taskDescLabel.AutoSize = true;
            this.taskDescLabel.Location = new System.Drawing.Point(40, 137);
            this.taskDescLabel.Name = "taskDescLabel";
            this.taskDescLabel.Size = new System.Drawing.Size(49, 23);
            this.taskDescLabel.TabIndex = 17;
            this.taskDescLabel.Text = "none";
            // 
            // taskTitleLabel
            // 
            this.taskTitleLabel.AutoSize = true;
            this.taskTitleLabel.Location = new System.Drawing.Point(100, 48);
            this.taskTitleLabel.Name = "taskTitleLabel";
            this.taskTitleLabel.Size = new System.Drawing.Size(49, 23);
            this.taskTitleLabel.TabIndex = 16;
            this.taskTitleLabel.Text = "none";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(481, 527);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(145, 68);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(73, 527);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(145, 68);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // statusPendingRadioBtn
            // 
            this.statusPendingRadioBtn.AutoSize = true;
            this.statusPendingRadioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusPendingRadioBtn.Location = new System.Drawing.Point(198, 213);
            this.statusPendingRadioBtn.Name = "statusPendingRadioBtn";
            this.statusPendingRadioBtn.Size = new System.Drawing.Size(93, 27);
            this.statusPendingRadioBtn.TabIndex = 11;
            this.statusPendingRadioBtn.TabStop = true;
            this.statusPendingRadioBtn.Text = "Pending";
            this.statusPendingRadioBtn.UseVisualStyleBackColor = true;
            this.statusPendingRadioBtn.CheckedChanged += new System.EventHandler(this.statusPendingRadioBtn_CheckedChanged);
            // 
            // statusCompletedRadioBtn
            // 
            this.statusCompletedRadioBtn.AutoSize = true;
            this.statusCompletedRadioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusCompletedRadioBtn.Location = new System.Drawing.Point(394, 213);
            this.statusCompletedRadioBtn.Name = "statusCompletedRadioBtn";
            this.statusCompletedRadioBtn.Size = new System.Drawing.Size(115, 27);
            this.statusCompletedRadioBtn.TabIndex = 10;
            this.statusCompletedRadioBtn.TabStop = true;
            this.statusCompletedRadioBtn.Text = "Completed";
            this.statusCompletedRadioBtn.UseVisualStyleBackColor = true;
            this.statusCompletedRadioBtn.CheckedChanged += new System.EventHandler(this.statusCompletedRadioBtn_CheckedChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(40, 215);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(56, 23);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Status";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(40, 96);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(102, 23);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(38, 48);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(56, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title :";
            // 
            // SubmitTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(730, 649);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SubmitTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit Task";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubmitTaskForm_FormClosed);
            this.Load += new System.EventHandler(this.SubmitTaskForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button browseFilesBtn;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label taskDescLabel;
        private System.Windows.Forms.Label taskTitleLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RadioButton statusPendingRadioBtn;
        private System.Windows.Forms.RadioButton statusCompletedRadioBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox taskCmntTxtBox;
        private System.Windows.Forms.Label label2;
    }
}