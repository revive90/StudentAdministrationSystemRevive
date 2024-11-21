namespace StudentAdministrationSystemRevive.Views.UserAdministrator
{
    partial class ctrlAdminAddCohort
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
            btnCreateProg = new Button();
            txtProgCode = new TextBox();
            label5 = new Label();
            txtProgTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // btnCreateProg
            // 
            btnCreateProg.BackColor = Color.RoyalBlue;
            btnCreateProg.Cursor = Cursors.Hand;
            btnCreateProg.FlatAppearance.BorderSize = 0;
            btnCreateProg.FlatStyle = FlatStyle.Flat;
            btnCreateProg.Font = new Font("Microsoft YaHei UI", 12F);
            btnCreateProg.ForeColor = Color.White;
            btnCreateProg.ImeMode = ImeMode.NoControl;
            btnCreateProg.Location = new Point(549, 631);
            btnCreateProg.Name = "btnCreateProg";
            btnCreateProg.Size = new Size(283, 37);
            btnCreateProg.TabIndex = 58;
            btnCreateProg.Text = "Create Cohort";
            btnCreateProg.UseVisualStyleBackColor = false;
            // 
            // txtProgCode
            // 
            txtProgCode.BackColor = Color.WhiteSmoke;
            txtProgCode.BorderStyle = BorderStyle.FixedSingle;
            txtProgCode.Enabled = false;
            txtProgCode.Font = new Font("Segoe UI", 12F);
            txtProgCode.Location = new Point(181, 209);
            txtProgCode.Name = "txtProgCode";
            txtProgCode.Size = new Size(220, 29);
            txtProgCode.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 14F);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(181, 175);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 56;
            label5.Text = "Start Year";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtProgTitle
            // 
            txtProgTitle.BackColor = Color.WhiteSmoke;
            txtProgTitle.BorderStyle = BorderStyle.FixedSingle;
            txtProgTitle.Font = new Font("Segoe UI", 12F);
            txtProgTitle.Location = new Point(181, 299);
            txtProgTitle.Name = "txtProgTitle";
            txtProgTitle.Size = new Size(425, 29);
            txtProgTitle.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 14F);
            label2.ForeColor = Color.Black;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(181, 262);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 50;
            label2.Text = "Programme Code";
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
            label1.Size = new Size(132, 32);
            label1.TabIndex = 49;
            label1.Text = "Add Cohort";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(181, 363);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(651, 235);
            dataGridView1.TabIndex = 61;
            // 
            // ctrlAdminAddCohort
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(btnCreateProg);
            Controls.Add(txtProgCode);
            Controls.Add(label5);
            Controls.Add(txtProgTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ctrlAdminAddCohort";
            Size = new Size(1003, 740);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCreateProg;
        private TextBox txtProgCode;
        private Label label5;
        private TextBox txtProgTitle;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
