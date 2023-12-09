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

        /// <summary>
        /// ユーザー取得
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// ユーザー認証
        /// </summary>
        /// <param name="loginUser"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool ValidateUser(LoginUser loginUser)
        {
            using (var conn = SqlConn.CreateConnection())
            {
                var query = SqlConn.GetQueryFactory(conn);
                var user = query.Query("M_USER").Where("USER_ID", loginUser.UserId).Where("PASSWORD", loginUser.Password).FirstOrDefault<User>();
                return user is not null;
            }
        }
    }
}