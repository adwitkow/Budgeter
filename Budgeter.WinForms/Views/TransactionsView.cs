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

using Budgeter.Model.Models;
using Budgeter.Model.ViewModels;
using Budgeter.WinForms.Forms;

namespace Budgeter.WinForms.Views
{
    public partial class TransactionView : BudgeterView<TransactionViewModel>
    {
        private readonly MainForm mainForm;

        public TransactionView()
            : base()
        {
            this.InitializeComponent();
        }

        public TransactionView(TransactionViewModel viewModel, MainForm mainForm)
            : base(viewModel)
        {
            this.InitializeComponent();
            this.mainForm = mainForm;
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
            using (var editForm = new EditTransactionForm(current))
            {
                editForm.ShowDialog(this.mainForm);
            }
        }
    }
}
