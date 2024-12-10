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
            lblModulePreviewTitle = new Label();
            pictureBox3 = new PictureBox();
            lblModulePreviewID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblModulePreviewTitle
            // 
            lblModulePreviewTitle.Font = new Font("Segoe UI Semibold", 15F);
            lblModulePreviewTitle.ForeColor = Color.DimGray;
            lblModulePreviewTitle.ImeMode = ImeMode.NoControl;
            lblModulePreviewTitle.Location = new Point(6, 195);
            lblModulePreviewTitle.Name = "lblModulePreviewTitle";
            lblModulePreviewTitle.Size = new Size(275, 76);
            lblModulePreviewTitle.TabIndex = 34;
            lblModulePreviewTitle.Text = "Module Code";
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
            // lblModulePreviewID
            // 
            lblModulePreviewID.AutoSize = true;
            lblModulePreviewID.Font = new Font("Segoe UI Light", 18F);
            lblModulePreviewID.ForeColor = Color.RoyalBlue;
            lblModulePreviewID.ImeMode = ImeMode.NoControl;
            lblModulePreviewID.Location = new Point(3, 163);
            lblModulePreviewID.Name = "lblModulePreviewID";
            lblModulePreviewID.Size = new Size(138, 32);
            lblModulePreviewID.TabIndex = 29;
            lblModulePreviewID.Text = "Module Title";
            lblModulePreviewID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ctrlModulePreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblModulePreviewTitle);
            Controls.Add(pictureBox3);
            Controls.Add(lblModulePreviewID);
            Name = "ctrlModulePreview";
            Size = new Size(288, 271);
            Load += ctrlModulePreview_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModulePreviewTitle;
        private PictureBox pictureBox3;
        private Label lblModulePreviewID;
    }
}
