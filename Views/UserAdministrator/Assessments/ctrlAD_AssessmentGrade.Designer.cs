namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    partial class ctrlAD_AssessmentGrade
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
            btnAD_AssessmentSaveChanges = new Button();
            dg_AD_AssessmentGrade = new DataGridView();
            btnAD_AssessmentFind = new Button();
            txtAD_Assessment_Search_ID = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_AD_AssessmentGrade).BeginInit();
            SuspendLayout();
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
            btnAD_AssessmentSaveChanges.Location = new Point(756, 656);
            btnAD_AssessmentSaveChanges.Name = "btnAD_AssessmentSaveChanges";
            btnAD_AssessmentSaveChanges.Size = new Size(220, 29);
            btnAD_AssessmentSaveChanges.TabIndex = 99;
            btnAD_AssessmentSaveChanges.Text = "Save Changes";
            btnAD_AssessmentSaveChanges.UseVisualStyleBackColor = false;
            // 
            // dg_AD_AssessmentGrade
            // 
            dg_AD_AssessmentGrade.AllowUserToAddRows = false;
            dg_AD_AssessmentGrade.AllowUserToDeleteRows = false;
            dg_AD_AssessmentGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_AD_AssessmentGrade.Location = new Point(26, 178);
            dg_AD_AssessmentGrade.Name = "dg_AD_AssessmentGrade";
            dg_AD_AssessmentGrade.Size = new Size(950, 463);
            dg_AD_AssessmentGrade.TabIndex = 98;
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
            btnAD_AssessmentFind.Location = new Point(756, 126);
            btnAD_AssessmentFind.Name = "btnAD_AssessmentFind";
            btnAD_AssessmentFind.Size = new Size(220, 30);
            btnAD_AssessmentFind.TabIndex = 97;
            btnAD_AssessmentFind.Text = "Find";
            btnAD_AssessmentFind.UseVisualStyleBackColor = false;
            // 
            // txtAD_Assessment_Search_ID
            // 
            txtAD_Assessment_Search_ID.BackColor = Color.WhiteSmoke;
            txtAD_Assessment_Search_ID.BorderStyle = BorderStyle.FixedSingle;
            txtAD_Assessment_Search_ID.Font = new Font("Segoe UI", 12F);
            txtAD_Assessment_Search_ID.Location = new Point(26, 127);
            txtAD_Assessment_Search_ID.Name = "txtAD_Assessment_Search_ID";
            txtAD_Assessment_Search_ID.Size = new Size(710, 29);
            txtAD_Assessment_Search_ID.TabIndex = 96;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(26, 99);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 95;
            label3.Text = "Assessment ID";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(26, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 94;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(26, 27);
            label2.Name = "label2";
            label2.Size = new Size(229, 32);
            label2.TabIndex = 93;
            label2.Text = "Grade an Assessment";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ctrlAD_AssessmentGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAD_AssessmentSaveChanges);
            Controls.Add(dg_AD_AssessmentGrade);
            Controls.Add(btnAD_AssessmentFind);
            Controls.Add(txtAD_Assessment_Search_ID);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAD_AssessmentGrade";
            Size = new Size(1003, 712);
            ((System.ComponentModel.ISupportInitialize)dg_AD_AssessmentGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAD_AssessmentSaveChanges;
        private DataGridView dg_AD_AssessmentGrade;
        private Button btnAD_AssessmentFind;
        private TextBox txtAD_Assessment_Search_ID;
        private Label label3;
        private Panel panel1;
        private Label label2;
    }
}
