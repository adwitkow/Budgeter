using Budgeter.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            get => this.InternalSelectedItem.Base;
            set
            {
                if (value is null)
                {
                    this.InternalSelectedItem = null;
                }
                else
                {
                    this.InternalSelectedItem = this.lookup?[value.Id];
                }
            }
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

            this.lookup = items.ToDictionary(item => item.Base.Id, item => item);
            this.InternalDataSource = items;

            return items;
        }
    }
}
