namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    partial class ctrlAdminEditProgrammes
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
            btnEPFindProg = new Button();
            txtEPProgTitle = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            dgEPEditProgTable = new DataGridView();
            btnEPSaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEPEditProgTable).BeginInit();
            SuspendLayout();
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
            btnEPFindProg.Location = new Point(763, 139);
            btnEPFindProg.Name = "btnEPFindProg";
            btnEPFindProg.Size = new Size(205, 29);
            btnEPFindProg.TabIndex = 63;
            btnEPFindProg.Text = "Find";
            btnEPFindProg.UseVisualStyleBackColor = false;
            btnEPFindProg.Click += btnEPFindProg_Click;
            // 
            // txtEPProgTitle
            // 
            txtEPProgTitle.BackColor = Color.WhiteSmoke;
            txtEPProgTitle.BorderStyle = BorderStyle.FixedSingle;
            txtEPProgTitle.Font = new Font("Segoe UI", 12F);
            txtEPProgTitle.Location = new Point(18, 140);
            txtEPProgTitle.Name = "txtEPProgTitle";
            txtEPProgTitle.Size = new Size(715, 29);
            txtEPProgTitle.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(18, 103);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 61;
            label3.Text = "Programme Title";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(18, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(18, 24);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 59;
            label2.Text = "Edit Programme";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dgEPEditProgTable
            // 
            dgEPEditProgTable.AllowUserToAddRows = false;
            dgEPEditProgTable.AllowUserToDeleteRows = false;
            dgEPEditProgTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEPEditProgTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEPEditProgTable.Location = new Point(18, 198);
            dgEPEditProgTable.Name = "dgEPEditProgTable";
            dgEPEditProgTable.Size = new Size(950, 447);
            dgEPEditProgTable.TabIndex = 64;
            // 
            // btnEPSaveChanges
            // 
            btnEPSaveChanges.BackColor = Color.RoyalBlue;
            btnEPSaveChanges.Cursor = Cursors.Hand;
            btnEPSaveChanges.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnEPSaveChanges.FlatAppearance.BorderSize = 0;
            btnEPSaveChanges.FlatStyle = FlatStyle.Flat;
            btnEPSaveChanges.Font = new Font("Microsoft YaHei UI", 10F);
            btnEPSaveChanges.ForeColor = Color.White;
            btnEPSaveChanges.ImeMode = ImeMode.NoControl;
            btnEPSaveChanges.Location = new Point(763, 668);
            btnEPSaveChanges.Name = "btnEPSaveChanges";
            btnEPSaveChanges.Size = new Size(205, 29);
            btnEPSaveChanges.TabIndex = 65;
            btnEPSaveChanges.Text = "Save Changes";
            btnEPSaveChanges.UseVisualStyleBackColor = false;
            btnEPSaveChanges.Click += btnEPSaveChanges_Click;
            // 
            // ctrlAdminEditProgrammes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnEPSaveChanges);
            Controls.Add(dgEPEditProgTable);
            Controls.Add(btnEPFindProg);
            Controls.Add(txtEPProgTitle);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAdminEditProgrammes";
            Size = new Size(1003, 740);
            ((System.ComponentModel.ISupportInitialize)dgEPEditProgTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEPFindProg;
        private TextBox txtEPProgTitle;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private DataGridView dgEPEditProgTable;
        private Button btnEPSaveChanges;
    }
}
