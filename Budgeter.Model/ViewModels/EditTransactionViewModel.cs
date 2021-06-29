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

using System.Collections.Generic;
using System.Threading.Tasks;
using Budgeter.Core.Entities;
using Budgeter.DataAccess;
using Budgeter.Model.Models;

namespace Budgeter.Model.ViewModels
{
    public class EditTransactionViewModel : EditableViewModelBase<TransactionModel>
    {
        private readonly BudgeterDataProvider budgeterDataProvider;

        public EditTransactionViewModel(BudgeterDataProvider budgeterDataProvider)
        {
            this.budgeterDataProvider = budgeterDataProvider;
        }

        public IEnumerable<Category> Categories { get; private set; }

        public IEnumerable<Location> Locations { get; private set; }

        public IEnumerable<Source> Sources { get; private set; }

        public Category Category
        {
            get => this.BaseEntity.Category;
            set
            {
                this.BaseEntity.Category = value;
                this.OnPropertyChanged();
            }
        }

        public Location Location
        {
            get => this.BaseEntity.Location;
            set
            {
                this.BaseEntity.Location = value;
                this.OnPropertyChanged();
            }
        }

        public Source Source
        {
            get => this.BaseEntity.Source;
            set
            {
                this.BaseEntity.Source = value;
                this.OnPropertyChanged();
            }
        }

        public string Description
        {
            get => this.BaseEntity.Description;
            set
            {
                this.BaseEntity.Description = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(this.CanSave));
            }
        }

        public decimal Amount
        {
            get => this.BaseEntity.Amount;
            set
            {
                this.BaseEntity.Amount = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(this.CanSave));
            }
        }

        public string Currency
        {
            get => this.BaseEntity.Currency;
            set
            {
                this.BaseEntity.Currency = value;
                this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(this.CanSave));
            }
        }

        public override bool CanSave => this.Amount != 0 && !string.IsNullOrWhiteSpace(this.Description) && !string.IsNullOrEmpty(this.Currency);

        public override async Task LoadAsync()
        {
            var categoriesTask = this.budgeterDataProvider.GetCategoriesAsync();
            var locationsTask = this.budgeterDataProvider.GetLocationsAsync();
            var sourcesTask = this.budgeterDataProvider.GetSourcesAsync();

            await Task.WhenAll(categoriesTask, locationsTask, sourcesTask);

            this.Categories = await categoriesTask;
            this.Locations = await locationsTask;
            this.Sources = await sourcesTask;
        }

        protected override void CopyProperties(TransactionModel from, TransactionModel to)
        {
            to.Timestamp = from.Timestamp;
            to.Category = from.Category;
            to.Location = from.Location;
            to.Source = from.Source;
            to.Description = from.Description;
            to.Amount = from.Amount;
            to.Currency = from.Currency;

            // TODO: Check performance on below event calls...
            this.OnPropertyChanged(nameof(this.Category));
            this.OnPropertyChanged(nameof(this.Location));
            this.OnPropertyChanged(nameof(this.Source));
            this.OnPropertyChanged(nameof(this.Description));
            this.OnPropertyChanged(nameof(this.Amount));
            this.OnPropertyChanged(nameof(this.Currency));
        }
    }
}
