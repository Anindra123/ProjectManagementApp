
namespace ProjectManagement
{
    partial class AddNewFeature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFeature));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.projectTitleLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupsComboBox = new System.Windows.Forms.ComboBox();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.assignToComboBox = new System.Windows.Forms.ComboBox();
            this.assignToLabel = new System.Windows.Forms.Label();
            this.assignSelectionNoRadioBtn = new System.Windows.Forms.RadioButton();
            this.assignSelectionYesRadioBtn = new System.Windows.Forms.RadioButton();
            this.assignSelectionLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.projectTitleLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupsComboBox);
            this.groupBox1.Controls.Add(this.taskDescriptionTextBox);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.createBtn);
            this.groupBox1.Controls.Add(this.assignToComboBox);
            this.groupBox1.Controls.Add(this.assignToLabel);
            this.groupBox1.Controls.Add(this.assignSelectionNoRadioBtn);
            this.groupBox1.Controls.Add(this.assignSelectionYesRadioBtn);
            this.groupBox1.Controls.Add(this.assignSelectionLabel);
            this.groupBox1.Controls.Add(this.descriptionLabel);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(this.titleLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 610);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // projectTitleLbl
            // 
            this.projectTitleLbl.AutoSize = true;
            this.projectTitleLbl.Location = new System.Drawing.Point(167, 108);
            this.projectTitleLbl.Name = "projectTitleLbl";
            this.projectTitleLbl.Size = new System.Drawing.Size(49, 23);
            this.projectTitleLbl.TabIndex = 19;
            this.projectTitleLbl.Text = "none";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Project Title :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Group :";
            // 
            // groupsComboBox
            // 
            this.groupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsComboBox.FormattingEnabled = true;
            this.groupsComboBox.Location = new System.Drawing.Point(42, 56);
            this.groupsComboBox.Name = "groupsComboBox";
            this.groupsComboBox.Size = new System.Drawing.Size(523, 31);
            this.groupsComboBox.TabIndex = 16;
            this.groupsComboBox.SelectedIndexChanged += new System.EventHandler(this.groupsComboBox_SelectedIndexChanged);
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(42, 236);
            this.taskDescriptionTextBox.Multiline = true;
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(523, 73);
            this.taskDescriptionTextBox.TabIndex = 15;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(420, 513);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(145, 68);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(78, 513);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(145, 68);
            this.createBtn.TabIndex = 13;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // assignToComboBox
            // 
            this.assignToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignToComboBox.Enabled = false;
            this.assignToComboBox.FormattingEnabled = true;
            this.assignToComboBox.Location = new System.Drawing.Point(171, 428);
            this.assignToComboBox.Name = "assignToComboBox";
            this.assignToComboBox.Size = new System.Drawing.Size(394, 31);
            this.assignToComboBox.TabIndex = 8;
            this.assignToComboBox.SelectedIndexChanged += new System.EventHandler(this.assignToComboBox_SelectedIndexChanged);
            // 
            // assignToLabel
            // 
            this.assignToLabel.AutoSize = true;
            this.assignToLabel.Location = new System.Drawing.Point(38, 431);
            this.assignToLabel.Name = "assignToLabel";
            this.assignToLabel.Size = new System.Drawing.Size(90, 23);
            this.assignToLabel.TabIndex = 7;
            this.assignToLabel.Text = "Assign To :";
            // 
            // assignSelectionNoRadioBtn
            // 
            this.assignSelectionNoRadioBtn.AutoSize = true;
            this.assignSelectionNoRadioBtn.Checked = true;
            this.assignSelectionNoRadioBtn.Location = new System.Drawing.Point(365, 365);
            this.assignSelectionNoRadioBtn.Name = "assignSelectionNoRadioBtn";
            this.assignSelectionNoRadioBtn.Size = new System.Drawing.Size(54, 27);
            this.assignSelectionNoRadioBtn.TabIndex = 6;
            this.assignSelectionNoRadioBtn.TabStop = true;
            this.assignSelectionNoRadioBtn.Text = "No";
            this.assignSelectionNoRadioBtn.UseVisualStyleBackColor = true;
            this.assignSelectionNoRadioBtn.CheckedChanged += new System.EventHandler(this.assignSelectionNoRadioBtn_CheckedChanged);
            // 
            // assignSelectionYesRadioBtn
            // 
            this.assignSelectionYesRadioBtn.AutoSize = true;
            this.assignSelectionYesRadioBtn.Location = new System.Drawing.Point(210, 365);
            this.assignSelectionYesRadioBtn.Name = "assignSelectionYesRadioBtn";
            this.assignSelectionYesRadioBtn.Size = new System.Drawing.Size(55, 27);
            this.assignSelectionYesRadioBtn.TabIndex = 5;
            this.assignSelectionYesRadioBtn.Text = "Yes";
            this.assignSelectionYesRadioBtn.UseVisualStyleBackColor = true;
            this.assignSelectionYesRadioBtn.CheckedChanged += new System.EventHandler(this.assignSelectionYesRadioBtn_CheckedChanged);
            // 
            // assignSelectionLabel
            // 
            this.assignSelectionLabel.AutoSize = true;
            this.assignSelectionLabel.Location = new System.Drawing.Point(38, 365);
            this.assignSelectionLabel.Name = "assignSelectionLabel";
            this.assignSelectionLabel.Size = new System.Drawing.Size(112, 23);
            this.assignSelectionLabel.TabIndex = 4;
            this.assignSelectionLabel.Text = "Assign Now ?";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(38, 200);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(96, 23);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(115, 153);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(450, 30);
            this.titleTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(38, 153);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // AddNewFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(658, 634);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNewFeature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Feature";
            this.Load += new System.EventHandler(this.AddNewFeature_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.ComboBox assignToComboBox;
        private System.Windows.Forms.Label assignToLabel;
        private System.Windows.Forms.RadioButton assignSelectionNoRadioBtn;
        private System.Windows.Forms.RadioButton assignSelectionYesRadioBtn;
        private System.Windows.Forms.Label assignSelectionLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox taskDescriptionTextBox;
        private System.Windows.Forms.Label projectTitleLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupsComboBox;
    }
}