
namespace ProjectManager
{
    partial class ProjectManagerStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagerStartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.continueAsAdminBtn = new System.Windows.Forms.Button();
            this.continueAsProjectMemberBtn = new System.Windows.Forms.Button();
            this.continueAsProjectManagerBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Manager App Ver 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // continueAsAdminBtn
            // 
            this.continueAsAdminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.continueAsAdminBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueAsAdminBtn.ForeColor = System.Drawing.Color.White;
            this.continueAsAdminBtn.Location = new System.Drawing.Point(182, 139);
            this.continueAsAdminBtn.Name = "continueAsAdminBtn";
            this.continueAsAdminBtn.Size = new System.Drawing.Size(285, 54);
            this.continueAsAdminBtn.TabIndex = 2;
            this.continueAsAdminBtn.Text = "Continue As Admin";
            this.continueAsAdminBtn.UseVisualStyleBackColor = false;
            this.continueAsAdminBtn.Click += new System.EventHandler(this.continueAsAdminBtn_Click);
            // 
            // continueAsProjectMemberBtn
            // 
            this.continueAsProjectMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.continueAsProjectMemberBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueAsProjectMemberBtn.ForeColor = System.Drawing.Color.White;
            this.continueAsProjectMemberBtn.Location = new System.Drawing.Point(182, 199);
            this.continueAsProjectMemberBtn.Name = "continueAsProjectMemberBtn";
            this.continueAsProjectMemberBtn.Size = new System.Drawing.Size(285, 54);
            this.continueAsProjectMemberBtn.TabIndex = 3;
            this.continueAsProjectMemberBtn.Text = "Continue As Project Member";
            this.continueAsProjectMemberBtn.UseVisualStyleBackColor = false;
            this.continueAsProjectMemberBtn.Click += new System.EventHandler(this.continueAsProjectMemberBtn_Click);
            // 
            // continueAsProjectManagerBtn
            // 
            this.continueAsProjectManagerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.continueAsProjectManagerBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueAsProjectManagerBtn.ForeColor = System.Drawing.Color.White;
            this.continueAsProjectManagerBtn.Location = new System.Drawing.Point(182, 259);
            this.continueAsProjectManagerBtn.Name = "continueAsProjectManagerBtn";
            this.continueAsProjectManagerBtn.Size = new System.Drawing.Size(285, 54);
            this.continueAsProjectManagerBtn.TabIndex = 4;
            this.continueAsProjectManagerBtn.Text = "Continue As Project Manager";
            this.continueAsProjectManagerBtn.UseVisualStyleBackColor = false;
            this.continueAsProjectManagerBtn.Click += new System.EventHandler(this.continueAsProjectManagerBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.aboutBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.Location = new System.Drawing.Point(182, 319);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(285, 54);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = false;
            // 
            // ProjectManagerStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.continueAsProjectManagerBtn);
            this.Controls.Add(this.continueAsProjectMemberBtn);
            this.Controls.Add(this.continueAsAdminBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectManagerStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button continueAsAdminBtn;
        private System.Windows.Forms.Button continueAsProjectMemberBtn;
        private System.Windows.Forms.Button continueAsProjectManagerBtn;
        private System.Windows.Forms.Button aboutBtn;
    }
}