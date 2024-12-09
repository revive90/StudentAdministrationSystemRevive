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
            txtAssessmentID = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtStudentID = new TextBox();
            label1 = new Label();
            txtMark = new TextBox();
            label4 = new Label();
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
            btnAD_AssessmentSaveChanges.Click += btnAD_AssessmentSaveChanges_Click;
            // 
            // dg_AD_AssessmentGrade
            // 
            dg_AD_AssessmentGrade.AllowUserToDeleteRows = false;
            dg_AD_AssessmentGrade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_AD_AssessmentGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_AD_AssessmentGrade.Location = new Point(26, 195);
            dg_AD_AssessmentGrade.Name = "dg_AD_AssessmentGrade";
            dg_AD_AssessmentGrade.Size = new Size(950, 446);
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
            btnAD_AssessmentFind.Location = new Point(756, 128);
            btnAD_AssessmentFind.Name = "btnAD_AssessmentFind";
            btnAD_AssessmentFind.Size = new Size(220, 29);
            btnAD_AssessmentFind.TabIndex = 97;
            btnAD_AssessmentFind.Text = "Grade Assessment";
            btnAD_AssessmentFind.UseVisualStyleBackColor = false;
            btnAD_AssessmentFind.Click += btnAD_AssessmentFind_Click;
            // 
            // txtAssessmentID
            // 
            txtAssessmentID.BackColor = Color.WhiteSmoke;
            txtAssessmentID.BorderStyle = BorderStyle.FixedSingle;
            txtAssessmentID.Font = new Font("Segoe UI", 12F);
            txtAssessmentID.Location = new Point(267, 128);
            txtAssessmentID.Name = "txtAssessmentID";
            txtAssessmentID.Size = new Size(230, 29);
            txtAssessmentID.TabIndex = 96;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(267, 100);
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
            // txtStudentID
            // 
            txtStudentID.BackColor = Color.WhiteSmoke;
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.Font = new Font("Segoe UI", 12F);
            txtStudentID.Location = new Point(26, 128);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(230, 29);
            txtStudentID.TabIndex = 101;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 14F);
            label1.ForeColor = Color.Black;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(26, 100);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 100;
            label1.Text = "Student ID";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtMark
            // 
            txtMark.BackColor = Color.WhiteSmoke;
            txtMark.BorderStyle = BorderStyle.FixedSingle;
            txtMark.Font = new Font("Segoe UI", 12F);
            txtMark.Location = new Point(509, 128);
            txtMark.Name = "txtMark";
            txtMark.Size = new Size(230, 29);
            txtMark.TabIndex = 103;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 14F);
            label4.ForeColor = Color.Black;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(509, 100);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 102;
            label4.Text = "Mark";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ctrlAD_AssessmentGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtMark);
            Controls.Add(label4);
            Controls.Add(txtStudentID);
            Controls.Add(label1);
            Controls.Add(btnAD_AssessmentSaveChanges);
            Controls.Add(dg_AD_AssessmentGrade);
            Controls.Add(btnAD_AssessmentFind);
            Controls.Add(txtAssessmentID);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAD_AssessmentGrade";
            Size = new Size(1003, 712);
            Load += ctrlAD_AssessmentGrade_Load;
            ((System.ComponentModel.ISupportInitialize)dg_AD_AssessmentGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAD_AssessmentSaveChanges;
        private DataGridView dg_AD_AssessmentGrade;
        private Button btnAD_AssessmentFind;
        private TextBox txtAssessmentID;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private TextBox txtStudentID;
        private Label label1;
        private TextBox txtMark;
        private Label label4;
    }
}
