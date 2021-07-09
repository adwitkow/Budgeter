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
using System.Linq;
using System.Windows.Forms;
using Budgeter.Core.Entities;

namespace Budgeter.WinForms.Controls
{
    public class IndexedComboBox : ComboBox
    {
        private Dictionary<int, IndexedComboBoxItem> lookup;

        public IndexedComboBox()
            : base()
        {
            this.ValueMember = null;
            this.DisplayMember = "DisplayName";
        }

        public new IEnumerable<IIndexed> DataSource
        {
            get => this.ConvertFromInternalDataSource();
            set => this.ConvertToInternalDataSource(value);
        }

        public new IIndexed SelectedItem
        {
            get => this.InternalSelectedItem?.Base;
            set => this.InternalSelectedItem = this.lookup?[value?.Id ?? 0];
        }

        private IList<IndexedComboBoxItem> InternalDataSource
        {
            get => (IList<IndexedComboBoxItem>)base.DataSource;
            set => base.DataSource = value;
        }

        private IndexedComboBoxItem InternalSelectedItem
        {
            get => (IndexedComboBoxItem)base.SelectedItem;
            set => base.SelectedItem = value;
        }

        private IEnumerable<IIndexed> ConvertFromInternalDataSource()
        {
            return this.InternalDataSource.Select(item => item.Base);
        }

        private IEnumerable<IndexedComboBoxItem> ConvertToInternalDataSource(IEnumerable<IIndexed> values)
        {
            var items = values.Select(item => new IndexedComboBoxItem(item)).ToList();

            items.Insert(0, new IndexedComboBoxItem(null));

            this.lookup = items.ToDictionary(item => item.Base?.Id ?? 0, item => item);

            this.InternalDataSource = items;

            return items;
        }
    }
}
