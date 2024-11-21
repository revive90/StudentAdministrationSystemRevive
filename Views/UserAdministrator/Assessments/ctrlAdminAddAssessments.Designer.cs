namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    partial class ctrlAdminAddAssessments
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
            txtAMModuleTitle = new TextBox();
            label1 = new Label();
            txtAMModCode = new TextBox();
            label5 = new Label();
            btnAMCreateModule = new Button();
            txtAMModuleDescription = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(26, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(26, 12);
            label2.Name = "label2";
            label2.Size = new Size(181, 32);
            label2.TabIndex = 73;
            label2.Text = "New Assessment";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtAMModuleTitle
            // 
            txtAMModuleTitle.BackColor = Color.WhiteSmoke;
            txtAMModuleTitle.BorderStyle = BorderStyle.FixedSingle;
            txtAMModuleTitle.Font = new Font("Segoe UI", 12F);
            txtAMModuleTitle.Location = new Point(83, 174);
            txtAMModuleTitle.Name = "txtAMModuleTitle";
            txtAMModuleTitle.Size = new Size(425, 29);
            txtAMModuleTitle.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 14F);
            label1.ForeColor = Color.Black;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(83, 146);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 75;
            label1.Text = "Assessment Title";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtAMModCode
            // 
            txtAMModCode.BackColor = Color.WhiteSmoke;
            txtAMModCode.BorderStyle = BorderStyle.FixedSingle;
            txtAMModCode.Enabled = false;
            txtAMModCode.Font = new Font("Segoe UI", 12F);
            txtAMModCode.Location = new Point(516, 174);
            txtAMModCode.Name = "txtAMModCode";
            txtAMModCode.Size = new Size(220, 29);
            txtAMModCode.TabIndex = 78;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 14F);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(516, 146);
            label5.Name = "label5";
            label5.Size = new Size(178, 25);
            label5.TabIndex = 77;
            label5.Text = "Parent Module Code";
            label5.TextAlign = ContentAlignment.BottomLeft;
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
            btnAMCreateModule.Location = new Point(516, 674);
            btnAMCreateModule.Name = "btnAMCreateModule";
            btnAMCreateModule.Size = new Size(283, 37);
            btnAMCreateModule.TabIndex = 81;
            btnAMCreateModule.Text = "Create Module";
            btnAMCreateModule.UseVisualStyleBackColor = false;
            // 
            // txtAMModuleDescription
            // 
            txtAMModuleDescription.BackColor = Color.WhiteSmoke;
            txtAMModuleDescription.BorderStyle = BorderStyle.FixedSingle;
            txtAMModuleDescription.Font = new Font("Segoe UI", 12F);
            txtAMModuleDescription.Location = new Point(138, 406);
            txtAMModuleDescription.Multiline = true;
            txtAMModuleDescription.Name = "txtAMModuleDescription";
            txtAMModuleDescription.Size = new Size(661, 238);
            txtAMModuleDescription.TabIndex = 80;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 14F);
            label4.ForeColor = Color.Black;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(138, 377);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 79;
            label4.Text = "Module Description";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ctrlAdminAddAssessments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAMCreateModule);
            Controls.Add(txtAMModuleDescription);
            Controls.Add(label4);
            Controls.Add(txtAMModCode);
            Controls.Add(label5);
            Controls.Add(txtAMModuleTitle);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAdminAddAssessments";
            Size = new Size(1003, 712);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtAMModuleTitle;
        private Label label1;
        private TextBox txtAMModCode;
        private Label label5;
        private Button btnAMCreateModule;
        private TextBox txtAMModuleDescription;
        private Label label4;
    }
}
