using DataAccessLayer.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Forms.InitialForms;
using WindowsApp.Forms.RegisterForms;

namespace WindowsApp.Forms
{
    public partial class LoginForm : Form
    {
        private UserDAL _dal = new UserDAL(new SqlConnection
            (ConfigurationManager.ConnectionStrings["DB_ProjStocker"].ConnectionString));

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegisterForm UserRegisterForm = new UserRegisterForm();
            UserRegisterForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm menuPrincipalForm = new MenuPrincipalForm();
            menuPrincipalForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked == true)
                txbPassword.UseSystemPasswordChar = false;
            else
                txbPassword.UseSystemPasswordChar = true;
        }
    }
}
