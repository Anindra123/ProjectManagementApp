
namespace ProjectManagement
{
    partial class ProjectMemberSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMemberSignIn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.signInAsProjectMemberBtn = new System.Windows.Forms.Button();
            this.projMemberNameOREmailTextBox = new System.Windows.Forms.TextBox();
            this.projMemberPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.signInAsProjectMemberBtn);
            this.groupBox1.Controls.Add(this.projMemberNameOREmailTextBox);
            this.groupBox1.Controls.Add(this.projMemberPasswordTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(535, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(345, 286);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 58);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // signInAsProjectMemberBtn
            // 
            this.signInAsProjectMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signInAsProjectMemberBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInAsProjectMemberBtn.ForeColor = System.Drawing.Color.White;
            this.signInAsProjectMemberBtn.Location = new System.Drawing.Point(53, 286);
            this.signInAsProjectMemberBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signInAsProjectMemberBtn.Name = "signInAsProjectMemberBtn";
            this.signInAsProjectMemberBtn.Size = new System.Drawing.Size(199, 58);
            this.signInAsProjectMemberBtn.TabIndex = 5;
            this.signInAsProjectMemberBtn.Text = "Sign In as Project Member";
            this.signInAsProjectMemberBtn.UseVisualStyleBackColor = false;
            this.signInAsProjectMemberBtn.Click += new System.EventHandler(this.signInAsProjectMemberBtn_Click);
            // 
            // projMemberNameOREmailTextBox
            // 
            this.projMemberNameOREmailTextBox.Location = new System.Drawing.Point(203, 165);
            this.projMemberNameOREmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projMemberNameOREmailTextBox.Name = "projMemberNameOREmailTextBox";
            this.projMemberNameOREmailTextBox.Size = new System.Drawing.Size(289, 30);
            this.projMemberNameOREmailTextBox.TabIndex = 0;
            // 
            // projMemberPasswordTextBox
            // 
            this.projMemberPasswordTextBox.Location = new System.Drawing.Point(203, 215);
            this.projMemberPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projMemberPasswordTextBox.Name = "projMemberPasswordTextBox";
            this.projMemberPasswordTextBox.PasswordChar = '*';
            this.projMemberPasswordTextBox.Size = new System.Drawing.Size(289, 30);
            this.projMemberPasswordTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name / Email ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProjectMemberSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(560, 398);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ProjectMemberSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Member Sign In";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectMemberSignIn_FormClosed);
            this.Load += new System.EventHandler(this.ProjectMemberSignIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button signInAsProjectMemberBtn;
        private System.Windows.Forms.TextBox projMemberNameOREmailTextBox;
        private System.Windows.Forms.MaskedTextBox projMemberPasswordTextBox;
        private System.Windows.Forms.Label label2;
    }
}