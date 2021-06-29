﻿// This file is part of Budgeter project <https://github.com/adwitkow/Budgeter>
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
using System;

namespace Budgeter.WinForms.Forms
{
    public partial class EditTransactionForm : EditFormBase<EditTransactionViewModel>
    {
        private readonly EditTransactionViewModel viewModel;

        public EditTransactionForm(EditTransactionViewModel viewModel)
            : base(viewModel)
        {
            this.InitializeComponent();

            this.editTransactionViewModelBindingSource.DataSource = viewModel;
            this.viewModel = viewModel;
        }

        protected async override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            await viewModel.LoadAsync();

            this.categoryBindingSource.DataSource = viewModel.Categories;
            this.locationBindingSource.DataSource = viewModel.Locations;
            this.sourceBindingSource.DataSource = viewModel.Sources;
        }
    }
}
