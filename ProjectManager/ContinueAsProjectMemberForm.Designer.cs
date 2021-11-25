
namespace ProjectManagement
{
    partial class ContinueAsProjectMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContinueAsProjectMemberForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goBackbtn = new System.Windows.Forms.Button();
            this.signInAsProjectMemberBtn = new System.Windows.Forms.Button();
            this.signUpAsProjectMemberBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.goBackbtn);
            this.groupBox1.Controls.Add(this.signInAsProjectMemberBtn);
            this.groupBox1.Controls.Add(this.signUpAsProjectMemberBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Member Options";
            // 
            // goBackbtn
            // 
            this.goBackbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.goBackbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackbtn.ForeColor = System.Drawing.Color.White;
            this.goBackbtn.Location = new System.Drawing.Point(186, 330);
            this.goBackbtn.Name = "goBackbtn";
            this.goBackbtn.Size = new System.Drawing.Size(122, 50);
            this.goBackbtn.TabIndex = 4;
            this.goBackbtn.Text = "Go Back";
            this.goBackbtn.UseVisualStyleBackColor = false;
            this.goBackbtn.Click += new System.EventHandler(this.goBackbtn_Click);
            // 
            // signInAsProjectMemberBtn
            // 
            this.signInAsProjectMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signInAsProjectMemberBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInAsProjectMemberBtn.ForeColor = System.Drawing.Color.White;
            this.signInAsProjectMemberBtn.Location = new System.Drawing.Point(123, 247);
            this.signInAsProjectMemberBtn.Name = "signInAsProjectMemberBtn";
            this.signInAsProjectMemberBtn.Size = new System.Drawing.Size(256, 61);
            this.signInAsProjectMemberBtn.TabIndex = 2;
            this.signInAsProjectMemberBtn.Text = "Sign In as Project Member";
            this.signInAsProjectMemberBtn.UseVisualStyleBackColor = false;
            this.signInAsProjectMemberBtn.Click += new System.EventHandler(this.signInAsProjectMemberBtn_Click);
            // 
            // signUpAsProjectMemberBtn
            // 
            this.signUpAsProjectMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signUpAsProjectMemberBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpAsProjectMemberBtn.ForeColor = System.Drawing.Color.White;
            this.signUpAsProjectMemberBtn.Location = new System.Drawing.Point(123, 159);
            this.signUpAsProjectMemberBtn.Name = "signUpAsProjectMemberBtn";
            this.signUpAsProjectMemberBtn.Size = new System.Drawing.Size(256, 61);
            this.signUpAsProjectMemberBtn.TabIndex = 1;
            this.signUpAsProjectMemberBtn.Text = "Sign Up as Project Member";
            this.signUpAsProjectMemberBtn.UseVisualStyleBackColor = false;
            this.signUpAsProjectMemberBtn.Click += new System.EventHandler(this.signUpAsProjectMemberBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to do ?";
            // 
            // ContinueAsProjectMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(528, 427);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContinueAsProjectMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Continue As Project Member";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContinueAsProjectMemberForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button signInAsProjectMemberBtn;
        private System.Windows.Forms.Button signUpAsProjectMemberBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBackbtn;
    }
}