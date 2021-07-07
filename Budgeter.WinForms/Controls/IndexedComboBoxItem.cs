using Budgeter.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeter.WinForms.Controls
{
    class IndexedComboBoxItem
    {
        public IndexedComboBoxItem(IIndexed indexed)
        {
            this.Base = indexed;
        }

        public string DisplayName => $"{this.Base.Id}-{this.Base.Name}";

        public IIndexed Base { get; }

        public override string ToString()
        {
            return this.DisplayName;
        }
    }
}
