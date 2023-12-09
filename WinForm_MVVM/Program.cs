using Microsoft.Extensions.DependencyInjection;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data.SqlClient;
using System.Windows.Forms.Design;
using WinForm_MVVM.Repositories.Users;
using WinForm_MVVM.Services.Messages;
using WinForm_MVVM.Views;

namespace WinForm_MVVM
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            LoginView view = serviceProvider.GetRequiredService<LoginView>();
            Application.Run(view);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<UserView>();
            services.AddSingleton<LoginView>();
            services.AddSingleton<BaseView>();

            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<SqlConnection>(option => new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString));

            services.AddScoped<Compiler, SqlServerCompiler>();
            services.AddScoped(option =>
            {
                var connection = option.GetRequiredService<SqlConnection>();
                var compiler = option.GetRequiredService<Compiler>();
                return new QueryFactory(connection, compiler);
            });
        }
    }
}