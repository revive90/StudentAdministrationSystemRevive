namespace StudentAdministrationSystemRevive.Views.Administrator.Enrollment
{
    partial class frmAdminEnrollment
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
            btnFindProg = new Button();
            dgVPProgTable = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            btnEPFindProg = new Button();
            label3 = new Label();
            cmbProgLength = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgVPProgTable).BeginInit();
            SuspendLayout();
            // 
            // btnFindProg
            // 
            btnFindProg.BackColor = Color.RoyalBlue;
            btnFindProg.Cursor = Cursors.Hand;
            btnFindProg.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnFindProg.FlatAppearance.BorderSize = 0;
            btnFindProg.FlatStyle = FlatStyle.Flat;
            btnFindProg.Font = new Font("Microsoft YaHei UI", 10F);
            btnFindProg.ForeColor = Color.White;
            btnFindProg.ImeMode = ImeMode.NoControl;
            btnFindProg.Location = new Point(771, 42);
            btnFindProg.Name = "btnFindProg";
            btnFindProg.Size = new Size(205, 29);
            btnFindProg.TabIndex = 67;
            btnFindProg.Text = "Reload";
            btnFindProg.UseVisualStyleBackColor = false;
            // 
            // dgVPProgTable
            // 
            dgVPProgTable.AllowUserToAddRows = false;
            dgVPProgTable.AllowUserToDeleteRows = false;
            dgVPProgTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVPProgTable.Location = new Point(26, 149);
            dgVPProgTable.Name = "dgVPProgTable";
            dgVPProgTable.Size = new Size(950, 580);
            dgVPProgTable.TabIndex = 66;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(26, 87);
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
            label2.Location = new Point(26, 39);
            label2.Name = "label2";
            label2.Size = new Size(206, 32);
            label2.TabIndex = 64;
            label2.Text = "Student Enrollment";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnEPFindProg
            // 
            btnEPFindProg.BackColor = Color.RoyalBlue;
            btnEPFindProg.Cursor = Cursors.Hand;
            btnEPFindProg.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnEPFindProg.FlatAppearance.BorderSize = 0;
            btnEPFindProg.FlatStyle = FlatStyle.Flat;
            btnEPFindProg.Font = new Font("Microsoft YaHei UI", 10F);
            btnEPFindProg.ForeColor = Color.White;
            btnEPFindProg.ImeMode = ImeMode.NoControl;
            btnEPFindProg.Location = new Point(771, 105);
            btnEPFindProg.Name = "btnEPFindProg";
            btnEPFindProg.Size = new Size(205, 29);
            btnEPFindProg.TabIndex = 80;
            btnEPFindProg.Text = "Find";
            btnEPFindProg.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(342, 108);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 78;
            label3.Text = "Search for";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbProgLength
            // 
            cmbProgLength.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgLength.FlatStyle = FlatStyle.System;
            cmbProgLength.Font = new Font("Segoe UI", 12F);
            cmbProgLength.FormattingEnabled = true;
            cmbProgLength.Items.AddRange(new object[] { "Not Enrolled", "Enrolled" });
            cmbProgLength.Location = new Point(440, 105);
            cmbProgLength.Name = "cmbProgLength";
            cmbProgLength.Size = new Size(296, 29);
            cmbProgLength.TabIndex = 81;
            // 
            // frmAdminEnrollment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 769);
            Controls.Add(cmbProgLength);
            Controls.Add(btnEPFindProg);
            Controls.Add(label3);
            Controls.Add(btnFindProg);
            Controls.Add(dgVPProgTable);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminEnrollment";
            Text = "frmAdminEnrollment";
            ((System.ComponentModel.ISupportInitialize)dgVPProgTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFindProg;
        private DataGridView dgVPProgTable;
        private Panel panel1;
        private Label label2;
        private Button btnEPFindProg;
        private Label label3;
        private ComboBox cmbProgLength;
    }
}