namespace Domain.Models.UserModels
{
    public class UserModel
    {
        //private string text;
        #region Attributes
        public Guid? UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        #endregion

        #region Alternative Attributes
        #endregion


        #region Constructors
        public UserModel(string userName, string userEmail, string userPassword)
        {
            UserName = userName;
            UserEmail = userEmail;
            UserPassword = userPassword;
        }
        public UserModel(string userName, string userEmail, string userPassword, Guid? userId) : this(userName, userEmail, userPassword)
        {
            UserId = userId;
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
        public override bool Equals(object? obj)
        {
            if (!(obj is UserModel)) return false;

            if ((obj is UserModel).Equals(UserId)) return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 11 * (UserId == null ? 1 : UserId.GetHashCode());
        }
        public override string ToString()
        {
            return $"ID: {UserId}\nNome: {UserName}";
        }
        #endregion

    }
}
