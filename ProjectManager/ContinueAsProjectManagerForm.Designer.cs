
namespace ProjectManagement
{
    partial class ContinueAsProjectManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContinueAsProjectManagerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goBackbtn = new System.Windows.Forms.Button();
            this.signInAsProjectManagerBtn = new System.Windows.Forms.Button();
            this.signUpAsProjectManagerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.goBackbtn);
            this.groupBox1.Controls.Add(this.signInAsProjectManagerBtn);
            this.groupBox1.Controls.Add(this.signUpAsProjectManagerBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Manager Options";
            // 
            // goBackbtn
            // 
            this.goBackbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.goBackbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackbtn.ForeColor = System.Drawing.Color.White;
            this.goBackbtn.Location = new System.Drawing.Point(179, 322);
            this.goBackbtn.Name = "goBackbtn";
            this.goBackbtn.Size = new System.Drawing.Size(122, 50);
            this.goBackbtn.TabIndex = 3;
            this.goBackbtn.Text = "Go Back";
            this.goBackbtn.UseVisualStyleBackColor = false;
            this.goBackbtn.Click += new System.EventHandler(this.goBackbtn_Click);
            // 
            // signInAsProjectManagerBtn
            // 
            this.signInAsProjectManagerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signInAsProjectManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInAsProjectManagerBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInAsProjectManagerBtn.ForeColor = System.Drawing.Color.White;
            this.signInAsProjectManagerBtn.Location = new System.Drawing.Point(123, 223);
            this.signInAsProjectManagerBtn.Name = "signInAsProjectManagerBtn";
            this.signInAsProjectManagerBtn.Size = new System.Drawing.Size(256, 61);
            this.signInAsProjectManagerBtn.TabIndex = 2;
            this.signInAsProjectManagerBtn.Text = "Sign In as Project Manager";
            this.signInAsProjectManagerBtn.UseVisualStyleBackColor = false;
            this.signInAsProjectManagerBtn.Click += new System.EventHandler(this.signInAsProjectManagerBtn_Click);
            // 
            // signUpAsProjectManagerBtn
            // 
            this.signUpAsProjectManagerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signUpAsProjectManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpAsProjectManagerBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpAsProjectManagerBtn.ForeColor = System.Drawing.Color.White;
            this.signUpAsProjectManagerBtn.Location = new System.Drawing.Point(123, 145);
            this.signUpAsProjectManagerBtn.Name = "signUpAsProjectManagerBtn";
            this.signUpAsProjectManagerBtn.Size = new System.Drawing.Size(256, 61);
            this.signUpAsProjectManagerBtn.TabIndex = 1;
            this.signUpAsProjectManagerBtn.Text = "Sign Up as Project Manager";
            this.signUpAsProjectManagerBtn.UseVisualStyleBackColor = false;
            this.signUpAsProjectManagerBtn.Click += new System.EventHandler(this.signUpAsProjectManagerBtn_Click);
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
            // ContinueAsProjectManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(528, 427);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContinueAsProjectManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Continue As Project Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContinueAsProjectManagerForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button signInAsProjectManagerBtn;
        private System.Windows.Forms.Button signUpAsProjectManagerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBackbtn;
    }
}