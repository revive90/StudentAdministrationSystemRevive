namespace StudentAdministrationSystemRevive.Views.UserAdministrator.CohortManagement
{
    partial class ctrlAdminViewCohort
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAllCohorts = new Button();
            dgVPProgTable = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgVPProgTable).BeginInit();
            SuspendLayout();
            // 
            // btnAllCohorts
            // 
            btnAllCohorts.BackColor = Color.RoyalBlue;
            btnAllCohorts.Cursor = Cursors.Hand;
            btnAllCohorts.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnAllCohorts.FlatAppearance.BorderSize = 0;
            btnAllCohorts.FlatStyle = FlatStyle.Flat;
            btnAllCohorts.Font = new Font("Microsoft YaHei UI", 10F);
            btnAllCohorts.ForeColor = Color.White;
            btnAllCohorts.ImeMode = ImeMode.NoControl;
            btnAllCohorts.Location = new Point(771, 98);
            btnAllCohorts.Name = "btnAllCohorts";
            btnAllCohorts.Size = new Size(205, 29);
            btnAllCohorts.TabIndex = 67;
            btnAllCohorts.Text = "Reload";
            btnAllCohorts.UseVisualStyleBackColor = false;
            // 
            // dgVPProgTable
            // 
            dgVPProgTable.AllowUserToAddRows = false;
            dgVPProgTable.AllowUserToDeleteRows = false;
            dgVPProgTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVPProgTable.Location = new Point(26, 153);
            dgVPProgTable.Name = "dgVPProgTable";
            dgVPProgTable.ReadOnly = true;
            dgVPProgTable.Size = new Size(950, 562);
            dgVPProgTable.TabIndex = 66;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(26, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(26, 25);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 64;
            label2.Text = "Existing Cohorts";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ctrlAdminViewCohort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAllCohorts);
            Controls.Add(dgVPProgTable);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAdminViewCohort";
            Size = new Size(1003, 740);
            ((System.ComponentModel.ISupportInitialize)dgVPProgTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAllCohorts;
        private DataGridView dgVPProgTable;
        private Panel panel1;
        private Label label2;
    }
}
