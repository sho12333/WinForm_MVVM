using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_MVVM.Models;
using WinForm_MVVM.Repositories.Users;
using WinForm_MVVM.Services.Messages;

namespace WinForm_MVVM.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        /// <summary>
        /// ユーザーID
        /// </summary>
        private LoginUser _loginUser = new LoginUser();

        public LoginUser LoginUser
        {
            get => _loginUser;
            set
            {
                SetProperty(ref _loginUser, value);
            }
        }

        private IUserRepository _userRepository;

        public LoginViewModel() : this(new UserRepository())
        {
            this.Title = "ログイン";
        }

        public LoginViewModel(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        /// <summary>
        /// ログイン処理
        /// </summary>
        /// <returns></returns>
        public bool Login()
        {
            var isLogin = _userRepository.ValidateUser(this.LoginUser);
            return isLogin;
        }
    }
}