using DataAccessLayer.DAL;
using Domain.Models.UserModels;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsApp.Forms
{
    public partial class UserRegisterForm : Form
    {
        #region Data Access Connection
        private UserDAL _dal = new UserDAL(new SqlConnection
            (ConfigurationManager.ConnectionStrings["DB_ProjStocker"].ConnectionString));
        #endregion

        private bool _isLoadingTheForm = true;
        private UserModel _currentUserModel;

        public UserRegisterForm()
        {
            InitializeComponent();
            
            //dgvSubscribe.Columns.RemoveAt(0);
        }

        #region Buttons
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {              
                    _dal.Insert(new UserModel(
                        txbName.Text,
                        txbEmail.Text,
                        txbPassword.Text,
                        userId: _currentUserModel?.UserId ?? null));;
                
                InitializeForm();


                MessageBox.Show("Register Confirmed");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }
        #endregion

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isLoadingTheForm)
            {
                RegisterCurrentUserModel(
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        userId: Guid.Parse(
                            dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                txbName.Text = _currentUserModel.UserName;
                txbEmail.Text = _currentUserModel.UserEmail;
                txbPassword.Text = _currentUserModel.UserPassword;
            }
        }

        private void InitializeForm()
        {
            _isLoadingTheForm = true;
            dataGridView1.DataSource = _dal.GetThemAll();
            txbCancel.Enabled = false;
            _currentUserModel = null;
            dataGridView1.ClearSelection();
            txbName.Clear();
            txbEmail.Clear();
            txbPassword.Clear();
            _isLoadingTheForm = false;

        }

        private void ConfigureFormForSelectedItem()
        {
            txbName.Text = _currentUserModel.UserName;
            txbCancel.Enabled = true;
        }

        private void RegisterCurrentUserModel(string userName, string userEmail, string userPassword, Guid? userId = null)
        {
            _currentUserModel = new UserModel(userName, userEmail, userPassword, userId: userId);
            ConfigureFormForSelectedItem();
        }

        private void UserRegisterForm_Shown(object sender, EventArgs e)
        {
            InitializeForm();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.ClearSelection();
        }

        private void txbRemove_Click(object sender, EventArgs e)
        {
            if(_currentUserModel == null)
            {
                MessageBox.Show("Select at least one name");
                return;
            }

            if (MessageBox.Show($"Confirm to Remove? {_currentUserModel.UserName.ToUpper()}", "Doubt",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _dal.Delete(_currentUserModel);
            InitializeForm();

            MessageBox.Show("Register removed");
        }
    }
}
