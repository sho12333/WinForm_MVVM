using WinForm_MVVM.ViewModels;

namespace WinForm_MVVM
{
    public partial class MainView : Form
    {
        private MainViewModel _viewModel = new MainViewModel();

        public MainView()
        {
            InitializeComponent();

            this.lblTitle.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Title));

            this.dgvUser.DataSource = _viewModel.GridDataSource;
        }
    }
}