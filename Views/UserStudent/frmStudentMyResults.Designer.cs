namespace StudentAdministrationSystemRevive.Views.Student
{
    partial class frmStudentMyResults
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnRefreshMyResults = new Button();
            flowMyResults = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 36F);
            label1.ForeColor = Color.RoyalBlue;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(242, 65);
            label1.TabIndex = 20;
            label1.Text = "My Results";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnRefreshMyResults
            // 
            btnRefreshMyResults.BackColor = Color.RoyalBlue;
            btnRefreshMyResults.Cursor = Cursors.Hand;
            btnRefreshMyResults.FlatAppearance.BorderSize = 0;
            btnRefreshMyResults.FlatStyle = FlatStyle.Flat;
            btnRefreshMyResults.Font = new Font("Microsoft YaHei UI", 12F);
            btnRefreshMyResults.ForeColor = Color.White;
            btnRefreshMyResults.ImeMode = ImeMode.NoControl;
            btnRefreshMyResults.Location = new Point(796, 33);
            btnRefreshMyResults.Name = "btnRefreshMyResults";
            btnRefreshMyResults.Size = new Size(120, 45);
            btnRefreshMyResults.TabIndex = 19;
            btnRefreshMyResults.Text = "Refresh";
            btnRefreshMyResults.UseVisualStyleBackColor = false;
            btnRefreshMyResults.Click += btnRefreshMyResults_Click;
            // 
            // flowMyResults
            // 
            flowMyResults.AutoScroll = true;
            flowMyResults.FlowDirection = FlowDirection.TopDown;
            flowMyResults.Location = new Point(27, 130);
            flowMyResults.Name = "flowMyResults";
            flowMyResults.Size = new Size(904, 624);
            flowMyResults.TabIndex = 21;
            // 
            // frmStudentMyResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(946, 766);
            Controls.Add(flowMyResults);
            Controls.Add(label1);
            Controls.Add(btnRefreshMyResults);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStudentMyResults";
            Text = "frmStudentMyResults";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRefreshMyResults;
        private FlowLayoutPanel flowMyResults;
    }
}