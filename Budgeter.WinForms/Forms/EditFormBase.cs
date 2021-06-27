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
        private bool saving;

        public EditFormBase()
        {
            this.saving = false;
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
            this.saving = true;

            this.editableObject.EndEdit();
            this.Close();

            this.saving = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.editableObject.CancelEdit();
            this.Close();
        }

        private void EditFormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.saving)
            {
                this.editableObject.CancelEdit();
            }
        }
    }
}
