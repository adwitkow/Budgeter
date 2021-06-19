using Budgeter.Core.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Budgeter.WinForms
{
    static class Program
    {
        private static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureServices();

            var form = ServiceProvider.GetService<MainForm>();

            Application.Run(form);
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<MainForm>();
            services.AddScoped<BudgeterDbContext>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
