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
    public partial class EditFormBase<T> : Form
        where T : IEditableObject
    {
        private readonly T editableObject;

        public EditFormBase()
        {
            this.InitializeComponent();
        }

        public EditFormBase(T editableObject)
        {
            this.editableObject = editableObject;
            this.editableObject.BeginEdit();

            this.InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.editableObject.EndEdit();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.editableObject.CancelEdit();
            this.Close();
        }

        private void EditFormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.editableObject.CancelEdit();
        }
    }
}
