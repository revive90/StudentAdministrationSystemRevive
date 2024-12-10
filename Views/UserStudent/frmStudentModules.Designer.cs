namespace StudentAdministrationSystemRevive.Views.StudentPages
{
    partial class frmStudentModules
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            flModules = new FlowLayoutPanel();
            lblMyModulesTitle = new Label();
            btnMyModulesRefresh = new Button();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // flModules
            // 
            flModules.AutoScroll = true;
            flModules.Location = new Point(4, 95);
            flModules.Name = "flModules";
            flModules.Size = new Size(930, 659);
            flModules.TabIndex = 27;
            // 
            // lblMyModulesTitle
            // 
            lblMyModulesTitle.AutoSize = true;
            lblMyModulesTitle.Font = new Font("Segoe UI Light", 36F);
            lblMyModulesTitle.ForeColor = Color.RoyalBlue;
            lblMyModulesTitle.ImeMode = ImeMode.NoControl;
            lblMyModulesTitle.Location = new Point(12, 9);
            lblMyModulesTitle.Name = "lblMyModulesTitle";
            lblMyModulesTitle.Size = new Size(276, 65);
            lblMyModulesTitle.TabIndex = 26;
            lblMyModulesTitle.Text = "My Modules";
            lblMyModulesTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnMyModulesRefresh
            // 
            btnMyModulesRefresh.BackColor = Color.RoyalBlue;
            btnMyModulesRefresh.Cursor = Cursors.Hand;
            btnMyModulesRefresh.FlatAppearance.BorderSize = 0;
            btnMyModulesRefresh.FlatStyle = FlatStyle.Flat;
            btnMyModulesRefresh.Font = new Font("Microsoft YaHei UI", 12F);
            btnMyModulesRefresh.ForeColor = Color.White;
            btnMyModulesRefresh.ImeMode = ImeMode.NoControl;
            btnMyModulesRefresh.Location = new Point(752, 20);
            btnMyModulesRefresh.Name = "btnMyModulesRefresh";
            btnMyModulesRefresh.Size = new Size(145, 45);
            btnMyModulesRefresh.TabIndex = 25;
            btnMyModulesRefresh.Text = "Refresh";
            btnMyModulesRefresh.UseVisualStyleBackColor = false;
            btnMyModulesRefresh.Click += btnMyModulesRefresh_Click;
            // 
            // frmStudentModules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(946, 766);
            Controls.Add(flModules);
            Controls.Add(lblMyModulesTitle);
            Controls.Add(btnMyModulesRefresh);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmStudentModules";
            Text = "frmStudentModules";
            Load += frmStudentModules_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private FlowLayoutPanel flModules;
        private Label lblMyModulesTitle;
        private Button btnMyModulesRefresh;
    }
}