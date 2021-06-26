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

using Budgeter.Model.ViewModels;

namespace Budgeter.WinForms.Views
{
    public partial class TransactionView : BudgeterView<TransactionViewModel>
    {
        public TransactionView()
            : base()
        {
            this.InitializeComponent();
        }

        public TransactionView(TransactionViewModel viewModel)
            : base(viewModel)
        {
            this.InitializeComponent();
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
    }
}
