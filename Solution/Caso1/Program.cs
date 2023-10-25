using Application;
using Caso1.Views;
using Infrastructure;
using Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Caso1
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
                var principalForm = serviceProvider.GetRequiredService<Main>();
                System.Windows.Forms.Application.Run(principalForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddInfrastructure();
            services.AddDbContext<ApplicationDbContext>();
            services.AddApplication();
            services.AddSingleton<Main>();
            services.AddSingleton<Form1>();
            services.AddSingleton<Form2>();
            services.AddSingleton<Form3>();
            services.AddSingleton<Form4>();
            services.AddSingleton<Form5>();
        }
    }
}