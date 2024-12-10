namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    partial class ctrlAdminAddModules
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
            btnGenerateModuleCode = new Button();
            btnAMCreateModule = new Button();
            txtAMModCode = new TextBox();
            label5 = new Label();
            txtAMModuleDescription = new TextBox();
            label4 = new Label();
            cmbAMModuleCoreOptional = new ComboBox();
            label3 = new Label();
            txtAMModuleTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtAMParentProgCode = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(171, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 1);
            panel1.TabIndex = 60;
            // 
            // btnGenerateModuleCode
            // 
            btnGenerateModuleCode.BackColor = Color.RoyalBlue;
            btnGenerateModuleCode.Cursor = Cursors.Hand;
            btnGenerateModuleCode.FlatAppearance.BorderSize = 0;
            btnGenerateModuleCode.FlatStyle = FlatStyle.Flat;
            btnGenerateModuleCode.Font = new Font("Microsoft YaHei UI", 10F);
            btnGenerateModuleCode.ForeColor = Color.White;
            btnGenerateModuleCode.ImeMode = ImeMode.NoControl;
            btnGenerateModuleCode.Location = new Point(407, 337);
            btnGenerateModuleCode.Name = "btnGenerateModuleCode";
            btnGenerateModuleCode.Size = new Size(170, 29);
            btnGenerateModuleCode.TabIndex = 59;
            btnGenerateModuleCode.Text = "Generate Code";
            btnGenerateModuleCode.UseVisualStyleBackColor = false;
            btnGenerateModuleCode.Click += btnGenerateModuleCode_Click;
            // 
            // btnAMCreateModule
            // 
            btnAMCreateModule.BackColor = Color.RoyalBlue;
            btnAMCreateModule.Cursor = Cursors.Hand;
            btnAMCreateModule.FlatAppearance.BorderSize = 0;
            btnAMCreateModule.FlatStyle = FlatStyle.Flat;
            btnAMCreateModule.Font = new Font("Microsoft YaHei UI", 12F);
            btnAMCreateModule.ForeColor = Color.White;
            btnAMCreateModule.ImeMode = ImeMode.NoControl;
            btnAMCreateModule.Location = new Point(549, 687);
            btnAMCreateModule.Name = "btnAMCreateModule";
            btnAMCreateModule.Size = new Size(283, 37);
            btnAMCreateModule.TabIndex = 58;
            btnAMCreateModule.Text = "Create Module";
            btnAMCreateModule.UseVisualStyleBackColor = false;
            btnAMCreateModule.Click += btnAMCreateModule_Click;
            // 
            // txtAMModCode
            // 
            txtAMModCode.BackColor = Color.WhiteSmoke;
            txtAMModCode.BorderStyle = BorderStyle.FixedSingle;
            txtAMModCode.Font = new Font("Segoe UI", 12F);
            txtAMModCode.Location = new Point(171, 337);
            txtAMModCode.Name = "txtAMModCode";
            txtAMModCode.Size = new Size(220, 29);
            txtAMModCode.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 14F);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(171, 310);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 56;
            label5.Text = "Module Code";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtAMModuleDescription
            // 
            txtAMModuleDescription.BackColor = Color.WhiteSmoke;
            txtAMModuleDescription.BorderStyle = BorderStyle.FixedSingle;
            txtAMModuleDescription.Font = new Font("Segoe UI", 12F);
            txtAMModuleDescription.Location = new Point(171, 419);
            txtAMModuleDescription.Multiline = true;
            txtAMModuleDescription.Name = "txtAMModuleDescription";
            txtAMModuleDescription.Size = new Size(661, 238);
            txtAMModuleDescription.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 14F);
            label4.ForeColor = Color.Black;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(171, 390);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 54;
            label4.Text = "Module Description";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbAMModuleCoreOptional
            // 
            cmbAMModuleCoreOptional.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAMModuleCoreOptional.FlatStyle = FlatStyle.System;
            cmbAMModuleCoreOptional.Font = new Font("Segoe UI", 12F);
            cmbAMModuleCoreOptional.FormattingEnabled = true;
            cmbAMModuleCoreOptional.Items.AddRange(new object[] { "Core", "Optional" });
            cmbAMModuleCoreOptional.Location = new Point(171, 183);
            cmbAMModuleCoreOptional.Name = "cmbAMModuleCoreOptional";
            cmbAMModuleCoreOptional.Size = new Size(220, 29);
            cmbAMModuleCoreOptional.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(171, 155);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 52;
            label3.Text = "Core/ Optional";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtAMModuleTitle
            // 
            txtAMModuleTitle.BackColor = Color.WhiteSmoke;
            txtAMModuleTitle.BorderStyle = BorderStyle.FixedSingle;
            txtAMModuleTitle.Font = new Font("Segoe UI", 12F);
            txtAMModuleTitle.Location = new Point(407, 183);
            txtAMModuleTitle.Name = "txtAMModuleTitle";
            txtAMModuleTitle.Size = new Size(425, 29);
            txtAMModuleTitle.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 14F);
            label2.ForeColor = Color.Black;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(407, 155);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 50;
            label2.Text = "Module Title";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 18F);
            label1.ForeColor = Color.RoyalBlue;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(171, 55);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 49;
            label1.Text = "Add Module";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtAMParentProgCode
            // 
            txtAMParentProgCode.BackColor = Color.WhiteSmoke;
            txtAMParentProgCode.BorderStyle = BorderStyle.FixedSingle;
            txtAMParentProgCode.Font = new Font("Segoe UI", 12F);
            txtAMParentProgCode.Location = new Point(171, 261);
            txtAMParentProgCode.Name = "txtAMParentProgCode";
            txtAMParentProgCode.Size = new Size(425, 29);
            txtAMParentProgCode.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 14F);
            label6.ForeColor = Color.Black;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(171, 234);
            label6.Name = "label6";
            label6.Size = new Size(211, 25);
            label6.TabIndex = 61;
            label6.Text = "Parent Programme Code";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ctrlAdminAddModules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtAMParentProgCode);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(btnGenerateModuleCode);
            Controls.Add(btnAMCreateModule);
            Controls.Add(txtAMModCode);
            Controls.Add(label5);
            Controls.Add(txtAMModuleDescription);
            Controls.Add(label4);
            Controls.Add(cmbAMModuleCoreOptional);
            Controls.Add(label3);
            Controls.Add(txtAMModuleTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ctrlAdminAddModules";
            Size = new Size(1003, 740);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnGenerateModuleCode;
        private Button btnAMCreateModule;
        private TextBox txtAMModCode;
        private Label label5;
        private TextBox txtAMModuleDescription;
        private Label label4;
        private ComboBox cmbAMModuleCoreOptional;
        private Label label3;
        private TextBox txtAMModuleTitle;
        private Label label2;
        private Label label1;
        private TextBox txtAMParentProgCode;
        private Label label6;
    }
}
