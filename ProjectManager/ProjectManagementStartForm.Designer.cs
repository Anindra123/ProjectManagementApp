
namespace ProjectManagement
{
    partial class ProjectManagementStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagementStartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.continueAsProjectMemberBtn = new System.Windows.Forms.Button();
            this.continueAsProjectManagerBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Management App Ver 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // continueAsProjectMemberBtn
            // 
            this.continueAsProjectMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.continueAsProjectMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueAsProjectMemberBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueAsProjectMemberBtn.ForeColor = System.Drawing.Color.White;
            this.continueAsProjectMemberBtn.Location = new System.Drawing.Point(178, 157);
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
            this.continueAsProjectManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueAsProjectManagerBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueAsProjectManagerBtn.ForeColor = System.Drawing.Color.White;
            this.continueAsProjectManagerBtn.Location = new System.Drawing.Point(178, 217);
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
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.Location = new System.Drawing.Point(178, 277);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(285, 54);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // ProjectManagementStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.continueAsProjectManagerBtn);
            this.Controls.Add(this.continueAsProjectMemberBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectManagementStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button continueAsProjectMemberBtn;
        private System.Windows.Forms.Button continueAsProjectManagerBtn;
        private System.Windows.Forms.Button aboutBtn;
    }
}