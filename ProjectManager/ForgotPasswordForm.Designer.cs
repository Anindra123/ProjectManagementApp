
namespace ProjectManagement
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendMailwithPassword = new System.Windows.Forms.LinkLabel();
            this.emailLbl = new System.Windows.Forms.Label();
            this.fullNameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.submiEmailBtn = new System.Windows.Forms.Button();
            this.enterMailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendMailwithPassword);
            this.groupBox1.Controls.Add(this.emailLbl);
            this.groupBox1.Controls.Add(this.fullNameLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.goBackBtn);
            this.groupBox1.Controls.Add(this.submiEmailBtn);
            this.groupBox1.Controls.Add(this.enterMailTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // sendMailwithPassword
            // 
            this.sendMailwithPassword.AutoSize = true;
            this.sendMailwithPassword.LinkColor = System.Drawing.Color.White;
            this.sendMailwithPassword.Location = new System.Drawing.Point(349, 173);
            this.sendMailwithPassword.Name = "sendMailwithPassword";
            this.sendMailwithPassword.Size = new System.Drawing.Size(198, 23);
            this.sendMailwithPassword.TabIndex = 17;
            this.sendMailwithPassword.TabStop = true;
            this.sendMailwithPassword.Text = "Send mail with password";
            this.sendMailwithPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sendMailwithPassword_LinkClicked);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(118, 173);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(49, 23);
            this.emailLbl.TabIndex = 16;
            this.emailLbl.Text = "none";
            // 
            // fullNameLbl
            // 
            this.fullNameLbl.AutoSize = true;
            this.fullNameLbl.Location = new System.Drawing.Point(118, 125);
            this.fullNameLbl.Name = "fullNameLbl";
            this.fullNameLbl.Size = new System.Drawing.Size(49, 23);
            this.fullNameLbl.TabIndex = 15;
            this.fullNameLbl.Text = "none";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Full Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Info :";
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.goBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.ForeColor = System.Drawing.Color.White;
            this.goBackBtn.Location = new System.Drawing.Point(487, 221);
            this.goBackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(120, 42);
            this.goBackBtn.TabIndex = 11;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = false;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // submiEmailBtn
            // 
            this.submiEmailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.submiEmailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submiEmailBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submiEmailBtn.ForeColor = System.Drawing.Color.White;
            this.submiEmailBtn.Location = new System.Drawing.Point(487, 29);
            this.submiEmailBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submiEmailBtn.Name = "submiEmailBtn";
            this.submiEmailBtn.Size = new System.Drawing.Size(120, 42);
            this.submiEmailBtn.TabIndex = 6;
            this.submiEmailBtn.Text = "Submit";
            this.submiEmailBtn.UseVisualStyleBackColor = false;
            this.submiEmailBtn.Click += new System.EventHandler(this.submiEmailBtn_Click);
            // 
            // enterMailTextBox
            // 
            this.enterMailTextBox.Location = new System.Drawing.Point(172, 35);
            this.enterMailTextBox.Name = "enterMailTextBox";
            this.enterMailTextBox.Size = new System.Drawing.Size(289, 30);
            this.enterMailTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your mail :";
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(671, 313);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox enterMailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.Button submiEmailBtn;
        private System.Windows.Forms.LinkLabel sendMailwithPassword;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label fullNameLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}