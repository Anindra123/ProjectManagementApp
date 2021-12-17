
namespace ProjectManagement
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.projManSignUpRadioBtn = new System.Windows.Forms.RadioButton();
            this.projMemSignUpRadioBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lastNameNoRadioBtn = new System.Windows.Forms.RadioButton();
            this.lastNameYesRadioBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.projMLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.projectMemberEmailTextBox = new System.Windows.Forms.TextBox();
            this.projMemberPasswordTextBox = new System.Windows.Forms.TextBox();
            this.projMemFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.goBackHomePageBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lastNameNoRadioBtn);
            this.groupBox1.Controls.Add(this.lastNameYesRadioBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.projMLastNameTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.projectMemberEmailTextBox);
            this.groupBox1.Controls.Add(this.projMemberPasswordTextBox);
            this.groupBox1.Controls.Add(this.projMemFirstNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(691, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // projManSignUpRadioBtn
            // 
            this.projManSignUpRadioBtn.AutoSize = true;
            this.projManSignUpRadioBtn.Location = new System.Drawing.Point(206, 58);
            this.projManSignUpRadioBtn.Name = "projManSignUpRadioBtn";
            this.projManSignUpRadioBtn.Size = new System.Drawing.Size(157, 27);
            this.projManSignUpRadioBtn.TabIndex = 20;
            this.projManSignUpRadioBtn.TabStop = true;
            this.projManSignUpRadioBtn.Text = "Project Manager";
            this.projManSignUpRadioBtn.UseVisualStyleBackColor = true;
            this.projManSignUpRadioBtn.CheckedChanged += new System.EventHandler(this.projManSignUpRadioBtn_CheckedChanged);
            // 
            // projMemSignUpRadioBtn
            // 
            this.projMemSignUpRadioBtn.AutoSize = true;
            this.projMemSignUpRadioBtn.Location = new System.Drawing.Point(10, 58);
            this.projMemSignUpRadioBtn.Name = "projMemSignUpRadioBtn";
            this.projMemSignUpRadioBtn.Size = new System.Drawing.Size(153, 27);
            this.projMemSignUpRadioBtn.TabIndex = 19;
            this.projMemSignUpRadioBtn.TabStop = true;
            this.projMemSignUpRadioBtn.Text = "Project Member";
            this.projMemSignUpRadioBtn.UseVisualStyleBackColor = true;
            this.projMemSignUpRadioBtn.CheckedChanged += new System.EventHandler(this.projMemSignUpRadioBtn_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Choose a role to sign up as :";
            // 
            // lastNameNoRadioBtn
            // 
            this.lastNameNoRadioBtn.AutoSize = true;
            this.lastNameNoRadioBtn.Location = new System.Drawing.Point(437, 85);
            this.lastNameNoRadioBtn.Name = "lastNameNoRadioBtn";
            this.lastNameNoRadioBtn.Size = new System.Drawing.Size(54, 27);
            this.lastNameNoRadioBtn.TabIndex = 17;
            this.lastNameNoRadioBtn.TabStop = true;
            this.lastNameNoRadioBtn.Text = "No";
            this.lastNameNoRadioBtn.UseVisualStyleBackColor = true;
            this.lastNameNoRadioBtn.CheckedChanged += new System.EventHandler(this.lastNameNoRadioBtn_CheckedChanged);
            // 
            // lastNameYesRadioBtn
            // 
            this.lastNameYesRadioBtn.AutoSize = true;
            this.lastNameYesRadioBtn.Location = new System.Drawing.Point(290, 87);
            this.lastNameYesRadioBtn.Name = "lastNameYesRadioBtn";
            this.lastNameYesRadioBtn.Size = new System.Drawing.Size(55, 27);
            this.lastNameYesRadioBtn.TabIndex = 16;
            this.lastNameYesRadioBtn.TabStop = true;
            this.lastNameYesRadioBtn.Text = "Yes";
            this.lastNameYesRadioBtn.UseVisualStyleBackColor = true;
            this.lastNameYesRadioBtn.CheckedChanged += new System.EventHandler(this.lastNameYesRadioBtn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Want to provide last name ?";
            // 
            // projMLastNameTextBox
            // 
            this.projMLastNameTextBox.Location = new System.Drawing.Point(231, 133);
            this.projMLastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projMLastNameTextBox.Name = "projMLastNameTextBox";
            this.projMLastNameTextBox.Size = new System.Drawing.Size(415, 30);
            this.projMLastNameTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Name";
            // 
            // projectMemberEmailTextBox
            // 
            this.projectMemberEmailTextBox.Location = new System.Drawing.Point(231, 239);
            this.projectMemberEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectMemberEmailTextBox.Name = "projectMemberEmailTextBox";
            this.projectMemberEmailTextBox.Size = new System.Drawing.Size(415, 30);
            this.projectMemberEmailTextBox.TabIndex = 3;
            // 
            // projMemberPasswordTextBox
            // 
            this.projMemberPasswordTextBox.Location = new System.Drawing.Point(231, 186);
            this.projMemberPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projMemberPasswordTextBox.Name = "projMemberPasswordTextBox";
            this.projMemberPasswordTextBox.PasswordChar = '*';
            this.projMemberPasswordTextBox.Size = new System.Drawing.Size(415, 30);
            this.projMemberPasswordTextBox.TabIndex = 2;
            // 
            // projMemFirstNameTextBox
            // 
            this.projMemFirstNameTextBox.Location = new System.Drawing.Point(231, 33);
            this.projMemFirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projMemFirstNameTextBox.Name = "projMemFirstNameTextBox";
            this.projMemFirstNameTextBox.Size = new System.Drawing.Size(415, 30);
            this.projMemFirstNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.White;
            this.signUpBtn.Location = new System.Drawing.Point(48, 424);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(132, 54);
            this.signUpBtn.TabIndex = 1;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(542, 424);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(132, 54);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // goBackHomePageBtn
            // 
            this.goBackHomePageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.goBackHomePageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackHomePageBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackHomePageBtn.ForeColor = System.Drawing.Color.White;
            this.goBackHomePageBtn.Location = new System.Drawing.Point(289, 424);
            this.goBackHomePageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBackHomePageBtn.Name = "goBackHomePageBtn";
            this.goBackHomePageBtn.Size = new System.Drawing.Size(132, 54);
            this.goBackHomePageBtn.TabIndex = 3;
            this.goBackHomePageBtn.Text = "Back To Home";
            this.goBackHomePageBtn.UseVisualStyleBackColor = false;
            this.goBackHomePageBtn.Click += new System.EventHandler(this.goBackHomePageBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.projManSignUpRadioBtn);
            this.groupBox2.Controls.Add(this.projMemSignUpRadioBtn);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(25, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(714, 502);
            this.Controls.Add(this.goBackHomePageBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberSignUpForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox projectMemberEmailTextBox;
        private System.Windows.Forms.TextBox projMemberPasswordTextBox;
        private System.Windows.Forms.TextBox projMemFirstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button goBackHomePageBtn;
        private System.Windows.Forms.TextBox projMLastNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton projManSignUpRadioBtn;
        private System.Windows.Forms.RadioButton projMemSignUpRadioBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton lastNameNoRadioBtn;
        private System.Windows.Forms.RadioButton lastNameYesRadioBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}