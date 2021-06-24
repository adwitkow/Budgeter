// This file is part of Budgeter project <https://github.com/adwitkow/Budgeter>
// Copyright (C) 2021  Adam Witkowski <https://github.com/adwitkow/>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

using System;
using System.Windows.Forms;
using Budgeter.DataAccess;
using Budgeter.Model.ViewModels;
using Budgeter.WinForms.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Budgeter.WinForms
{
    public static class Program
    {
        private static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureServices();

            var form = ServiceProvider.GetService<MainForm>();

            Application.Run(form);
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<MainForm>();
            services.AddScoped<BudgeterDbContext>();
            services.AddScoped<BudgeterDataProvider>();
            services.AddScoped<ViewContainer>();
            services.AddScoped<CashflowView>();
            services.AddScoped<CashflowViewModel>();
            services.AddScoped<MainView>();
            services.AddScoped<MainViewModel>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
