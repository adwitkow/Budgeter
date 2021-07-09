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

using Budgeter.Core.Entities;

namespace Budgeter.WinForms.Controls
{
    public class IndexedComboBoxItem
    {
        public IndexedComboBoxItem(IIndexed indexed)
        {
            this.Base = indexed;
        }

        public string DisplayName
        {
            get
            {
                if (this.Base is null)
                {
                    return string.Empty;
                }
                else
                {
                    return $"{this.Base.Id}-{this.Base.Name}";
                }
            }
        }

        public IIndexed Base { get; }

        public override string ToString()
        {
            return this.DisplayName;
        }
    }
}
