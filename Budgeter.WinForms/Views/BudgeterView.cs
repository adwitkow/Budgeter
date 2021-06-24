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
using Budgeter.Model;

namespace Budgeter.WinForms.Views
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "The second type is an unbound generic type.")]
    public class BudgeterView<TViewModel> : BudgeterView
        where TViewModel : ViewModelBase
    {
        public BudgeterView(TViewModel viewModel)
            : base()
        {
            this.ViewModel = viewModel;
        }

        protected BudgeterView()
        {
        }

        protected TViewModel ViewModel { get; }

        public virtual void OnActivated()
        {
        }
    }

    public class BudgeterView : UserControl
    {
    }
}
