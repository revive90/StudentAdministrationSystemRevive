namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    partial class ctrlAdminEditModules
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
            btnEPFindModule = new Button();
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
            btnSaveChanges.Location = new Point(771, 678);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(205, 29);
            btnSaveChanges.TabIndex = 72;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // dgEMEditModuleTable
            // 
            dgEMEditModuleTable.AllowUserToAddRows = false;
            dgEMEditModuleTable.AllowUserToDeleteRows = false;
            dgEMEditModuleTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEMEditModuleTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEMEditModuleTable.Location = new Point(26, 208);
            dgEMEditModuleTable.Name = "dgEMEditModuleTable";
            dgEMEditModuleTable.Size = new Size(950, 447);
            dgEMEditModuleTable.TabIndex = 71;
            // 
            // btnEPFindModule
            // 
            btnEPFindModule.BackColor = Color.RoyalBlue;
            btnEPFindModule.Cursor = Cursors.Hand;
            btnEPFindModule.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnEPFindModule.FlatAppearance.BorderSize = 0;
            btnEPFindModule.FlatStyle = FlatStyle.Flat;
            btnEPFindModule.Font = new Font("Microsoft YaHei UI", 10F);
            btnEPFindModule.ForeColor = Color.White;
            btnEPFindModule.ImeMode = ImeMode.NoControl;
            btnEPFindModule.Location = new Point(771, 149);
            btnEPFindModule.Name = "btnEPFindModule";
            btnEPFindModule.Size = new Size(205, 29);
            btnEPFindModule.TabIndex = 70;
            btnEPFindModule.Text = "Find";
            btnEPFindModule.UseVisualStyleBackColor = false;
            btnEPFindModule.Click += btnEPFindProg_Click;
            // 
            // txtEMModuleTitle
            // 
            txtEMModuleTitle.BackColor = Color.WhiteSmoke;
            txtEMModuleTitle.BorderStyle = BorderStyle.FixedSingle;
            txtEMModuleTitle.Font = new Font("Segoe UI", 12F);
            txtEMModuleTitle.Location = new Point(26, 150);
            txtEMModuleTitle.Name = "txtEMModuleTitle";
            txtEMModuleTitle.Size = new Size(715, 29);
            txtEMModuleTitle.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(26, 113);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 68;
            label3.Text = "Module Title";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(26, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(26, 34);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 66;
            label2.Text = "Edit Module";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ctrlAdminEditModules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSaveChanges);
            Controls.Add(dgEMEditModuleTable);
            Controls.Add(btnEPFindModule);
            Controls.Add(txtEMModuleTitle);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAdminEditModules";
            Size = new Size(1003, 740);
            ((System.ComponentModel.ISupportInitialize)dgEMEditModuleTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveChanges;
        private DataGridView dgEMEditModuleTable;
        private Button btnEPFindModule;
        private TextBox txtEMModuleTitle;
        private Label label3;
        private Panel panel1;
        private Label label2;
    }
}
