namespace StudentAdministrationSystemRevive.Views.Administrator.StudentManagement
{
    partial class frmAdminStudentManagement
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
            txtEMModuleTitle = new TextBox();
            cmbProgLength = new ComboBox();
            btnEPFindProg = new Button();
            label3 = new Label();
            btnFindProg = new Button();
            dgVPProgTable = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgVPProgTable).BeginInit();
            SuspendLayout();
            // 
            // txtEMModuleTitle
            // 
            txtEMModuleTitle.BackColor = Color.WhiteSmoke;
            txtEMModuleTitle.BorderStyle = BorderStyle.FixedSingle;
            txtEMModuleTitle.Font = new Font("Segoe UI", 12F);
            txtEMModuleTitle.Location = new Point(334, 105);
            txtEMModuleTitle.Name = "txtEMModuleTitle";
            txtEMModuleTitle.Size = new Size(417, 29);
            txtEMModuleTitle.TabIndex = 98;
            // 
            // cmbProgLength
            // 
            cmbProgLength.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgLength.FlatStyle = FlatStyle.System;
            cmbProgLength.Font = new Font("Segoe UI", 12F);
            cmbProgLength.FormattingEnabled = true;
            cmbProgLength.Items.AddRange(new object[] { "Student Name", "Student Number" });
            cmbProgLength.Location = new Point(127, 105);
            cmbProgLength.Name = "cmbProgLength";
            cmbProgLength.Size = new Size(189, 29);
            cmbProgLength.TabIndex = 97;
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
            btnEPFindProg.TabIndex = 96;
            btnEPFindProg.Text = "Find";
            btnEPFindProg.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(29, 108);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 95;
            label3.Text = "Search By";
            label3.TextAlign = ContentAlignment.BottomLeft;
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
            btnFindProg.TabIndex = 94;
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
            dgVPProgTable.TabIndex = 93;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(26, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 92;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(26, 39);
            label2.Name = "label2";
            label2.Size = new Size(355, 32);
            label2.TabIndex = 91;
            label2.Text = "Student Information Management";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // frmAdminStudentManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 769);
            Controls.Add(txtEMModuleTitle);
            Controls.Add(cmbProgLength);
            Controls.Add(btnEPFindProg);
            Controls.Add(label3);
            Controls.Add(btnFindProg);
            Controls.Add(dgVPProgTable);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminStudentManagement";
            Text = "frmStudentManagement";
            ((System.ComponentModel.ISupportInitialize)dgVPProgTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEMModuleTitle;
        private ComboBox cmbProgLength;
        private Button btnEPFindProg;
        private Label label3;
        private Button btnFindProg;
        private DataGridView dgVPProgTable;
        private Panel panel1;
        private Label label2;
    }
}