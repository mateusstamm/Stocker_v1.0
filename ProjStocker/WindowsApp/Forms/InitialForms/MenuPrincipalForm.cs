using WindowsApp.Forms.RegisterForms;

namespace WindowsApp.Forms.InitialForms
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void searchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSearchForm searchUserForm = new UserSearchForm();
            searchUserForm.Show();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductRegisterForm productRegisterForm = new ProductRegisterForm();
            productRegisterForm.Show();
        }
    }
}
