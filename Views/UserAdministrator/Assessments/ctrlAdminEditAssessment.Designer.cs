namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    partial class ctrlAdminEditAssessment
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
            btnSaveChanges = new Button();
            dgEMEditModuleTable = new DataGridView();
            btnEPFindProg = new Button();
            txtEMModuleTitle = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgEMEditModuleTable).BeginInit();
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
            btnSaveChanges.Location = new Point(754, 654);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(220, 29);
            btnSaveChanges.TabIndex = 90;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // dgEMEditModuleTable
            // 
            dgEMEditModuleTable.AllowUserToAddRows = false;
            dgEMEditModuleTable.AllowUserToDeleteRows = false;
            dgEMEditModuleTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEMEditModuleTable.Location = new Point(24, 176);
            dgEMEditModuleTable.Name = "dgEMEditModuleTable";
            dgEMEditModuleTable.Size = new Size(950, 463);
            dgEMEditModuleTable.TabIndex = 89;
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
            btnEPFindProg.Location = new Point(754, 124);
            btnEPFindProg.Name = "btnEPFindProg";
            btnEPFindProg.Size = new Size(220, 30);
            btnEPFindProg.TabIndex = 88;
            btnEPFindProg.Text = "Find";
            btnEPFindProg.UseVisualStyleBackColor = false;
            // 
            // txtEMModuleTitle
            // 
            txtEMModuleTitle.BackColor = Color.WhiteSmoke;
            txtEMModuleTitle.BorderStyle = BorderStyle.FixedSingle;
            txtEMModuleTitle.Font = new Font("Segoe UI", 12F);
            txtEMModuleTitle.Location = new Point(24, 125);
            txtEMModuleTitle.Name = "txtEMModuleTitle";
            txtEMModuleTitle.Size = new Size(352, 29);
            txtEMModuleTitle.TabIndex = 87;
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
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(394, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 29);
            textBox1.TabIndex = 92;
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
            // ctrlAdminEditAssessment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnSaveChanges);
            Controls.Add(dgEMEditModuleTable);
            Controls.Add(btnEPFindProg);
            Controls.Add(txtEMModuleTitle);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAdminEditAssessment";
            Size = new Size(1003, 712);
            ((System.ComponentModel.ISupportInitialize)dgEMEditModuleTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Button btnSaveChanges;
        private DataGridView dgEMEditModuleTable;
        private Button btnEPFindProg;
        private TextBox txtEMModuleTitle;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
    }
}
