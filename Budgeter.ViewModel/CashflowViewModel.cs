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
using Budgeter.Core.Model;

namespace Budgeter.ViewModel
{
    public class CashflowViewModel : ViewModelBase
    {
        public CashflowViewModel(Cashflow cashflow)
        {
            this.Cashflow = cashflow;
        }

        public Cashflow Cashflow { get; }

        public DateTime Timestamp
        {
            get => this.Cashflow.Timestamp;
            set
            {
                if (this.Cashflow.Timestamp != value)
                {
                    this.Cashflow.Timestamp = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public string CategoryName => this.Cashflow.Category?.Name;

        public Category Category
        {
            get => this.Cashflow.Category;
            set
            {
                if (this.Cashflow.Category != value)
                {
                    this.Cashflow.Category = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(this.CategoryName));
                }
            }
        }

        public string LocationName => this.Cashflow.Location?.Name;

        public Location Location
        {
            get => this.Cashflow.Location;
            set
            {
                if (this.Cashflow.Location != value)
                {
                    this.Cashflow.Location = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(this.LocationName));
                }
            }
        }

        public string SourceName => this.Cashflow.Source?.Name;

        public Source Source
        {
            get => this.Cashflow.Source;
            set
            {
                if (this.Cashflow.Source != value)
                {
                    this.Cashflow.Source = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(this.SourceName));
                }
            }
        }

        public string Description
        {
            get => this.Cashflow.Description;
            set
            {
                if (this.Cashflow.Description != value)
                {
                    this.Cashflow.Description = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public string Value => $"{this.Cashflow.Amount:0.00} {this.Cashflow.Currency}";

        public decimal Amount
        {
            get => this.Cashflow.Amount;
            set
            {
                if (this.Cashflow.Amount != value)
                {
                    this.Cashflow.Amount = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(this.Value));
                }
            }
        }

        public string Currency
        {
            get => this.Cashflow.Currency;
            set
            {
                if (this.Cashflow.Currency != value)
                {
                    this.Cashflow.Currency = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(this.Value));
                }
            }
        }
    }
}
