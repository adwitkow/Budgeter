using Budgeter.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeter.WinForms.Forms
{
    public partial class EditTransactionForm : EditFormBase<TransactionModel>
    {
        public EditTransactionForm()
        {
            this.InitializeComponent();
        }

        public EditTransactionForm(TransactionModel model)
            : base(model)
        {
            this.InitializeComponent();
        }
    }
}
