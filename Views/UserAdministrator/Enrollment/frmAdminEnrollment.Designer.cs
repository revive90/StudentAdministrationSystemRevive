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
            dg_AD_StudentEnrollment = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            btn_AD_FindUnenrolled = new Button();
            label3 = new Label();
            cmbEnrollmentStatus = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_AD_StudentEnrollment).BeginInit();
            SuspendLayout();
            // 
            // dg_AD_StudentEnrollment
            // 
            dg_AD_StudentEnrollment.AllowUserToAddRows = false;
            dg_AD_StudentEnrollment.AllowUserToDeleteRows = false;
            dg_AD_StudentEnrollment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_AD_StudentEnrollment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_AD_StudentEnrollment.Location = new Point(26, 149);
            dg_AD_StudentEnrollment.Name = "dg_AD_StudentEnrollment";
            dg_AD_StudentEnrollment.Size = new Size(950, 580);
            dg_AD_StudentEnrollment.TabIndex = 66;
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
            // btn_AD_FindUnenrolled
            // 
            btn_AD_FindUnenrolled.BackColor = Color.RoyalBlue;
            btn_AD_FindUnenrolled.Cursor = Cursors.Hand;
            btn_AD_FindUnenrolled.FlatAppearance.BorderColor = Color.RoyalBlue;
            btn_AD_FindUnenrolled.FlatAppearance.BorderSize = 0;
            btn_AD_FindUnenrolled.FlatStyle = FlatStyle.Flat;
            btn_AD_FindUnenrolled.Font = new Font("Microsoft YaHei UI", 10F);
            btn_AD_FindUnenrolled.ForeColor = Color.White;
            btn_AD_FindUnenrolled.ImeMode = ImeMode.NoControl;
            btn_AD_FindUnenrolled.Location = new Point(550, 105);
            btn_AD_FindUnenrolled.Name = "btn_AD_FindUnenrolled";
            btn_AD_FindUnenrolled.Size = new Size(205, 29);
            btn_AD_FindUnenrolled.TabIndex = 80;
            btn_AD_FindUnenrolled.Text = "Find";
            btn_AD_FindUnenrolled.UseVisualStyleBackColor = false;
            btn_AD_FindUnenrolled.Click += btn_AD_FindUnenrolled_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(121, 108);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 78;
            label3.Text = "Search for";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbEnrollmentStatus
            // 
            cmbEnrollmentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEnrollmentStatus.FlatStyle = FlatStyle.System;
            cmbEnrollmentStatus.Font = new Font("Segoe UI", 12F);
            cmbEnrollmentStatus.FormattingEnabled = true;
            cmbEnrollmentStatus.Items.AddRange(new object[] { "Not Yet Enrolled", "Enrolled" });
            cmbEnrollmentStatus.Location = new Point(219, 105);
            cmbEnrollmentStatus.Name = "cmbEnrollmentStatus";
            cmbEnrollmentStatus.Size = new Size(296, 29);
            cmbEnrollmentStatus.TabIndex = 81;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei UI", 10F);
            button1.ForeColor = Color.RoyalBlue;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(771, 105);
            button1.Name = "button1";
            button1.Size = new Size(205, 29);
            button1.TabIndex = 82;
            button1.Text = "Save All Changes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmAdminEnrollment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 769);
            Controls.Add(button1);
            Controls.Add(cmbEnrollmentStatus);
            Controls.Add(btn_AD_FindUnenrolled);
            Controls.Add(label3);
            Controls.Add(dg_AD_StudentEnrollment);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminEnrollment";
            Text = "frmAdminEnrollment";
            Load += frmAdminEnrollment_Load;
            ((System.ComponentModel.ISupportInitialize)dg_AD_StudentEnrollment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dg_AD_StudentEnrollment;
        private Panel panel1;
        private Label label2;
        private Button btn_AD_FindUnenrolled;
        private Label label3;
        private ComboBox cmbEnrollmentStatus;
        private Button button1;
    }
}