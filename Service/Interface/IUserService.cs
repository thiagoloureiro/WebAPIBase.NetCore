using System.Collections.Generic;
using Model;

namespace Service.Interface
{
    public interface IUserService
    {
        List<User> GetUserList();

        User GetToken(string username, string password);

        void InsertUser(string username, string password);
    }
}