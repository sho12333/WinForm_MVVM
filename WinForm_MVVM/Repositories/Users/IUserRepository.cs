using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_MVVM.Models;

namespace WinForm_MVVM.Repositories.Users
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();

        User GetUserById(string id);

        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(string id);

        bool ValidateUser(LoginUser loginUser);
    }
}