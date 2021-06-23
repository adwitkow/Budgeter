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
using Budgeter.Core.Entities;

namespace Budgeter.Model.Models
{
    public class CashflowModel : ModelBase<Cashflow>
    {
        public CashflowModel(Cashflow cashflow)
            : base(cashflow)
        {
        }

        public DateTime Timestamp
        {
            get => this.BaseEntity.Timestamp;
            set
            {
                if (this.BaseEntity.Timestamp != value)
                {
                    this.BaseEntity.Timestamp = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public string CategoryName => this.BaseEntity.Category?.Name;

        public Category Category
        {
            get => this.BaseEntity.Category;
            set
            {
                if (this.BaseEntity.Category != value)
                {
                    this.BaseEntity.Category = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(this.CategoryName));
                }
            }
        }

        public string LocationName => this.BaseEntity.Location?.Name;

        public Location Location
        {
            get => this.BaseEntity.Location;
            set
            {
                if (this.BaseEntity.Location != value)
                {
                    this.BaseEntity.Location = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(this.LocationName));
                }
            }
        }

        public string SourceName => this.BaseEntity.Source?.Name;

        public Source Source
        {
            get => this.BaseEntity.Source;
            set
            {
                if (this.BaseEntity.Source != value)
                {
                    this.BaseEntity.Source = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(this.SourceName));
                }
            }
        }

        public string Description
        {
            get => this.BaseEntity.Description;
            set
            {
                if (this.BaseEntity.Description != value)
                {
                    this.BaseEntity.Description = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public string Value => $"{this.BaseEntity.Amount:0.00} {this.BaseEntity.Currency}";

        public decimal Amount
        {
            get => this.BaseEntity.Amount;
            set
            {
                if (this.BaseEntity.Amount != value)
                {
                    this.BaseEntity.Amount = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(this.Value));
                }
            }
        }

        public string Currency
        {
            get => this.BaseEntity.Currency;
            set
            {
                if (this.BaseEntity.Currency != value)
                {
                    this.BaseEntity.Currency = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(this.Value));
                }
            }
        }
    }
}
