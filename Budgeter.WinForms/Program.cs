using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeter.WinForms
{
    static class Program
    {
        private static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
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
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
