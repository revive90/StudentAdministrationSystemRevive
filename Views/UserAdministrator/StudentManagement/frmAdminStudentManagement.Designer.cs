﻿namespace StudentAdministrationSystemRevive.Views.Administrator.StudentManagement
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
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 25F);
            label1.ForeColor = Color.RoyalBlue;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 46);
            label1.TabIndex = 31;
            label1.Text = "Student Management";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei UI", 12F);
            button2.ForeColor = Color.White;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(871, 12);
            button2.Name = "button2";
            button2.Size = new Size(120, 37);
            button2.TabIndex = 30;
            button2.Text = "Reload";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmAdminStudentManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 769);
            Controls.Add(label1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminStudentManagement";
            Text = "frmStudentManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
    }
}