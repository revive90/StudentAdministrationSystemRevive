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
            txtStudentInfo = new TextBox();
            cmbSearchByItem = new ComboBox();
            btnFindStudent = new Button();
            label3 = new Label();
            btnReloadStudentInfo = new Button();
            dgVPProgTable = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgVPProgTable).BeginInit();
            SuspendLayout();
            // 
            // txtStudentInfo
            // 
            txtStudentInfo.BackColor = Color.WhiteSmoke;
            txtStudentInfo.BorderStyle = BorderStyle.FixedSingle;
            txtStudentInfo.Font = new Font("Segoe UI", 12F);
            txtStudentInfo.Location = new Point(334, 105);
            txtStudentInfo.Name = "txtStudentInfo";
            txtStudentInfo.Size = new Size(417, 29);
            txtStudentInfo.TabIndex = 98;
            // 
            // cmbSearchByItem
            // 
            cmbSearchByItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchByItem.FlatStyle = FlatStyle.System;
            cmbSearchByItem.Font = new Font("Segoe UI", 12F);
            cmbSearchByItem.FormattingEnabled = true;
            cmbSearchByItem.Items.AddRange(new object[] { "Student Name", "Student Number" });
            cmbSearchByItem.Location = new Point(127, 105);
            cmbSearchByItem.Name = "cmbSearchByItem";
            cmbSearchByItem.Size = new Size(189, 29);
            cmbSearchByItem.TabIndex = 97;
            // 
            // btnFindStudent
            // 
            btnFindStudent.BackColor = Color.RoyalBlue;
            btnFindStudent.Cursor = Cursors.Hand;
            btnFindStudent.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnFindStudent.FlatAppearance.BorderSize = 0;
            btnFindStudent.FlatStyle = FlatStyle.Flat;
            btnFindStudent.Font = new Font("Microsoft YaHei UI", 10F);
            btnFindStudent.ForeColor = Color.White;
            btnFindStudent.ImeMode = ImeMode.NoControl;
            btnFindStudent.Location = new Point(771, 105);
            btnFindStudent.Name = "btnFindStudent";
            btnFindStudent.Size = new Size(205, 29);
            btnFindStudent.TabIndex = 96;
            btnFindStudent.Text = "Find";
            btnFindStudent.UseVisualStyleBackColor = false;
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
            // btnReloadStudentInfo
            // 
            btnReloadStudentInfo.BackColor = Color.RoyalBlue;
            btnReloadStudentInfo.Cursor = Cursors.Hand;
            btnReloadStudentInfo.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnReloadStudentInfo.FlatAppearance.BorderSize = 0;
            btnReloadStudentInfo.FlatStyle = FlatStyle.Flat;
            btnReloadStudentInfo.Font = new Font("Microsoft YaHei UI", 10F);
            btnReloadStudentInfo.ForeColor = Color.White;
            btnReloadStudentInfo.ImeMode = ImeMode.NoControl;
            btnReloadStudentInfo.Location = new Point(771, 42);
            btnReloadStudentInfo.Name = "btnReloadStudentInfo";
            btnReloadStudentInfo.Size = new Size(205, 29);
            btnReloadStudentInfo.TabIndex = 94;
            btnReloadStudentInfo.Text = "Reload";
            btnReloadStudentInfo.UseVisualStyleBackColor = false;
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
            Controls.Add(txtStudentInfo);
            Controls.Add(cmbSearchByItem);
            Controls.Add(btnFindStudent);
            Controls.Add(label3);
            Controls.Add(btnReloadStudentInfo);
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

        private TextBox txtStudentInfo;
        private ComboBox cmbSearchByItem;
        private Button btnFindStudent;
        private Label label3;
        private Button btnReloadStudentInfo;
        private DataGridView dgVPProgTable;
        private Panel panel1;
        private Label label2;
    }
}