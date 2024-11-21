namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    partial class ctrlAdminGradeAssessment
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
            btnSaveChanges = new Button();
            dgEMEditModuleTable = new DataGridView();
            btnEPFindProg = new Button();
            txtEMModuleTitle = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgEMEditModuleTable).BeginInit();
            SuspendLayout();
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.RoyalBlue;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Microsoft YaHei UI", 10F);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.ImeMode = ImeMode.NoControl;
            btnSaveChanges.Location = new Point(756, 656);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(220, 29);
            btnSaveChanges.TabIndex = 99;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // dgEMEditModuleTable
            // 
            dgEMEditModuleTable.AllowUserToAddRows = false;
            dgEMEditModuleTable.AllowUserToDeleteRows = false;
            dgEMEditModuleTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEMEditModuleTable.Location = new Point(26, 178);
            dgEMEditModuleTable.Name = "dgEMEditModuleTable";
            dgEMEditModuleTable.Size = new Size(950, 463);
            dgEMEditModuleTable.TabIndex = 98;
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
            btnEPFindProg.Location = new Point(756, 126);
            btnEPFindProg.Name = "btnEPFindProg";
            btnEPFindProg.Size = new Size(220, 30);
            btnEPFindProg.TabIndex = 97;
            btnEPFindProg.Text = "Find";
            btnEPFindProg.UseVisualStyleBackColor = false;
            // 
            // txtEMModuleTitle
            // 
            txtEMModuleTitle.BackColor = Color.WhiteSmoke;
            txtEMModuleTitle.BorderStyle = BorderStyle.FixedSingle;
            txtEMModuleTitle.Font = new Font("Segoe UI", 12F);
            txtEMModuleTitle.Location = new Point(26, 127);
            txtEMModuleTitle.Name = "txtEMModuleTitle";
            txtEMModuleTitle.Size = new Size(710, 29);
            txtEMModuleTitle.TabIndex = 96;
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
            // ctrlAdminGradeAssessment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSaveChanges);
            Controls.Add(dgEMEditModuleTable);
            Controls.Add(btnEPFindProg);
            Controls.Add(txtEMModuleTitle);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAdminGradeAssessment";
            Size = new Size(1003, 712);
            ((System.ComponentModel.ISupportInitialize)dgEMEditModuleTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSaveChanges;
        private DataGridView dgEMEditModuleTable;
        private Button btnEPFindProg;
        private TextBox txtEMModuleTitle;
        private Label label3;
        private Panel panel1;
        private Label label2;
    }
}
