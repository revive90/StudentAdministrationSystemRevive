namespace StudentAdministrationSystemRevive.Views.Student.Modules_Preview
{
    partial class ctrlModulePreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlModulePreview));
            lblModulePreviewCode = new Label();
            pictureBox3 = new PictureBox();
            btnViewModuleDetail = new Button();
            lblModulePreviewTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblModulePreviewCode
            // 
            lblModulePreviewCode.AutoSize = true;
            lblModulePreviewCode.Font = new Font("Segoe UI Semibold", 15F);
            lblModulePreviewCode.ForeColor = Color.DimGray;
            lblModulePreviewCode.ImeMode = ImeMode.NoControl;
            lblModulePreviewCode.Location = new Point(11, 192);
            lblModulePreviewCode.Name = "lblModulePreviewCode";
            lblModulePreviewCode.Size = new Size(135, 28);
            lblModulePreviewCode.TabIndex = 34;
            lblModulePreviewCode.Text = "Module Code";
            lblModulePreviewCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(275, 146);
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // btnViewModuleDetail
            // 
            btnViewModuleDetail.BackColor = Color.RoyalBlue;
            btnViewModuleDetail.Cursor = Cursors.Hand;
            btnViewModuleDetail.FlatAppearance.BorderSize = 0;
            btnViewModuleDetail.FlatStyle = FlatStyle.Flat;
            btnViewModuleDetail.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewModuleDetail.ForeColor = Color.White;
            btnViewModuleDetail.ImeMode = ImeMode.NoControl;
            btnViewModuleDetail.Location = new Point(161, 227);
            btnViewModuleDetail.Name = "btnViewModuleDetail";
            btnViewModuleDetail.Size = new Size(120, 32);
            btnViewModuleDetail.TabIndex = 32;
            btnViewModuleDetail.Text = "View More";
            btnViewModuleDetail.UseVisualStyleBackColor = false;
            btnViewModuleDetail.Click += btnViewModuleDetail_Click;
            // 
            // lblModulePreviewTitle
            // 
            lblModulePreviewTitle.AutoSize = true;
            lblModulePreviewTitle.Font = new Font("Segoe UI Light", 18F);
            lblModulePreviewTitle.ForeColor = Color.RoyalBlue;
            lblModulePreviewTitle.ImeMode = ImeMode.NoControl;
            lblModulePreviewTitle.Location = new Point(11, 160);
            lblModulePreviewTitle.Name = "lblModulePreviewTitle";
            lblModulePreviewTitle.Size = new Size(138, 32);
            lblModulePreviewTitle.TabIndex = 29;
            lblModulePreviewTitle.Text = "Module Title";
            lblModulePreviewTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ctrlModulePreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblModulePreviewCode);
            Controls.Add(pictureBox3);
            Controls.Add(btnViewModuleDetail);
            Controls.Add(lblModulePreviewTitle);
            Name = "ctrlModulePreview";
            Size = new Size(288, 271);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModulePreviewCode;
        private PictureBox pictureBox3;
        private Button btnViewModuleDetail;
        private Label lblModulePreviewTitle;
    }
}
