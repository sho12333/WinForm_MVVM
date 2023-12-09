using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_MVVM.Models;
using WinForm_MVVM.ViewModels;

namespace WinForm_MVVM.Views
{
    public partial class LoginView : BaseView
    {
        private LoginViewModel _viewModel = new LoginViewModel();

        public LoginView() : base()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            this.lblTitle.Text = "ログイン";

            txtUserId.DataBindings.Add("Text", _viewModel.LoginUser, nameof(LoginUser.UserId));
            txtPassword.DataBindings.Add("Text", _viewModel.LoginUser, nameof(LoginUser.Password));
        }

        /// <summary>
        /// ログイン処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var status = _viewModel.Login();
            if (!status)
            {
                MessageBox.Show("ログインに失敗しました。");
                return;
            }

            // ログイン成功時はユーザー画面を表示
            this.Visible = false;

            using (var form = new UserView())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    // 処理の終了
                    this.Close();
                }
            }
        }
    }
}