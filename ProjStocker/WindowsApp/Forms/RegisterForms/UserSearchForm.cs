using DataAccessLayer.DAL;
using System.Configuration;
using System.Data.SqlClient;
using WindowsApp.Forms.InitialForms;

namespace WindowsApp.Forms.RegisterForms
{
    public partial class UserSearchForm : Form
    {
        #region Data Access Connection
        private UserDAL _dal = new UserDAL(new SqlConnection
            (ConfigurationManager.ConnectionStrings["DB_ProjStocker"].ConnectionString));
        #endregion

        public UserSearchForm()
        {
            InitializeComponent();

            #region DataGridView
            dgvSearchUserForm.DataSource = _dal.GetThemAll();
            //dgvSubscribe.Columns.RemoveAt(0);
            //dgvSubscribe.Columns[0].Visible = false;
            dgvSearchUserForm.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchUserForm.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchUserForm.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }
    }
}
