namespace StudentAdministrationSystemRevive.Views.Administrator.Results
{
    partial class frmAdminResults
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
            btnAD_ReloadStudentResults = new Button();
            dg_AD_Student_Results = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_AD_Student_Results).BeginInit();
            SuspendLayout();
            // 
            // btnAD_ReloadStudentResults
            // 
            btnAD_ReloadStudentResults.BackColor = Color.RoyalBlue;
            btnAD_ReloadStudentResults.Cursor = Cursors.Hand;
            btnAD_ReloadStudentResults.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnAD_ReloadStudentResults.FlatAppearance.BorderSize = 0;
            btnAD_ReloadStudentResults.FlatStyle = FlatStyle.Flat;
            btnAD_ReloadStudentResults.Font = new Font("Microsoft YaHei UI", 10F);
            btnAD_ReloadStudentResults.ForeColor = Color.White;
            btnAD_ReloadStudentResults.ImeMode = ImeMode.NoControl;
            btnAD_ReloadStudentResults.Location = new Point(769, 26);
            btnAD_ReloadStudentResults.Name = "btnAD_ReloadStudentResults";
            btnAD_ReloadStudentResults.Size = new Size(205, 29);
            btnAD_ReloadStudentResults.TabIndex = 84;
            btnAD_ReloadStudentResults.Text = "Reload";
            btnAD_ReloadStudentResults.UseVisualStyleBackColor = false;
            // 
            // dg_AD_Student_Results
            // 
            dg_AD_Student_Results.AllowUserToAddRows = false;
            dg_AD_Student_Results.AllowUserToDeleteRows = false;
            dg_AD_Student_Results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_AD_Student_Results.Location = new Point(24, 94);
            dg_AD_Student_Results.Name = "dg_AD_Student_Results";
            dg_AD_Student_Results.ReadOnly = true;
            dg_AD_Student_Results.Size = new Size(950, 585);
            dg_AD_Student_Results.TabIndex = 81;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(24, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(24, 20);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 79;
            label2.Text = "Student Results";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei UI", 10F);
            button1.ForeColor = Color.White;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(769, 703);
            button1.Name = "button1";
            button1.Size = new Size(205, 29);
            button1.TabIndex = 85;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmAdminResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 769);
            Controls.Add(button1);
            Controls.Add(btnAD_ReloadStudentResults);
            Controls.Add(dg_AD_Student_Results);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminResults";
            Text = "frmAdminResults";
            ((System.ComponentModel.ISupportInitialize)dg_AD_Student_Results).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAD_ReloadStudentResults;
        private DataGridView dg_AD_Student_Results;
        private Panel panel1;
        private Label label2;
        private Button button1;
    }
}