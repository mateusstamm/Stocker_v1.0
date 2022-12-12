using Domain.Models.ProductModels;
using System.Data.SqlClient;

namespace DataAccessLayer.DAL
{
    public class ProductDAL
    {
        #region DataAccess Connection
        public SqlConnection _sqlConnection;
        #endregion

        #region Constructors
        public ProductDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        #endregion

        #region Methods

        public void InsertProduct(ProductModel productModel)
        {
            _sqlConnection.Open();
            SqlCommand commandProduct = _sqlConnection.CreateCommand();
            commandProduct.CommandText =
                "insert into TB_ProductModel(ProductId, ProductName, ProductDescription, ProductCategory, ProductQuantity, ProductUnitPrice)" +
                "values(@productId, @productName, @productDescription, @productCategory, @productQuantity, @productUnitPrice)";
            commandProduct.Parameters.AddWithValue("@productId", Guid.NewGuid());
            commandProduct.Parameters.AddWithValue("@productName", productModel.ProductName);
            commandProduct.Parameters.AddWithValue("@productDescription", productModel.ProductDescription);
            commandProduct.Parameters.AddWithValue("@productCategory", productModel.ProductCategory);
            commandProduct.Parameters.AddWithValue("@productQuantity", productModel.ProductQuantity);
            commandProduct.Parameters.AddWithValue("@productUnitPrice", productModel.ProductUnitPrice);
            commandProduct.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public IReadOnlyCollection<ProductModel> GetThemAllProducts()
        {
            List<ProductModel> productModels = new List<ProductModel>();
            var command = new SqlCommand(
                "select ProductId, ProductName, ProductDescription, ProductCategory, ProductQuantity, ProductUnitPrice from TB_ProductModel",
                _sqlConnection);

            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var productModel = new ProductModel(
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        productId: reader.GetGuid(0)
                        );
                    productModels.Add(productModel);
                }
            }
            _sqlConnection.Close();
            return productModels.AsReadOnly();
        }
        public ProductModel GetById(Guid? productId)
        {
            ProductModel product = null;
            var command = new SqlCommand("select ProductId, ProductName, ProductDescription, ProductCategory, ProductQuantity, ProductUnitPrice from TB_ProductModel" +
                "where ProductId = @ProductId");
            command.Parameters.AddWithValue("@ProductId", productId);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    product = new ProductModel(reader.GetString(1),
                        productId: reader.GetGuid(0),
                        productDescription: reader.GetString(2),
                        productCategory: reader.GetString(3),
                        productQuantity: reader.GetString(4),
                        productUnitPrice: reader.GetString(5)
                        );
                }
            }
            _sqlConnection.Close();
            return product;
        }
        public void RecordProduct(ProductModel productModel)
        {
            if (string.IsNullOrWhiteSpace(productModel.ProductName))
            {
                throw new Exception("Product name can't be null");
            }
            if (productModel.ProductId == null)
            {
                InsertProduct(productModel);
            }
            else
            {
                InsertProduct(productModel);
            }
        }
        public void UpdateProduct(ProductModel productModel)
        {
            _sqlConnection.Open();
            var command = new SqlCommand("update TB_ProductModel set ProductName = @productName, ProductDescription = @productDescription, ProductCategory = @productCategory, ProductQuantity = @productQuantity, ProductUnitPrice = @productUnitPrice where ProductId = @productId", _sqlConnection);
            command.Parameters.AddWithValue("@productId", productModel.ProductId);
            command.Parameters.AddWithValue("@productName", productModel.ProductName);
            command.Parameters.AddWithValue("@productDescription", productModel.ProductDescription);
            command.Parameters.AddWithValue("@productCategory", productModel.ProductCategory);
            command.Parameters.AddWithValue("@productQuantity", productModel.ProductQuantity);
            command.Parameters.AddWithValue("@productUnitPrice", productModel.ProductUnitPrice);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public void DeleteProduct(ProductModel productModel)
        {
            _sqlConnection.Open();
            var command = new SqlCommand("delete from TB_ProductModel " +
                "where ProductId = @productId and ProductName = @productName and ProductDescription = @productDescription and ProductCategory = @productCategory and ProductQuantity = @productQuantity and ProductUnitPrice = @productUnitPrice", _sqlConnection);
            command.Parameters.AddWithValue("@productId", productModel.ProductId);
            command.Parameters.AddWithValue("@productName", productModel.ProductName);
            command.Parameters.AddWithValue("@productDescription", productModel.ProductDescription);
            command.Parameters.AddWithValue("@productCategory", productModel.ProductCategory);
            command.Parameters.AddWithValue("@productQuantity", productModel.ProductQuantity);
            command.Parameters.AddWithValue("@productUnitPrice", productModel.ProductUnitPrice);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion
    }
}
