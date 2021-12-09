
namespace ProjectManagement
{
    partial class SearchAndAddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAndAddMember));
            this.proMSearchAndAddBtn = new System.Windows.Forms.Button();
            this.proMSearchMemTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proMSearchAndAddBtn
            // 
            this.proMSearchAndAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.proMSearchAndAddBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proMSearchAndAddBtn.ForeColor = System.Drawing.Color.White;
            this.proMSearchAndAddBtn.Location = new System.Drawing.Point(71, 139);
            this.proMSearchAndAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.proMSearchAndAddBtn.Name = "proMSearchAndAddBtn";
            this.proMSearchAndAddBtn.Size = new System.Drawing.Size(142, 63);
            this.proMSearchAndAddBtn.TabIndex = 24;
            this.proMSearchAndAddBtn.Text = "Search And Add";
            this.proMSearchAndAddBtn.UseVisualStyleBackColor = false;
            this.proMSearchAndAddBtn.Click += new System.EventHandler(this.proMSearchAndAddBtn_Click);
            // 
            // proMSearchMemTextBox
            // 
            this.proMSearchMemTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proMSearchMemTextBox.Location = new System.Drawing.Point(272, 41);
            this.proMSearchMemTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.proMSearchMemTextBox.Name = "proMSearchMemTextBox";
            this.proMSearchMemTextBox.Size = new System.Drawing.Size(321, 30);
            this.proMSearchMemTextBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Search Members By Email :";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(451, 139);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(142, 63);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SearchAndAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(678, 254);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.proMSearchAndAddBtn);
            this.Controls.Add(this.proMSearchMemTextBox);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchAndAddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button proMSearchAndAddBtn;
        private System.Windows.Forms.TextBox proMSearchMemTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelBtn;
    }
}