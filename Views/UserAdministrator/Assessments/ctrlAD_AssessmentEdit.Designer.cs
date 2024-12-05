﻿namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    partial class ctrlAD_AssessmentEdit
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
            label2 = new Label();
            btnAD_AssessmentSaveChanges = new Button();
            dg_AD_AssessmentEdit = new DataGridView();
            btnAD_AssessmentFind = new Button();
            txtAD_Assessment_Search_Title = new TextBox();
            label3 = new Label();
            txtAD_Assessment_Search_ModuleCode = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_AD_AssessmentEdit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(24, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(24, 25);
            label2.Name = "label2";
            label2.Size = new Size(286, 32);
            label2.TabIndex = 84;
            label2.Text = "Edit an Existing Assessment";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnAD_AssessmentSaveChanges
            // 
            btnAD_AssessmentSaveChanges.BackColor = Color.RoyalBlue;
            btnAD_AssessmentSaveChanges.Cursor = Cursors.Hand;
            btnAD_AssessmentSaveChanges.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnAD_AssessmentSaveChanges.FlatAppearance.BorderSize = 0;
            btnAD_AssessmentSaveChanges.FlatStyle = FlatStyle.Flat;
            btnAD_AssessmentSaveChanges.Font = new Font("Microsoft YaHei UI", 10F);
            btnAD_AssessmentSaveChanges.ForeColor = Color.White;
            btnAD_AssessmentSaveChanges.ImeMode = ImeMode.NoControl;
            btnAD_AssessmentSaveChanges.Location = new Point(754, 654);
            btnAD_AssessmentSaveChanges.Name = "btnAD_AssessmentSaveChanges";
            btnAD_AssessmentSaveChanges.Size = new Size(220, 29);
            btnAD_AssessmentSaveChanges.TabIndex = 90;
            btnAD_AssessmentSaveChanges.Text = "Save Changes";
            btnAD_AssessmentSaveChanges.UseVisualStyleBackColor = false;
            // 
            // dg_AD_AssessmentEdit
            // 
            dg_AD_AssessmentEdit.AllowUserToAddRows = false;
            dg_AD_AssessmentEdit.AllowUserToDeleteRows = false;
            dg_AD_AssessmentEdit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_AD_AssessmentEdit.Location = new Point(24, 174);
            dg_AD_AssessmentEdit.Name = "dg_AD_AssessmentEdit";
            dg_AD_AssessmentEdit.Size = new Size(950, 463);
            dg_AD_AssessmentEdit.TabIndex = 89;
            // 
            // btnAD_AssessmentFind
            // 
            btnAD_AssessmentFind.BackColor = Color.RoyalBlue;
            btnAD_AssessmentFind.Cursor = Cursors.Hand;
            btnAD_AssessmentFind.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnAD_AssessmentFind.FlatAppearance.BorderSize = 0;
            btnAD_AssessmentFind.FlatStyle = FlatStyle.Flat;
            btnAD_AssessmentFind.Font = new Font("Microsoft YaHei UI", 10F);
            btnAD_AssessmentFind.ForeColor = Color.White;
            btnAD_AssessmentFind.ImeMode = ImeMode.NoControl;
            btnAD_AssessmentFind.Location = new Point(754, 124);
            btnAD_AssessmentFind.Name = "btnAD_AssessmentFind";
            btnAD_AssessmentFind.Size = new Size(220, 30);
            btnAD_AssessmentFind.TabIndex = 88;
            btnAD_AssessmentFind.Text = "Find";
            btnAD_AssessmentFind.UseVisualStyleBackColor = false;
            btnAD_AssessmentFind.Click += btnAD_AssessmentFind_Click;
            // 
            // txtAD_Assessment_Search_Title
            // 
            txtAD_Assessment_Search_Title.BackColor = Color.WhiteSmoke;
            txtAD_Assessment_Search_Title.BorderStyle = BorderStyle.FixedSingle;
            txtAD_Assessment_Search_Title.Font = new Font("Segoe UI", 12F);
            txtAD_Assessment_Search_Title.Location = new Point(24, 125);
            txtAD_Assessment_Search_Title.Name = "txtAD_Assessment_Search_Title";
            txtAD_Assessment_Search_Title.Size = new Size(352, 29);
            txtAD_Assessment_Search_Title.TabIndex = 87;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(24, 97);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 86;
            label3.Text = "Assessment Title";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtAD_Assessment_Search_ModuleCode
            // 
            txtAD_Assessment_Search_ModuleCode.BackColor = Color.WhiteSmoke;
            txtAD_Assessment_Search_ModuleCode.BorderStyle = BorderStyle.FixedSingle;
            txtAD_Assessment_Search_ModuleCode.Font = new Font("Segoe UI", 12F);
            txtAD_Assessment_Search_ModuleCode.Location = new Point(394, 125);
            txtAD_Assessment_Search_ModuleCode.Name = "txtAD_Assessment_Search_ModuleCode";
            txtAD_Assessment_Search_ModuleCode.Size = new Size(340, 29);
            txtAD_Assessment_Search_ModuleCode.TabIndex = 92;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 14F);
            label1.ForeColor = Color.Black;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(394, 97);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 91;
            label1.Text = "Module Code";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ctrlAD_AssessmentEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtAD_Assessment_Search_ModuleCode);
            Controls.Add(label1);
            Controls.Add(btnAD_AssessmentSaveChanges);
            Controls.Add(dg_AD_AssessmentEdit);
            Controls.Add(btnAD_AssessmentFind);
            Controls.Add(txtAD_Assessment_Search_Title);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAD_AssessmentEdit";
            Size = new Size(1003, 712);
            ((System.ComponentModel.ISupportInitialize)dg_AD_AssessmentEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Button btnAD_AssessmentSaveChanges;
        private DataGridView dg_AD_AssessmentEdit;
        private Button btnAD_AssessmentFind;
        private TextBox txtAD_Assessment_Search_Title;
        private Label label3;
        private TextBox txtAD_Assessment_Search_ModuleCode;
        private Label label1;
    }
}