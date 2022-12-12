namespace Domain.Models.ProductModels
{
    public class ProductModel
    {
        #region Attributes
        public Guid? ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductUnitPrice { get; set; }
        #endregion

        #region Alternative Attributes
        #endregion

        #region Constructors
        public ProductModel(string productName, 
                            string productDescription, 
                            string productCategory, 
                            string productQuantity,
                            string productUnitPrice)
        {
            ProductName = productName;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            ProductQuantity = productQuantity;
            ProductUnitPrice = productUnitPrice;
        }
        public ProductModel(string productName,
                            string productDescription,
                            string productCategory,
                            string productQuantity,
                            string productUnitPrice,
                            Guid? productId) : this (productName,
                                                     productDescription,
                                                     productCategory,
                                                     productQuantity,
                                                     productUnitPrice)
        {
            ProductId = productId;
        }
        #endregion

        #region Methods
        //public bool Access (string userEmail, string userPassword)
        //{
        //    UserDAL userDaL= new UserDAL();
        //    tem = loginDao.verificarLogin(email, senha);
        //    if (!loginDao.mensagem.Equals(""))
        //    {
        //        this.mensagem = loginDao.mensagem;
        //    }
        //    return tem;
        //}
        //public void UpdateName(string userName)
        //{
        //    UserName = userName;
        //}
        public override bool Equals(object? obj)
        {
            if (!(obj is ProductModel)) return false;

            if ((obj is ProductModel).Equals(ProductId)) return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 11 * (ProductId == null ? 1 : ProductId.GetHashCode());
        }
        public override string ToString()
        {
            return $"ID: {ProductId}\nNome: {ProductName}";
        }
        #endregion

    }
}
