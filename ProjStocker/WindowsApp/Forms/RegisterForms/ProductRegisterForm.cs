using DataAccessLayer.DAL;
using Domain.Models.ProductModels;
using System.Configuration;
using System.Data.SqlClient;
using WindowsApp.Forms.InitialForms;

namespace WindowsApp.Forms
{
    public partial class ProductRegisterForm : Form
    {

        #region Data Access Connection
        private ProductDAL _dal = new ProductDAL(new SqlConnection
            (ConfigurationManager.ConnectionStrings["DB_ProjStocker"].ConnectionString));
        #endregion

        private bool _isLoadingTheForm = true;
        private ProductModel _currentProductModel;

        public ProductRegisterForm()
        {
            InitializeComponent();
        }

        #region Buttons
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                _dal.InsertProduct(new ProductModel(
                    txbProductName.Text,
                    txbProductDescription.Text,
                    txbProductCategory.Text,
                    txbProductQuantity.Text,
                    txbProductUnitPrice.Text,
                    productId: _currentProductModel?.ProductId ?? null)); ;

                InitializeForm();

                MessageBox.Show("Produto Inserido com sucesso!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _dal.UpdateProduct(new ProductModel(
                    txbProductName.Text,
                    txbProductDescription.Text,
                    txbProductCategory.Text,
                    txbProductQuantity.Text,
                    txbProductUnitPrice.Text,
                    productId: _currentProductModel?.ProductId ?? null)); ;

                InitializeForm();

                MessageBox.Show("Produto editado com sucesso!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_currentProductModel == null)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }

            if (MessageBox.Show($"Confirma a remoção? {_currentProductModel.ProductName.ToUpper()}", "Doubt",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _dal.DeleteProduct(_currentProductModel);
            InitializeForm();

            MessageBox.Show("Produto removido com sucesso!");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitializeForm();
        }
        #endregion
        private void InitializeForm()
        {
            _isLoadingTheForm = true;
            dgvSearchProduct.DataSource = _dal.GetThemAllProducts();
            btnCancel.Enabled = false;
            _currentProductModel = null;
            dgvSearchProduct.ClearSelection();
            txbProductName.Clear();
            txbProductDescription.Clear();
            txbProductCategory.Clear();
            txbProductQuantity.Clear();
            txbProductUnitPrice.Clear();
            _isLoadingTheForm = false;

        }

        private void ConfigureFormForSelectedItem()
        {
            txbProductName.Text = _currentProductModel.ProductName;
            btnCancel.Enabled = true;
        }

        private void RegisterCurrentProductModel(string productName, string productDescription, string productCategory, string productQuantity, string productUnitPrice, Guid? productId = null)
        {
            _currentProductModel = new ProductModel(productName, productDescription, productCategory, productQuantity, productUnitPrice, productId: productId);
            ConfigureFormForSelectedItem();
        }

        private void ProductRegisterForm_Shown(object sender, EventArgs e)
        {
            InitializeForm();
            dgvSearchProduct.Columns[0].Visible = false;
            dgvSearchProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchProduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchProduct.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSearchProduct.ClearSelection();
        }

        private void dgvSearchProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isLoadingTheForm)
            {
                RegisterCurrentProductModel(
                        dgvSearchProduct.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        dgvSearchProduct.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        dgvSearchProduct.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        dgvSearchProduct.Rows[e.RowIndex].Cells[4].Value.ToString(),
                        dgvSearchProduct.Rows[e.RowIndex].Cells[5].Value.ToString(),
                        productId: Guid.Parse(
                            dgvSearchProduct.Rows[e.RowIndex].Cells[0].Value.ToString()));
                txbProductName.Text = _currentProductModel.ProductName;
                txbProductDescription.Text = _currentProductModel.ProductDescription;
                txbProductCategory.Text = _currentProductModel.ProductCategory;
                txbProductQuantity.Text = _currentProductModel.ProductQuantity;
                txbProductUnitPrice.Text = _currentProductModel.ProductUnitPrice;
            }
        }
    }
}