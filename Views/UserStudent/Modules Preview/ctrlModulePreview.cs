namespace StudentAdministrationSystemRevive.Views.Student.Modules_Preview
{
    public partial class ctrlModulePreview : UserControl
    {
        public ctrlModulePreview()
        {
            InitializeComponent();
        }

        public void btnViewModuleDetail_Click(object sender, EventArgs e)
        {

        }
        public string ModText 
        {
            get { return lblModulePreviewTitle.Text; }
           set { lblModulePreviewTitle.Text = value; } 
        }

        public string ModTitle
        {
            get { return lblModulePreviewID.Text; }
            set { lblModulePreviewID.Text = value; }
        }

        private void ctrlModulePreview_Load(object sender, EventArgs e)
        {

        }
    }
}
