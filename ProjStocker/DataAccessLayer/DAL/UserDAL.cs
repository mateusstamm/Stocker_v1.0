using System.Data.SqlClient;
using Domain.Models.UserModels;

namespace DataAccessLayer.DAL
{
    public class UserDAL
    {
        #region DataAccess Connection
        public SqlConnection _sqlConnection;
        #endregion

        #region Constructors
        public UserDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        #endregion

        #region Methods

        //public bool VerifyLogin(UserModel userModel)
        //{
        //    _sqlConnection.Open();
        //    SqlCommand command = _sqlConnection.CreateCommand();
        //    command.CommandText =
        //        "select * from TB_UserModel " +
        //        "where " +
        //        "user_Email = @userEmail, user_Password = @userPassword";
        //    command.Parameters.AddWithValue("userName", userModel.UserEmail());
        //    command.Parameters.AddWithValue("userName", userModel.UserPassword());
        //}


        public void Insert(UserModel userModel)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_UserModel(UserID, UserName, UserEmail, UserPassword)" +
                "values(@userId, @userName, @userEmail, @userPassword)";
            command.Parameters.AddWithValue("@userId", Guid.NewGuid());
            command.Parameters.AddWithValue("@userName", userModel.UserName);
            command.Parameters.AddWithValue("@userEmail", userModel.UserEmail);
            command.Parameters.AddWithValue("@userPassword", userModel.UserPassword);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public IReadOnlyCollection<UserModel> GetThemAll()
        {
            List<UserModel> userModels = new List<UserModel>();
            var command = new SqlCommand(
                "select UserId, UserName, UserEmail, UserPassword from TB_UserModel order by UserName",
                _sqlConnection);

            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var userModel = new UserModel(
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        userId: reader.GetGuid(0)
                        );
                    userModels.Add(userModel);
                }
            }
            _sqlConnection.Close();
            return userModels.AsReadOnly();
        }
        public UserModel GetById(Guid? userId)
        {
            UserModel user = null;
            var command = new SqlCommand("select UserId, UserName, UserEmail from TB_UserModel" +
                "where UserId = @UserId");
            command.Parameters.AddWithValue("@UserId", userId);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    user = new UserModel(reader.GetString(1),
                        userId: reader.GetGuid(0),
                        userEmail: reader.GetString(2),
                        userPassword: reader.GetString(3)
                        );
                }
            }
            _sqlConnection.Close();
            return user;
        }
        public void Record(UserModel userModel)
        {
            if (string.IsNullOrWhiteSpace(userModel.UserName))
            {
                throw new Exception("Name file can't be null");
            }
            if (userModel.UserId == null)
            {
                Insert(userModel);
            }
            else
            {
                Insert(userModel);
            }
        }
        private void Update(UserModel userModel)
        {
            var command = new SqlCommand("update from TB_UserModel" +
                "set UserName = @UserName where UserId = @userId", _sqlConnection);
            command.Parameters.AddWithValue("@UserId", userModel.UserId);
            command.Parameters.AddWithValue("@UserName", userModel.UserName);

            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public void Delete(UserModel userModel)
        {
            var command = new SqlCommand("delete from TB_UserModel " +
                "where UserId = @userId and UserName = @userName and UserEmail = @userEmail and UserPassword = @userPassword", _sqlConnection);
            command.Parameters.AddWithValue("@userId", userModel.UserId);
            command.Parameters.AddWithValue("@userName", userModel.UserName);
            command.Parameters.AddWithValue("@userEmail", userModel.UserEmail);
            command.Parameters.AddWithValue("@userPassword", userModel.UserPassword);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion
    }
}

