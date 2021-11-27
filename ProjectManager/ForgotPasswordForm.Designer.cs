
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterMailTextBox = new System.Windows.Forms.TextBox();
            this.submiEmailBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.showPasswordLabel = new System.Windows.Forms.Label();
            this.showPassLinkLabel = new System.Windows.Forms.LinkLabel();
            this.copyToClipboardLabel = new System.Windows.Forms.LinkLabel();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.goBackBtn);
            this.groupBox1.Controls.Add(this.copyToClipboardLabel);
            this.groupBox1.Controls.Add(this.showPassLinkLabel);
            this.groupBox1.Controls.Add(this.showPasswordLabel);
            this.groupBox1.Controls.Add(this.label2);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your mail :";
            // 
            // enterMailTextBox
            // 
            this.enterMailTextBox.Location = new System.Drawing.Point(172, 35);
            this.enterMailTextBox.Name = "enterMailTextBox";
            this.enterMailTextBox.Size = new System.Drawing.Size(289, 30);
            this.enterMailTextBox.TabIndex = 1;
            // 
            // submiEmailBtn
            // 
            this.submiEmailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your Password :";
            // 
            // showPasswordLabel
            // 
            this.showPasswordLabel.AutoSize = true;
            this.showPasswordLabel.Location = new System.Drawing.Point(168, 135);
            this.showPasswordLabel.Name = "showPasswordLabel";
            this.showPasswordLabel.Size = new System.Drawing.Size(59, 23);
            this.showPasswordLabel.TabIndex = 8;
            this.showPasswordLabel.Text = "*******";
            // 
            // showPassLinkLabel
            // 
            this.showPassLinkLabel.AutoSize = true;
            this.showPassLinkLabel.LinkColor = System.Drawing.Color.White;
            this.showPassLinkLabel.Location = new System.Drawing.Point(361, 135);
            this.showPassLinkLabel.Name = "showPassLinkLabel";
            this.showPassLinkLabel.Size = new System.Drawing.Size(51, 23);
            this.showPassLinkLabel.TabIndex = 9;
            this.showPassLinkLabel.TabStop = true;
            this.showPassLinkLabel.Text = "Show";
            this.showPassLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showPassLinkLabel_LinkClicked);
            // 
            // copyToClipboardLabel
            // 
            this.copyToClipboardLabel.AutoSize = true;
            this.copyToClipboardLabel.LinkColor = System.Drawing.Color.White;
            this.copyToClipboardLabel.Location = new System.Drawing.Point(450, 135);
            this.copyToClipboardLabel.Name = "copyToClipboardLabel";
            this.copyToClipboardLabel.Size = new System.Drawing.Size(157, 23);
            this.copyToClipboardLabel.TabIndex = 10;
            this.copyToClipboardLabel.TabStop = true;
            this.copyToClipboardLabel.Text = "Copy To Clip-board";
            this.copyToClipboardLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.copyToClipboardLabel_LinkClicked);
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox enterMailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.LinkLabel copyToClipboardLabel;
        private System.Windows.Forms.LinkLabel showPassLinkLabel;
        private System.Windows.Forms.Label showPasswordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submiEmailBtn;
    }
}