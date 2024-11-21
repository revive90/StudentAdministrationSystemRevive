namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    partial class ctrlAdminDeleteProgramme
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
            dgRemoveProgTable = new DataGridView();
            btnRemoveProg = new Button();
            txtRPProgCode = new TextBox();
            label5 = new Label();
            label1 = new Label();
            txtRPProgTitle = new TextBox();
            label3 = new Label();
            btnFindProg = new Button();
            ((System.ComponentModel.ISupportInitialize)dgRemoveProgTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(24, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(24, 18);
            label2.Name = "label2";
            label2.Size = new Size(221, 32);
            label2.TabIndex = 49;
            label2.Text = "Remove Programme";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dgRemoveProgTable
            // 
            dgRemoveProgTable.AllowUserToAddRows = false;
            dgRemoveProgTable.AllowUserToDeleteRows = false;
            dgRemoveProgTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRemoveProgTable.Location = new Point(24, 196);
            dgRemoveProgTable.Name = "dgRemoveProgTable";
            dgRemoveProgTable.ReadOnly = true;
            dgRemoveProgTable.Size = new Size(950, 285);
            dgRemoveProgTable.TabIndex = 51;
            // 
            // btnRemoveProg
            // 
            btnRemoveProg.BackColor = Color.Red;
            btnRemoveProg.Cursor = Cursors.Hand;
            btnRemoveProg.FlatAppearance.BorderColor = Color.OrangeRed;
            btnRemoveProg.FlatAppearance.BorderSize = 0;
            btnRemoveProg.FlatStyle = FlatStyle.Flat;
            btnRemoveProg.Font = new Font("Microsoft YaHei UI", 10F);
            btnRemoveProg.ForeColor = Color.White;
            btnRemoveProg.ImeMode = ImeMode.NoControl;
            btnRemoveProg.Location = new Point(333, 566);
            btnRemoveProg.Name = "btnRemoveProg";
            btnRemoveProg.Size = new Size(205, 29);
            btnRemoveProg.TabIndex = 54;
            btnRemoveProg.Text = "Remove Programme";
            btnRemoveProg.UseVisualStyleBackColor = false;
            // 
            // txtRPProgCode
            // 
            txtRPProgCode.BackColor = Color.WhiteSmoke;
            txtRPProgCode.BorderStyle = BorderStyle.FixedSingle;
            txtRPProgCode.Font = new Font("Segoe UI", 12F);
            txtRPProgCode.Location = new Point(24, 566);
            txtRPProgCode.Name = "txtRPProgCode";
            txtRPProgCode.Size = new Size(276, 29);
            txtRPProgCode.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(24, 529);
            label5.Name = "label5";
            label5.Size = new Size(252, 21);
            label5.TabIndex = 52;
            label5.Text = "Enter Programme Code to Confirm";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(24, 626);
            label1.Name = "label1";
            label1.Size = new Size(330, 21);
            label1.TabIndex = 55;
            label1.Text = "** Removing a degree programme is irreversible! **";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtRPProgTitle
            // 
            txtRPProgTitle.BackColor = Color.WhiteSmoke;
            txtRPProgTitle.BorderStyle = BorderStyle.FixedSingle;
            txtRPProgTitle.Font = new Font("Segoe UI", 12F);
            txtRPProgTitle.Location = new Point(24, 137);
            txtRPProgTitle.Name = "txtRPProgTitle";
            txtRPProgTitle.Size = new Size(715, 29);
            txtRPProgTitle.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(24, 100);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 56;
            label3.Text = "Programme Title";
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
            btnFindProg.Location = new Point(769, 136);
            btnFindProg.Name = "btnFindProg";
            btnFindProg.Size = new Size(205, 29);
            btnFindProg.TabIndex = 58;
            btnFindProg.Text = "Find";
            btnFindProg.UseVisualStyleBackColor = false;
            // 
            // ctrlAdminDeleteProgramme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnFindProg);
            Controls.Add(txtRPProgTitle);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnRemoveProg);
            Controls.Add(txtRPProgCode);
            Controls.Add(label5);
            Controls.Add(dgRemoveProgTable);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAdminDeleteProgramme";
            Size = new Size(1003, 740);
            ((System.ComponentModel.ISupportInitialize)dgRemoveProgTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView dgRemoveProgTable;
        private Button btnRemoveProg;
        private TextBox txtRPProgCode;
        private Label label5;
        private Label label1;
        private TextBox txtRPProgTitle;
        private Label label3;
        private Button btnFindProg;
    }
}
