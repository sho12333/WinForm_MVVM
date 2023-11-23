using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_MVVM.Models;
using WinForm_MVVM.Repositories.Users;
using WinForm_MVVM.Services.Messages;

namespace WinForm_MVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IMessageService _messageService;

        private IUserRepository _userRepository;

        public MainViewModel() : this(new MessageService(), new UserRepository())
        { }

        public MainViewModel(IMessageService messageService, IUserRepository userRepisitory)
        {
            this._messageService = messageService;
            this._userRepository = userRepisitory;
            this.GridDataSource = new BindingList<User>();

            this.Title = "ユーザーマスタ";

            var users = GetUsers();
            foreach (var user in users)
            {
                this.GridDataSource.Add(user);
            }
        }

        public BindingList<User> GridDataSource { get; set; }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}