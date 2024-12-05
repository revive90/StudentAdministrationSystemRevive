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
            btnAllCohort = new Button();
            dg_AD_CohortsViewAll = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_AD_CohortsViewAll).BeginInit();
            SuspendLayout();
            // 
            // btnAllCohort
            // 
            btnAllCohort.BackColor = Color.RoyalBlue;
            btnAllCohort.Cursor = Cursors.Hand;
            btnAllCohort.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnAllCohort.FlatAppearance.BorderSize = 0;
            btnAllCohort.FlatStyle = FlatStyle.Flat;
            btnAllCohort.Font = new Font("Microsoft YaHei UI", 10F);
            btnAllCohort.ForeColor = Color.White;
            btnAllCohort.ImeMode = ImeMode.NoControl;
            btnAllCohort.Location = new Point(771, 98);
            btnAllCohort.Name = "btnAllCohort";
            btnAllCohort.Size = new Size(205, 29);
            btnAllCohort.TabIndex = 67;
            btnAllCohort.Text = "Reload";
            btnAllCohort.UseVisualStyleBackColor = false;
            btnAllCohort.Click += btnAllCohort_Click;
            // 
            // dg_AD_CohortsViewAll
            // 
            dg_AD_CohortsViewAll.AllowUserToAddRows = false;
            dg_AD_CohortsViewAll.AllowUserToDeleteRows = false;
            dg_AD_CohortsViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_AD_CohortsViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_AD_CohortsViewAll.Location = new Point(26, 153);
            dg_AD_CohortsViewAll.Name = "dg_AD_CohortsViewAll";
            dg_AD_CohortsViewAll.ReadOnly = true;
            dg_AD_CohortsViewAll.Size = new Size(950, 562);
            dg_AD_CohortsViewAll.TabIndex = 66;
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
            Controls.Add(btnAllCohort);
            Controls.Add(dg_AD_CohortsViewAll);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAdminViewCohort";
            Size = new Size(1003, 740);
            Load += ctrlAdminViewCohort_Load;
            ((System.ComponentModel.ISupportInitialize)dg_AD_CohortsViewAll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAllCohort;
        private DataGridView dg_AD_CohortsViewAll;
        private Panel panel1;
        private Label label2;
    }
}
