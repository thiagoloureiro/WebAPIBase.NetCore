using Dapper;
using System.Data;
using System.Linq;
using WebAPIBase.Data.DapperORM.Interface;
using WebAPIBase.Model;

namespace WebAPIBase.Data.DapperORM.Class
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public User ValidateUser(string username, string password)
        {
            using var db = GetMySqlConnection();
            const string sql = @"select Id, Name, Surname, Email, Phone, LastLogon, CreatedOn, ActivationCode
                from User U
                where Login = @Login and Password = @Password";

            return db.Query<User>(sql, new { Login = username, Password = password }, commandType: CommandType.Text).FirstOrDefault();
        }

        public void InsertUser(string username, string password)
        {
            using var db = GetMySqlConnection();
            const string sql = @"insert into User (Login, Password, CreatedOn, LastLogon) values (@Login, @Password, NOW(), NOW())";

            db.Execute(sql, new { Login = username, Password = password }, commandType: CommandType.Text);
        }
    }
}