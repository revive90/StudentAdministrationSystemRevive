namespace StudentAdministrationSystemRevive.Views.Alerts
{
    public partial class frmExitDialog : Form
    {
        public frmExitDialog()
        {
            InitializeComponent();
        }

        private void btnDontExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
