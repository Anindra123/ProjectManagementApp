
namespace ProjectManagement
{
    partial class BackLogTaskView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackLogTaskView));
            this.currentFeatureList2Groupbox = new System.Windows.Forms.GroupBox();
            this.backLogHistoryGridView = new System.Windows.Forms.DataGridView();
            this.goBackbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentFeatureList2Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backLogHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // currentFeatureList2Groupbox
            // 
            this.currentFeatureList2Groupbox.Controls.Add(this.label1);
            this.currentFeatureList2Groupbox.Controls.Add(this.backLogHistoryGridView);
            this.currentFeatureList2Groupbox.Controls.Add(this.goBackbtn);
            this.currentFeatureList2Groupbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFeatureList2Groupbox.ForeColor = System.Drawing.Color.White;
            this.currentFeatureList2Groupbox.Location = new System.Drawing.Point(12, 12);
            this.currentFeatureList2Groupbox.Name = "currentFeatureList2Groupbox";
            this.currentFeatureList2Groupbox.Size = new System.Drawing.Size(776, 426);
            this.currentFeatureList2Groupbox.TabIndex = 7;
            this.currentFeatureList2Groupbox.TabStop = false;
            this.currentFeatureList2Groupbox.Text = "Implemented Features";
            // 
            // backLogHistoryGridView
            // 
            this.backLogHistoryGridView.AllowUserToAddRows = false;
            this.backLogHistoryGridView.AllowUserToDeleteRows = false;
            this.backLogHistoryGridView.AllowUserToResizeColumns = false;
            this.backLogHistoryGridView.AllowUserToResizeRows = false;
            this.backLogHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.backLogHistoryGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.backLogHistoryGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.backLogHistoryGridView.Enabled = false;
            this.backLogHistoryGridView.Location = new System.Drawing.Point(31, 98);
            this.backLogHistoryGridView.Name = "backLogHistoryGridView";
            this.backLogHistoryGridView.ReadOnly = true;
            this.backLogHistoryGridView.RowHeadersWidth = 51;
            this.backLogHistoryGridView.RowTemplate.Height = 24;
            this.backLogHistoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.backLogHistoryGridView.Size = new System.Drawing.Size(708, 187);
            this.backLogHistoryGridView.TabIndex = 9;
            this.backLogHistoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.backLogHistoryGridView_CellContentClick);
            // 
            // goBackbtn
            // 
            this.goBackbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.goBackbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.goBackbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackbtn.ForeColor = System.Drawing.Color.White;
            this.goBackbtn.Location = new System.Drawing.Point(588, 336);
            this.goBackbtn.Name = "goBackbtn";
            this.goBackbtn.Size = new System.Drawing.Size(125, 58);
            this.goBackbtn.TabIndex = 3;
            this.goBackbtn.Text = "Go Back";
            this.goBackbtn.UseVisualStyleBackColor = false;
            this.goBackbtn.Click += new System.EventHandler(this.goBackbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your current backlog history :";
            // 
            // BackLogTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentFeatureList2Groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BackLogTaskView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Back Log History";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BackLogTaskView_FormClosed);
            this.Load += new System.EventHandler(this.BackLogTaskView_Load);
            this.currentFeatureList2Groupbox.ResumeLayout(false);
            this.currentFeatureList2Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backLogHistoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox currentFeatureList2Groupbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView backLogHistoryGridView;
        private System.Windows.Forms.Button goBackbtn;
    }
}