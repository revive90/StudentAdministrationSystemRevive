namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    partial class ctrlAD_AssessmentRemove
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
            btnAD_AssessmentFind = new Button();
            txtAD_Assessment_Search_ID = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnAD_AssessmentRemove = new Button();
            txtAD_Assessment_ConfirmID = new TextBox();
            label5 = new Label();
            dgRMRemoveModuleTable = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgRMRemoveModuleTable).BeginInit();
            SuspendLayout();
            // 
            // btnAD_AssessmentFind
            // 
            btnAD_AssessmentFind.BackColor = Color.RoyalBlue;
            btnAD_AssessmentFind.Cursor = Cursors.Hand;
            btnAD_AssessmentFind.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnAD_AssessmentFind.FlatAppearance.BorderSize = 0;
            btnAD_AssessmentFind.FlatStyle = FlatStyle.Flat;
            btnAD_AssessmentFind.Font = new Font("Microsoft YaHei UI", 10F);
            btnAD_AssessmentFind.ForeColor = Color.White;
            btnAD_AssessmentFind.ImeMode = ImeMode.NoControl;
            btnAD_AssessmentFind.Location = new Point(768, 144);
            btnAD_AssessmentFind.Name = "btnAD_AssessmentFind";
            btnAD_AssessmentFind.Size = new Size(205, 29);
            btnAD_AssessmentFind.TabIndex = 78;
            btnAD_AssessmentFind.Text = "Find";
            btnAD_AssessmentFind.UseVisualStyleBackColor = false;
            // 
            // txtAD_Assessment_Search_ID
            // 
            txtAD_Assessment_Search_ID.BackColor = Color.WhiteSmoke;
            txtAD_Assessment_Search_ID.BorderStyle = BorderStyle.FixedSingle;
            txtAD_Assessment_Search_ID.Font = new Font("Segoe UI", 12F);
            txtAD_Assessment_Search_ID.Location = new Point(23, 145);
            txtAD_Assessment_Search_ID.Name = "txtAD_Assessment_Search_ID";
            txtAD_Assessment_Search_ID.Size = new Size(715, 29);
            txtAD_Assessment_Search_ID.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 14F);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(23, 108);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 76;
            label3.Text = "Assessment ID";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(23, 634);
            label1.Name = "label1";
            label1.Size = new Size(291, 21);
            label1.TabIndex = 75;
            label1.Text = "** Removing an assessment is irreversible! **";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnAD_AssessmentRemove
            // 
            btnAD_AssessmentRemove.BackColor = Color.Red;
            btnAD_AssessmentRemove.Cursor = Cursors.Hand;
            btnAD_AssessmentRemove.FlatAppearance.BorderColor = Color.OrangeRed;
            btnAD_AssessmentRemove.FlatAppearance.BorderSize = 0;
            btnAD_AssessmentRemove.FlatStyle = FlatStyle.Flat;
            btnAD_AssessmentRemove.Font = new Font("Microsoft YaHei UI", 10F);
            btnAD_AssessmentRemove.ForeColor = Color.White;
            btnAD_AssessmentRemove.ImeMode = ImeMode.NoControl;
            btnAD_AssessmentRemove.Location = new Point(332, 574);
            btnAD_AssessmentRemove.Name = "btnAD_AssessmentRemove";
            btnAD_AssessmentRemove.Size = new Size(205, 29);
            btnAD_AssessmentRemove.TabIndex = 74;
            btnAD_AssessmentRemove.Text = "Remove Assessment";
            btnAD_AssessmentRemove.UseVisualStyleBackColor = false;
            // 
            // txtAD_Assessment_ConfirmID
            // 
            txtAD_Assessment_ConfirmID.BackColor = Color.WhiteSmoke;
            txtAD_Assessment_ConfirmID.BorderStyle = BorderStyle.FixedSingle;
            txtAD_Assessment_ConfirmID.Font = new Font("Segoe UI", 12F);
            txtAD_Assessment_ConfirmID.Location = new Point(23, 574);
            txtAD_Assessment_ConfirmID.Name = "txtAD_Assessment_ConfirmID";
            txtAD_Assessment_ConfirmID.Size = new Size(276, 29);
            txtAD_Assessment_ConfirmID.TabIndex = 73;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(23, 537);
            label5.Name = "label5";
            label5.Size = new Size(230, 21);
            label5.TabIndex = 72;
            label5.Text = "Enter Assessment ID to Confirm";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dgRMRemoveModuleTable
            // 
            dgRMRemoveModuleTable.AllowUserToAddRows = false;
            dgRMRemoveModuleTable.AllowUserToDeleteRows = false;
            dgRMRemoveModuleTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRMRemoveModuleTable.Location = new Point(23, 204);
            dgRMRemoveModuleTable.Name = "dgRMRemoveModuleTable";
            dgRMRemoveModuleTable.ReadOnly = true;
            dgRMRemoveModuleTable.Size = new Size(950, 285);
            dgRMRemoveModuleTable.TabIndex = 71;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(23, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(23, 26);
            label2.Name = "label2";
            label2.Size = new Size(217, 32);
            label2.TabIndex = 69;
            label2.Text = "Remove Assessment";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ctrlAD_AssessmentRemove
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAD_AssessmentFind);
            Controls.Add(txtAD_Assessment_Search_ID);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnAD_AssessmentRemove);
            Controls.Add(txtAD_Assessment_ConfirmID);
            Controls.Add(label5);
            Controls.Add(dgRMRemoveModuleTable);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "ctrlAD_AssessmentRemove";
            Size = new Size(1003, 712);
            ((System.ComponentModel.ISupportInitialize)dgRMRemoveModuleTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAD_AssessmentFind;
        private TextBox txtAD_Assessment_Search_ID;
        private Label label3;
        private Label label1;
        private Button btnAD_AssessmentRemove;
        private TextBox txtAD_Assessment_ConfirmID;
        private Label label5;
        private DataGridView dgRMRemoveModuleTable;
        private Panel panel1;
        private Label label2;
    }
}
