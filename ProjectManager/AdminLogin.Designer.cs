
namespace ProjectManagement
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.Admin_id_label1 = new System.Windows.Forms.Label();
            this.Admin_password_label2 = new System.Windows.Forms.Label();
            this.Admin_name_email_TextBox1 = new System.Windows.Forms.TextBox();
            this.Admin_password_masked_textBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Admin_LogIn_button1 = new System.Windows.Forms.Button();
            this.Admin_cancel_button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_id_label1
            // 
            this.Admin_id_label1.AutoSize = true;
            this.Admin_id_label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_id_label1.ForeColor = System.Drawing.Color.White;
            this.Admin_id_label1.Location = new System.Drawing.Point(41, 168);
            this.Admin_id_label1.Name = "Admin_id_label1";
            this.Admin_id_label1.Size = new System.Drawing.Size(87, 23);
            this.Admin_id_label1.TabIndex = 0;
            this.Admin_id_label1.Text = "Admin ID";
            // 
            // Admin_password_label2
            // 
            this.Admin_password_label2.AutoSize = true;
            this.Admin_password_label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_password_label2.ForeColor = System.Drawing.Color.White;
            this.Admin_password_label2.Location = new System.Drawing.Point(41, 216);
            this.Admin_password_label2.Name = "Admin_password_label2";
            this.Admin_password_label2.Size = new System.Drawing.Size(85, 23);
            this.Admin_password_label2.TabIndex = 1;
            this.Admin_password_label2.Text = "Password";
            // 
            // Admin_name_email_TextBox1
            // 
            this.Admin_name_email_TextBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_name_email_TextBox1.Location = new System.Drawing.Point(162, 169);
            this.Admin_name_email_TextBox1.Multiline = true;
            this.Admin_name_email_TextBox1.Name = "Admin_name_email_TextBox1";
            this.Admin_name_email_TextBox1.Size = new System.Drawing.Size(329, 22);
            this.Admin_name_email_TextBox1.TabIndex = 2;
            // 
            // Admin_password_masked_textBox1
            // 
            this.Admin_password_masked_textBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_password_masked_textBox1.Location = new System.Drawing.Point(162, 214);
            this.Admin_password_masked_textBox1.Name = "Admin_password_masked_textBox1";
            this.Admin_password_masked_textBox1.PasswordChar = '*';
            this.Admin_password_masked_textBox1.Size = new System.Drawing.Size(329, 25);
            this.Admin_password_masked_textBox1.TabIndex = 3;
            // 
            // Admin_LogIn_button1
            // 
            this.Admin_LogIn_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Admin_LogIn_button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_LogIn_button1.ForeColor = System.Drawing.Color.White;
            this.Admin_LogIn_button1.Location = new System.Drawing.Point(116, 291);
            this.Admin_LogIn_button1.Name = "Admin_LogIn_button1";
            this.Admin_LogIn_button1.Size = new System.Drawing.Size(112, 47);
            this.Admin_LogIn_button1.TabIndex = 4;
            this.Admin_LogIn_button1.Text = "Log in";
            this.Admin_LogIn_button1.UseVisualStyleBackColor = false;
            this.Admin_LogIn_button1.Click += new System.EventHandler(this.Admin_LogIn_button1_Click);
            // 
            // Admin_cancel_button2
            // 
            this.Admin_cancel_button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Admin_cancel_button2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_cancel_button2.ForeColor = System.Drawing.Color.White;
            this.Admin_cancel_button2.Location = new System.Drawing.Point(312, 291);
            this.Admin_cancel_button2.Name = "Admin_cancel_button2";
            this.Admin_cancel_button2.Size = new System.Drawing.Size(103, 47);
            this.Admin_cancel_button2.TabIndex = 5;
            this.Admin_cancel_button2.Text = "Cancel";
            this.Admin_cancel_button2.UseVisualStyleBackColor = false;
            this.Admin_cancel_button2.Click += new System.EventHandler(this.Admin_cancel_button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Admin_id_label1);
            this.groupBox1.Controls.Add(this.Admin_cancel_button2);
            this.groupBox1.Controls.Add(this.Admin_password_label2);
            this.groupBox1.Controls.Add(this.Admin_LogIn_button1);
            this.groupBox1.Controls.Add(this.Admin_name_email_TextBox1);
            this.groupBox1.Controls.Add(this.Admin_password_masked_textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 374);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(560, 398);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogin_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Admin_id_label1;
        private System.Windows.Forms.Label Admin_password_label2;
        private System.Windows.Forms.TextBox Admin_name_email_TextBox1;
        private System.Windows.Forms.MaskedTextBox Admin_password_masked_textBox1;
        private System.Windows.Forms.Button Admin_LogIn_button1;
        private System.Windows.Forms.Button Admin_cancel_button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

