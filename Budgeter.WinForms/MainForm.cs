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

using System.Windows.Forms;
using Budgeter.ViewModel;

namespace Budgeter.WinForms
{
    public partial class MainForm : Form
    {
        private readonly MainViewModel mainViewModel;

        public MainForm(MainViewModel mainViewModel)
        {
            this.InitializeComponent();

            this.navigationToolStrip.Renderer = new Style.BudgeterToolStripRenderer();

            this.mainViewModel = mainViewModel;
            this.cashflowViewModelBindingSource.DataSource = mainViewModel.Cashflows;
        }
    }
}
