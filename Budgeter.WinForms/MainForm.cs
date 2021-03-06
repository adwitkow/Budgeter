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
using Budgeter.WinForms.Views;

namespace Budgeter.WinForms
{
    public partial class MainForm : Form
    {
        private readonly ViewContainer viewContainer;

        private BudgeterView currentView;

        public MainForm(ViewContainer viewContainer)
        {
            this.viewContainer = viewContainer;
            this.InitializeComponent();

            this.navigationToolStrip.Renderer = new Style.BudgeterToolStripRenderer();

            this.SwitchView<MainView>();
        }

        private void OverviewToolStripButton_Click(object sender, System.EventArgs e)
        {
            this.SwitchView<MainView>();
        }

        private void TransactionsToolStripButton_Click(object sender, EventArgs e)
        {
            this.SwitchView<TransactionView>();
        }

        private void AccountsToolStripButton_Click(object sender, EventArgs e)
        {
            this.SwitchView<AccountsView>();
        }

        private void CategoriesToolStripButton_Click(object sender, EventArgs e)
        {
            this.SwitchView<CategoriesView>();
        }

        private void StoresToolStripButton_Click(object sender, EventArgs e)
        {
            this.SwitchView<StoresView>();
        }

        private void BudgetsToolStripButton_Click(object sender, EventArgs e)
        {
            this.SwitchView<BudgetsView>();
        }

        private void SwitchView<T>()
            where T : BudgeterView
        {
            if (this.currentView?.GetType() == typeof(T))
            {
                return;
            }

            var oldView = this.currentView;

            if (oldView != null)
            {
                this.contentPanel.Controls.Remove(oldView);
            }

            var newView = this.viewContainer.RequestView<T>();
            this.currentView = newView;
            newView.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(newView);
            newView.OnActivated();
        }
    }
}
