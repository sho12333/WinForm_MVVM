using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_MVVM.Models
{
    public class User
    {
        public string UserId { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string MailAddress { get; set; } = string.Empty;
    }
}