using Dapper;
using Data.DapperORM.Interface;
using Model;
using System.Data;
using System.Linq;

namespace Data.DapperORM.Class
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public User ValidateUser(string username, string password)
        {
            User ret;
            using (var db = GetMySqlConnection())
            {
                const string sql = @"select Id, Name, Surname, Email, Phone, LastLogon, CreatedOn, ActivationCode
                from User U
                where Login = @Login and Password = @Password";

                ret = db.Query<User>(sql, new { Login = username, Password = password }, commandType: CommandType.Text).FirstOrDefault();
            }

            return ret;
        }

        public void InsertUser(string username, string password)
        {
            using (var db = GetMySqlConnection())
            {
                const string sql = @"insert into User (Login, Password, CreatedOn, LastLogon) values (@Login, @Password, NOW(), NOW())";

                db.Execute(sql, new { Login = username, Password = password }, commandType: CommandType.Text);
            }
        }
    }
}