using Application;
using Caso2.Views;
using Infrastructure;
using Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Caso2
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var principalForm = serviceProvider.GetRequiredService<Form1>();
                System.Windows.Forms.Application.Run(principalForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddInfrastructure();
            services.AddDbContext<ApplicationDbContext>();
            services.AddApplication();
            services.AddSingleton<Form1>();
        }
    }
}