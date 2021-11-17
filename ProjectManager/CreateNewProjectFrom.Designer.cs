
namespace ProjectManager
{
    partial class CreateNewProjectFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewProjectFrom));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proMRemoveFeature = new System.Windows.Forms.Button();
            this.proMAddNewFeatures = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.proMCurrentFeatures = new System.Windows.Forms.ListBox();
            this.proMEstBudget = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proMEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.proMStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.proMProjDescListBox = new System.Windows.Forms.ListBox();
            this.proMProjTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proM2Confirm = new System.Windows.Forms.Button();
            this.proM2Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proMRemoveFeature);
            this.groupBox1.Controls.Add(this.proMAddNewFeatures);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.proMCurrentFeatures);
            this.groupBox1.Controls.Add(this.proMEstBudget);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.proMEndDatePicker);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Controls.Add(this.proMStartDatePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.proMProjDescListBox);
            this.groupBox1.Controls.Add(this.proMProjTitleTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(884, 703);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Info";
            // 
            // proMRemoveFeature
            // 
            this.proMRemoveFeature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.proMRemoveFeature.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proMRemoveFeature.Location = new System.Drawing.Point(636, 599);
            this.proMRemoveFeature.Margin = new System.Windows.Forms.Padding(4);
            this.proMRemoveFeature.Name = "proMRemoveFeature";
            this.proMRemoveFeature.Size = new System.Drawing.Size(151, 49);
            this.proMRemoveFeature.TabIndex = 15;
            this.proMRemoveFeature.Text = "Remove Feature";
            this.proMRemoveFeature.UseVisualStyleBackColor = false;
            // 
            // proMAddNewFeatures
            // 
            this.proMAddNewFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.proMAddNewFeatures.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proMAddNewFeatures.Location = new System.Drawing.Point(636, 505);
            this.proMAddNewFeatures.Margin = new System.Windows.Forms.Padding(4);
            this.proMAddNewFeatures.Name = "proMAddNewFeatures";
            this.proMAddNewFeatures.Size = new System.Drawing.Size(151, 47);
            this.proMAddNewFeatures.TabIndex = 14;
            this.proMAddNewFeatures.Text = "Add New Features";
            this.proMAddNewFeatures.UseVisualStyleBackColor = false;
            this.proMAddNewFeatures.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Current Features";
            // 
            // proMCurrentFeatures
            // 
            this.proMCurrentFeatures.FormattingEnabled = true;
            this.proMCurrentFeatures.ItemHeight = 23;
            this.proMCurrentFeatures.Location = new System.Drawing.Point(50, 489);
            this.proMCurrentFeatures.Margin = new System.Windows.Forms.Padding(4);
            this.proMCurrentFeatures.Name = "proMCurrentFeatures";
            this.proMCurrentFeatures.Size = new System.Drawing.Size(516, 188);
            this.proMCurrentFeatures.TabIndex = 12;
            // 
            // proMEstBudget
            // 
            this.proMEstBudget.Location = new System.Drawing.Point(264, 404);
            this.proMEstBudget.Margin = new System.Windows.Forms.Padding(4);
            this.proMEstBudget.Name = "proMEstBudget";
            this.proMEstBudget.Size = new System.Drawing.Size(302, 30);
            this.proMEstBudget.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estimated Budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "End Date";
            // 
            // proMEndDatePicker
            // 
            this.proMEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.proMEndDatePicker.Location = new System.Drawing.Point(264, 347);
            this.proMEndDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.proMEndDatePicker.Name = "proMEndDatePicker";
            this.proMEndDatePicker.Size = new System.Drawing.Size(265, 30);
            this.proMEndDatePicker.TabIndex = 8;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(46, 301);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(86, 23);
            this.startDate.TabIndex = 7;
            this.startDate.Text = "Start Date";
            // 
            // proMStartDatePicker
            // 
            this.proMStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.proMStartDatePicker.Location = new System.Drawing.Point(264, 294);
            this.proMStartDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.proMStartDatePicker.Name = "proMStartDatePicker";
            this.proMStartDatePicker.Size = new System.Drawing.Size(265, 30);
            this.proMStartDatePicker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project Description";
            // 
            // proMProjDescListBox
            // 
            this.proMProjDescListBox.FormattingEnabled = true;
            this.proMProjDescListBox.ItemHeight = 23;
            this.proMProjDescListBox.Location = new System.Drawing.Point(49, 168);
            this.proMProjDescListBox.Margin = new System.Windows.Forms.Padding(4);
            this.proMProjDescListBox.Name = "proMProjDescListBox";
            this.proMProjDescListBox.Size = new System.Drawing.Size(509, 96);
            this.proMProjDescListBox.TabIndex = 4;
            // 
            // proMProjTitleTextBox
            // 
            this.proMProjTitleTextBox.Location = new System.Drawing.Point(237, 65);
            this.proMProjTitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.proMProjTitleTextBox.Name = "proMProjTitleTextBox";
            this.proMProjTitleTextBox.Size = new System.Drawing.Size(321, 30);
            this.proMProjTitleTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Title";
            // 
            // proM2Confirm
            // 
            this.proM2Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.proM2Confirm.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proM2Confirm.Location = new System.Drawing.Point(142, 725);
            this.proM2Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.proM2Confirm.Name = "proM2Confirm";
            this.proM2Confirm.Size = new System.Drawing.Size(151, 60);
            this.proM2Confirm.TabIndex = 17;
            this.proM2Confirm.Text = "Confirm";
            this.proM2Confirm.UseVisualStyleBackColor = false;
            // 
            // proM2Cancel
            // 
            this.proM2Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.proM2Cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proM2Cancel.Location = new System.Drawing.Point(610, 725);
            this.proM2Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.proM2Cancel.Name = "proM2Cancel";
            this.proM2Cancel.Size = new System.Drawing.Size(151, 60);
            this.proM2Cancel.TabIndex = 18;
            this.proM2Cancel.Text = "Cancel";
            this.proM2Cancel.UseVisualStyleBackColor = false;
            this.proM2Cancel.Click += new System.EventHandler(this.proM2Cancel_Click);
            // 
            // CreateNewProjectFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(915, 814);
            this.Controls.Add(this.proM2Cancel);
            this.Controls.Add(this.proM2Confirm);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateNewProjectFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new project";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker proMEndDatePicker;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.DateTimePicker proMStartDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox proMProjDescListBox;
        private System.Windows.Forms.TextBox proMProjTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button proMRemoveFeature;
        private System.Windows.Forms.Button proMAddNewFeatures;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox proMCurrentFeatures;
        private System.Windows.Forms.TextBox proMEstBudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button proM2Confirm;
        private System.Windows.Forms.Button proM2Cancel;
    }
}