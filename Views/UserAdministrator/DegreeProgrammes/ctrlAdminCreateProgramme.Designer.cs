namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    partial class ctrlAdminCreateProgramme
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
            label1 = new Label();
            label2 = new Label();
            txtProgTitle = new TextBox();
            label3 = new Label();
            cmbProgLength = new ComboBox();
            txtProgDescription = new TextBox();
            label4 = new Label();
            txtProgCode = new TextBox();
            label5 = new Label();
            btnCreateProg = new Button();
            btnGenerateProgCode = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 18F);
            label1.ForeColor = Color.RoyalBlue;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(153, 32);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 36;
            label1.Text = "Create Programme";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 14F);
            label2.ForeColor = Color.Black;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(389, 149);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 37;
            label2.Text = "Programme Title";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtProgTitle
            // 
            txtProgTitle.BackColor = Color.WhiteSmoke;
            txtProgTitle.BorderStyle = BorderStyle.FixedSingle;
            txtProgTitle.Font = new Font("Segoe UI", 12F);
            txtProgTitle.Location = new Point(389, 186);
            txtProgTitle.Name = "txtProgTitle";
            txtProgTitle.Size = new Size(425, 29);
            txtProgTitle.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(153, 152);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 40;
            label3.Text = "Programme Length";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbProgLength
            // 
            cmbProgLength.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgLength.FlatStyle = FlatStyle.System;
            cmbProgLength.Font = new Font("Segoe UI", 12F);
            cmbProgLength.FormattingEnabled = true;
            cmbProgLength.Items.AddRange(new object[] { "1 Year", "2 Years" });
            cmbProgLength.Location = new Point(153, 186);
            cmbProgLength.Name = "cmbProgLength";
            cmbProgLength.Size = new Size(220, 29);
            cmbProgLength.TabIndex = 41;
            // 
            // txtProgDescription
            // 
            txtProgDescription.BackColor = Color.WhiteSmoke;
            txtProgDescription.BorderStyle = BorderStyle.FixedSingle;
            txtProgDescription.Font = new Font("Segoe UI", 12F);
            txtProgDescription.Location = new Point(153, 367);
            txtProgDescription.Multiline = true;
            txtProgDescription.Name = "txtProgDescription";
            txtProgDescription.Size = new Size(661, 238);
            txtProgDescription.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 14F);
            label4.ForeColor = Color.Black;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(153, 328);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 42;
            label4.Text = "Programme Description";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtProgCode
            // 
            txtProgCode.BackColor = Color.WhiteSmoke;
            txtProgCode.BorderStyle = BorderStyle.FixedSingle;
            txtProgCode.Enabled = false;
            txtProgCode.Font = new Font("Segoe UI", 12F);
            txtProgCode.Location = new Point(153, 276);
            txtProgCode.Name = "txtProgCode";
            txtProgCode.Size = new Size(220, 29);
            txtProgCode.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 14F);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(153, 242);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 44;
            label5.Text = "Programme Code";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnCreateProg
            // 
            btnCreateProg.BackColor = Color.RoyalBlue;
            btnCreateProg.Cursor = Cursors.Hand;
            btnCreateProg.FlatAppearance.BorderSize = 0;
            btnCreateProg.FlatStyle = FlatStyle.Flat;
            btnCreateProg.Font = new Font("Microsoft YaHei UI", 12F);
            btnCreateProg.ForeColor = Color.White;
            btnCreateProg.ImeMode = ImeMode.NoControl;
            btnCreateProg.Location = new Point(531, 626);
            btnCreateProg.Name = "btnCreateProg";
            btnCreateProg.Size = new Size(283, 37);
            btnCreateProg.TabIndex = 46;
            btnCreateProg.Text = "Create Programme";
            btnCreateProg.UseVisualStyleBackColor = false;
            // 
            // btnGenerateProgCode
            // 
            btnGenerateProgCode.BackColor = Color.RoyalBlue;
            btnGenerateProgCode.Cursor = Cursors.Hand;
            btnGenerateProgCode.FlatAppearance.BorderSize = 0;
            btnGenerateProgCode.FlatStyle = FlatStyle.Flat;
            btnGenerateProgCode.Font = new Font("Microsoft YaHei UI", 10F);
            btnGenerateProgCode.ForeColor = Color.White;
            btnGenerateProgCode.ImeMode = ImeMode.NoControl;
            btnGenerateProgCode.Location = new Point(389, 276);
            btnGenerateProgCode.Name = "btnGenerateProgCode";
            btnGenerateProgCode.Size = new Size(170, 29);
            btnGenerateProgCode.TabIndex = 47;
            btnGenerateProgCode.Text = "Generate Code";
            btnGenerateProgCode.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(153, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 1);
            panel1.TabIndex = 48;
            // 
            // ctrlAdminCreateProgramme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(btnGenerateProgCode);
            Controls.Add(btnCreateProg);
            Controls.Add(txtProgCode);
            Controls.Add(label5);
            Controls.Add(txtProgDescription);
            Controls.Add(label4);
            Controls.Add(cmbProgLength);
            Controls.Add(label3);
            Controls.Add(txtProgTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ctrlAdminCreateProgramme";
            Size = new Size(1003, 740);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtProgTitle;
        private Label label3;
        private ComboBox cmbProgLength;
        private TextBox txtProgDescription;
        private Label label4;
        private TextBox txtProgCode;
        private Label label5;
        private Button btnCreateProg;
        private Button btnGenerateProgCode;
        private Panel panel1;
    }
}
