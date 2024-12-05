namespace StudentAdministrationSystemRevive.Views.UserAdministrator
{
    partial class ctrlAdminAddCohort
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
            panel1 = new Panel();
            btnCreateCohort = new Button();
            txtAD_Cohort_Start_Year = new TextBox();
            label5 = new Label();
            txtAD_Cohort_ProgCode = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dg_AD_CohortAdd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_AD_CohortAdd).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(171, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 1);
            panel1.TabIndex = 60;
            // 
            // btnCreateCohort
            // 
            btnCreateCohort.BackColor = Color.RoyalBlue;
            btnCreateCohort.Cursor = Cursors.Hand;
            btnCreateCohort.FlatAppearance.BorderSize = 0;
            btnCreateCohort.FlatStyle = FlatStyle.Flat;
            btnCreateCohort.Font = new Font("Microsoft YaHei UI", 12F);
            btnCreateCohort.ForeColor = Color.White;
            btnCreateCohort.ImeMode = ImeMode.NoControl;
            btnCreateCohort.Location = new Point(549, 631);
            btnCreateCohort.Name = "btnCreateCohort";
            btnCreateCohort.Size = new Size(283, 37);
            btnCreateCohort.TabIndex = 58;
            btnCreateCohort.Text = "Create Cohort";
            btnCreateCohort.UseVisualStyleBackColor = false;
            btnCreateCohort.Click += btnCreateCohort_Click;
            // 
            // txtAD_Cohort_Start_Year
            // 
            txtAD_Cohort_Start_Year.BackColor = Color.WhiteSmoke;
            txtAD_Cohort_Start_Year.BorderStyle = BorderStyle.FixedSingle;
            txtAD_Cohort_Start_Year.Font = new Font("Segoe UI", 12F);
            txtAD_Cohort_Start_Year.Location = new Point(181, 209);
            txtAD_Cohort_Start_Year.Name = "txtAD_Cohort_Start_Year";
            txtAD_Cohort_Start_Year.Size = new Size(315, 29);
            txtAD_Cohort_Start_Year.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 14F);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(181, 175);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 56;
            label5.Text = "Start Year";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtAD_Cohort_ProgCode
            // 
            txtAD_Cohort_ProgCode.BackColor = Color.WhiteSmoke;
            txtAD_Cohort_ProgCode.BorderStyle = BorderStyle.FixedSingle;
            txtAD_Cohort_ProgCode.Font = new Font("Segoe UI", 12F);
            txtAD_Cohort_ProgCode.Location = new Point(517, 209);
            txtAD_Cohort_ProgCode.Name = "txtAD_Cohort_ProgCode";
            txtAD_Cohort_ProgCode.Size = new Size(315, 29);
            txtAD_Cohort_ProgCode.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 14F);
            label2.ForeColor = Color.Black;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(517, 175);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 50;
            label2.Text = "Programme Code";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 18F);
            label1.ForeColor = Color.RoyalBlue;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(171, 55);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 49;
            label1.Text = "Add Cohort";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dg_AD_CohortAdd
            // 
            dg_AD_CohortAdd.AllowUserToDeleteRows = false;
            dg_AD_CohortAdd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_AD_CohortAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_AD_CohortAdd.Location = new Point(181, 260);
            dg_AD_CohortAdd.Name = "dg_AD_CohortAdd";
            dg_AD_CohortAdd.ReadOnly = true;
            dg_AD_CohortAdd.Size = new Size(651, 354);
            dg_AD_CohortAdd.TabIndex = 61;
            // 
            // ctrlAdminAddCohort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dg_AD_CohortAdd);
            Controls.Add(panel1);
            Controls.Add(btnCreateCohort);
            Controls.Add(txtAD_Cohort_Start_Year);
            Controls.Add(label5);
            Controls.Add(txtAD_Cohort_ProgCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ctrlAdminAddCohort";
            Size = new Size(1003, 740);
            Load += ctrlAdminAddCohort_Load;
            ((System.ComponentModel.ISupportInitialize)dg_AD_CohortAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCreateCohort;
        private TextBox txtAD_Cohort_Start_Year;
        private Label label5;
        private TextBox txtAD_Cohort_ProgCode;
        private Label label2;
        private Label label1;
        private DataGridView dg_AD_CohortAdd;
    }
}
