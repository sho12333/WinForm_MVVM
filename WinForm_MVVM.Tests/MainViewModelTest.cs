using Moq;
using Xunit;
using WinForm_MVVM.Repositories.Users;
using WinForm_MVVM.Services.Messages;

namespace WinForm_MVVM.Tests
{
    public class MainViewModelTest
    {
        [Fact]
        public void Return_User()
        {
            var mock = new Mock<IUserRepository>();
            mock.Setup(x => x.GetUsers()).Returns(new[] { new Models.User { UserId = "1", UserName = "test" } });

            var sut = new ViewModels.MainViewModel(new MessageService(), mock.Object);
            var users = sut.GetUsers();

            Assert.Single(users);
        }
    }
}