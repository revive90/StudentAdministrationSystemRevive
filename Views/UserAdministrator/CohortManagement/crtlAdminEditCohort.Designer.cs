﻿namespace StudentAdministrationSystemRevive.Views.UserAdministrator.CohortManagement
{
    partial class crtlAdminEditCohort
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
            btnAD_CohortSave = new Button();
            dg_AD_CohortEdit = new DataGridView();
            btnAD_CohortFind = new Button();
            txtAD_Cohort_Search_ModuleCode = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_AD_CohortEdit).BeginInit();
            SuspendLayout();
            // 
            // btnAD_CohortSave
            // 
            btnAD_CohortSave.BackColor = Color.RoyalBlue;
            btnAD_CohortSave.Cursor = Cursors.Hand;
            btnAD_CohortSave.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnAD_CohortSave.FlatAppearance.BorderSize = 0;
            btnAD_CohortSave.FlatStyle = FlatStyle.Flat;
            btnAD_CohortSave.Font = new Font("Microsoft YaHei UI", 10F);
            btnAD_CohortSave.ForeColor = Color.White;
            btnAD_CohortSave.ImeMode = ImeMode.NoControl;
            btnAD_CohortSave.Location = new Point(768, 676);
            btnAD_CohortSave.Name = "btnAD_CohortSave";
            btnAD_CohortSave.Size = new Size(205, 29);
            btnAD_CohortSave.TabIndex = 79;
            btnAD_CohortSave.Text = "Save Changes";
            btnAD_CohortSave.UseVisualStyleBackColor = false;
            // 
            // dg_AD_CohortEdit
            // 
            dg_AD_CohortEdit.AllowUserToAddRows = false;
            dg_AD_CohortEdit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_AD_CohortEdit.Location = new Point(23, 206);
            dg_AD_CohortEdit.Name = "dg_AD_CohortEdit";
            dg_AD_CohortEdit.Size = new Size(950, 447);
            dg_AD_CohortEdit.TabIndex = 78;
            // 
            // btnAD_CohortFind
            // 
            btnAD_CohortFind.BackColor = Color.RoyalBlue;
            btnAD_CohortFind.Cursor = Cursors.Hand;
            btnAD_CohortFind.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnAD_CohortFind.FlatAppearance.BorderSize = 0;
            btnAD_CohortFind.FlatStyle = FlatStyle.Flat;
            btnAD_CohortFind.Font = new Font("Microsoft YaHei UI", 10F);
            btnAD_CohortFind.ForeColor = Color.White;
            btnAD_CohortFind.ImeMode = ImeMode.NoControl;
            btnAD_CohortFind.Location = new Point(768, 147);
            btnAD_CohortFind.Name = "btnAD_CohortFind";
            btnAD_CohortFind.Size = new Size(205, 29);
            btnAD_CohortFind.TabIndex = 77;
            btnAD_CohortFind.Text = "Find";
            btnAD_CohortFind.UseVisualStyleBackColor = false;
            // 
            // txtAD_Cohort_Search_ModuleCode
            // 
            txtAD_Cohort_Search_ModuleCode.BackColor = Color.WhiteSmoke;
            txtAD_Cohort_Search_ModuleCode.BorderStyle = BorderStyle.FixedSingle;
            txtAD_Cohort_Search_ModuleCode.Font = new Font("Segoe UI", 12F);
            txtAD_Cohort_Search_ModuleCode.Location = new Point(23, 148);
            txtAD_Cohort_Search_ModuleCode.Name = "txtAD_Cohort_Search_ModuleCode";
            txtAD_Cohort_Search_ModuleCode.Size = new Size(715, 29);
            txtAD_Cohort_Search_ModuleCode.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(23, 111);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 75;
            label3.Text = "Module Code";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(23, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(23, 32);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 73;
            label2.Text = "Edit Cohort";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // crtlAdminEditCohort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAD_CohortSave);
            Controls.Add(dg_AD_CohortEdit);
            Controls.Add(btnAD_CohortFind);
            Controls.Add(txtAD_Cohort_Search_ModuleCode);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "crtlAdminEditCohort";
            Size = new Size(1003, 740);
            ((System.ComponentModel.ISupportInitialize)dg_AD_CohortEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAD_CohortSave;
        private DataGridView dg_AD_CohortEdit;
        private Button btnAD_CohortFind;
        private TextBox txtAD_Cohort_Search_ModuleCode;
        private Label label3;
        private Panel panel1;
        private Label label2;
    }
}
