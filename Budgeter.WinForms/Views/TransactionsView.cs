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

using Budgeter.DataAccess;
using Budgeter.Model.Models;
using Budgeter.Model.ViewModels;
using Budgeter.WinForms.Forms;
using System.Windows.Forms;

namespace Budgeter.WinForms.Views
{
    public partial class TransactionView : BudgeterView<TransactionsViewModel>
    {
        private readonly MainForm mainForm;
        private readonly EditTransactionForm editTransactionForm;
        private readonly BudgeterDataProvider budgeterDataProvider;

        public TransactionView()
            : base()
        {
            this.InitializeComponent();
        }

        public TransactionView(MainForm mainForm, EditTransactionForm editTransactionForm,
                               TransactionsViewModel viewModel, BudgeterDataProvider budgeterDataProvider)
            : base(viewModel)
        {
            this.InitializeComponent();
            this.mainForm = mainForm;
            this.editTransactionForm = editTransactionForm;
            this.budgeterDataProvider = budgeterDataProvider;
        }

        public async override void OnActivated()
        {
            if (!this.Visible)
            {
                return;
            }

            await this.ViewModel.LoadAsync();

            this.transactionModelBindingSource.DataSource = this.ViewModel.Transactions;
            this.transactionModelBindingSource.ResetBindings(false);
        }

        private void EditToolStripButton_Click(object sender, System.EventArgs e)
        {
            var current = (TransactionModel)this.transactionModelBindingSource.Current;

            this.editTransactionForm.ShowFor(this.mainForm, current);
        }

        private async void DeleteToolStripButton_Click(object sender, System.EventArgs e)
        {
            var current = (TransactionModel)this.transactionModelBindingSource.Current;
            var button = sender as ToolStripButton;

            var result = MessageBox.Show(this.mainForm, "Are you sure you want to delete this transaction?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                button.Enabled = false;
                await this.budgeterDataProvider.RemoveTransactionAsync(current.BaseEntity);
                this.transactionModelBindingSource.Remove(current);
                button.Enabled = true;
            }
        }
    }
}
