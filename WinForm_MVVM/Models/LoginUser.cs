using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_MVVM.Models
{
    /// <summary>
    /// 認証用ユーザー
    /// </summary>
    public class LoginUser
    {
        /// <summary>
        /// ユーザーID
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// パスワード
        /// </summary>
        public string Password { get; set; } = string.Empty;
    }
}