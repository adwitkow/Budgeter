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

using System.Collections.ObjectModel;
using Budgeter.DataAccess;

namespace Budgeter.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly BudgeterDataProvider budgeterDataProvider;

        public MainViewModel(BudgeterDataProvider budgeterDataProvider)
        {
            this.budgeterDataProvider = budgeterDataProvider;

            this.Cashflows = new ObservableCollection<CashflowViewModel>();

            var cashflowModels = budgeterDataProvider.GetCashflows();
            foreach (var cashflow in cashflowModels)
            {
                this.Cashflows.Add(new CashflowViewModel(cashflow));
            }
        }

        public ObservableCollection<CashflowViewModel> Cashflows { get; }
    }
}
