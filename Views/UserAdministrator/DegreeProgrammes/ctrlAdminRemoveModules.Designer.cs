namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    partial class ctrlAdminRemoveModules
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
            btnRMFindModule = new Button();
            txtRMModuleTitle = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnRMRemoveModule = new Button();
            txtRMModuleCode = new TextBox();
            label5 = new Label();
            dgRMRemoveModuleTable = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgRMRemoveModuleTable).BeginInit();
            SuspendLayout();
            // 
            // btnRMFindModule
            // 
            btnRMFindModule.BackColor = Color.RoyalBlue;
            btnRMFindModule.Cursor = Cursors.Hand;
            btnRMFindModule.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnRMFindModule.FlatAppearance.BorderSize = 0;
            btnRMFindModule.FlatStyle = FlatStyle.Flat;
            btnRMFindModule.Font = new Font("Microsoft YaHei UI", 10F);
            btnRMFindModule.ForeColor = Color.White;
            btnRMFindModule.ImeMode = ImeMode.NoControl;
            btnRMFindModule.Location = new Point(771, 174);
            btnRMFindModule.Name = "btnRMFindModule";
            btnRMFindModule.Size = new Size(205, 29);
            btnRMFindModule.TabIndex = 68;
            btnRMFindModule.Text = "Find";
            btnRMFindModule.UseVisualStyleBackColor = false;
            btnRMFindModule.Click += btnRMFindModule_Click;
            // 
            // txtRMModuleTitle
            // 
            txtRMModuleTitle.BackColor = Color.WhiteSmoke;
            txtRMModuleTitle.BorderStyle = BorderStyle.FixedSingle;
            txtRMModuleTitle.Font = new Font("Segoe UI", 12F);
            txtRMModuleTitle.Location = new Point(26, 175);
            txtRMModuleTitle.Name = "txtRMModuleTitle";
            txtRMModuleTitle.Size = new Size(715, 29);
            txtRMModuleTitle.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(26, 138);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 66;
            label3.Text = "Module Title";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(26, 664);
            label1.Name = "label1";
            label1.Size = new Size(257, 21);
            label1.TabIndex = 65;
            label1.Text = "** Removing a module is irreversible! **";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnRMRemoveModule
            // 
            btnRMRemoveModule.BackColor = Color.Red;
            btnRMRemoveModule.Cursor = Cursors.Hand;
            btnRMRemoveModule.FlatAppearance.BorderColor = Color.OrangeRed;
            btnRMRemoveModule.FlatAppearance.BorderSize = 0;
            btnRMRemoveModule.FlatStyle = FlatStyle.Flat;
            btnRMRemoveModule.Font = new Font("Microsoft YaHei UI", 10F);
            btnRMRemoveModule.ForeColor = Color.White;
            btnRMRemoveModule.ImeMode = ImeMode.NoControl;
            btnRMRemoveModule.Location = new Point(335, 604);
            btnRMRemoveModule.Name = "btnRMRemoveModule";
            btnRMRemoveModule.Size = new Size(205, 29);
            btnRMRemoveModule.TabIndex = 64;
            btnRMRemoveModule.Text = "Remove Module";
            btnRMRemoveModule.UseVisualStyleBackColor = false;
            btnRMRemoveModule.Click += btnRMRemoveModule_Click;
            // 
            // txtRMModuleCode
            // 
            txtRMModuleCode.BackColor = Color.WhiteSmoke;
            txtRMModuleCode.BorderStyle = BorderStyle.FixedSingle;
            txtRMModuleCode.Font = new Font("Segoe UI", 12F);
            txtRMModuleCode.Location = new Point(26, 604);
            txtRMModuleCode.Name = "txtRMModuleCode";
            txtRMModuleCode.Size = new Size(276, 29);
            txtRMModuleCode.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(26, 567);
            label5.Name = "label5";
            label5.Size = new Size(222, 21);
            label5.TabIndex = 62;
            label5.Text = "Enter Module Code to Confirm";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dgRMRemoveModuleTable
            // 
            dgRMRemoveModuleTable.AllowUserToAddRows = false;
            dgRMRemoveModuleTable.AllowUserToDeleteRows = false;
            dgRMRemoveModuleTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRMRemoveModuleTable.Location = new Point(26, 234);
            dgRMRemoveModuleTable.Name = "dgRMRemoveModuleTable";
            dgRMRemoveModuleTable.ReadOnly = true;
            dgRMRemoveModuleTable.Size = new Size(950, 285);
            dgRMRemoveModuleTable.TabIndex = 61;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(26, 104);
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
            label2.Location = new Point(26, 56);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 59;
            label2.Text = "Remove Module";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ctrlAdminRemoveModules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnRMFindModule);
            Controls.Add(txtRMModuleTitle);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnRMRemoveModule);
            Controls.Add(txtRMModuleCode);
            Controls.Add(label5);
            Controls.Add(dgRMRemoveModuleTable);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAdminRemoveModules";
            Size = new Size(1003, 740);
            ((System.ComponentModel.ISupportInitialize)dgRMRemoveModuleTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRMFindModule;
        private TextBox txtRMModuleTitle;
        private Label label3;
        private Label label1;
        private Button btnRMRemoveModule;
        private TextBox txtRMModuleCode;
        private Label label5;
        private DataGridView dgRMRemoveModuleTable;
        private Panel panel1;
        private Label label2;
    }
}
