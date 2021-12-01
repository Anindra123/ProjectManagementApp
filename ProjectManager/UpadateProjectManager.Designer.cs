
namespace ProjectManagement
{
    partial class UpadateProjectManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpadateProjectManager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.managerPasswordTxt = new System.Windows.Forms.TextBox();
            this.managerEmailTxt = new System.Windows.Forms.TextBox();
            this.lastNameManagerText = new System.Windows.Forms.TextBox();
            this.firstNameManagerTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.managerPasswordTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.managerEmailTxt);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lastNameManagerText);
            this.groupBox1.Controls.Add(this.firstNameManagerTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Project Manager Info";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(405, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 56);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(75, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // managerPasswordTxt
            // 
            this.managerPasswordTxt.Location = new System.Drawing.Point(145, 230);
            this.managerPasswordTxt.Name = "managerPasswordTxt";
            this.managerPasswordTxt.Size = new System.Drawing.Size(456, 30);
            this.managerPasswordTxt.TabIndex = 7;
            this.managerPasswordTxt.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // managerEmailTxt
            // 
            this.managerEmailTxt.Location = new System.Drawing.Point(145, 173);
            this.managerEmailTxt.Name = "managerEmailTxt";
            this.managerEmailTxt.Size = new System.Drawing.Size(456, 30);
            this.managerEmailTxt.TabIndex = 6;
            this.managerEmailTxt.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // lastNameManagerText
            // 
            this.lastNameManagerText.Location = new System.Drawing.Point(145, 117);
            this.lastNameManagerText.Name = "lastNameManagerText";
            this.lastNameManagerText.Size = new System.Drawing.Size(456, 30);
            this.lastNameManagerText.TabIndex = 5;
            this.lastNameManagerText.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // firstNameManagerTxt
            // 
            this.firstNameManagerTxt.Location = new System.Drawing.Point(145, 64);
            this.firstNameManagerTxt.Name = "firstNameManagerTxt";
            this.firstNameManagerTxt.Size = new System.Drawing.Size(456, 30);
            this.firstNameManagerTxt.TabIndex = 4;
            this.firstNameManagerTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.firstNameManagerTxt.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name :";
            // 
            // UpadateProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(656, 437);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpadateProjectManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Project Manager";
            this.Load += new System.EventHandler(this.UpdateProjectManagerInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox managerPasswordTxt;
        private System.Windows.Forms.TextBox managerEmailTxt;
        private System.Windows.Forms.TextBox lastNameManagerText;
        private System.Windows.Forms.TextBox firstNameManagerTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}