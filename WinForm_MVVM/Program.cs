using Microsoft.Extensions.DependencyInjection;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data.SqlClient;
using System.Windows.Forms.Design;
using WinForm_MVVM.Repositories.Users;
using WinForm_MVVM.Services.Messages;

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

            MainView view = serviceProvider.GetRequiredService<MainView>();
            Application.Run(view);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainView>();
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