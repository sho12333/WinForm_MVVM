using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_MVVM.Data;
using WinForm_MVVM.Models;

namespace WinForm_MVVM.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            using (var conn = SqlConn.CreateConnection())
            {
                var query = SqlConn.GetQueryFactory(conn);
                var users = query.Query("M_USER").Select("USER_ID as UserId", "USER_NAME as UserName").Get<User>();
                return users;
            }
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}