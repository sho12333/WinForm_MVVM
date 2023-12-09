using WinForm_MVVM.ViewModels;

namespace WinForm_MVVM
{
    public partial class UserView : Form
    {
        private UserViewModel _viewModel = new UserViewModel();

        public UserView()
        {
            InitializeComponent();

            this.lblTitle.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Title));

            this.dgvUser.DataSource = _viewModel.GridDataSource;
        }
    }
}