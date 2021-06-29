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
using System.Windows.Forms;
using Budgeter.Model;
using Budgeter.Model.Models;

namespace Budgeter.WinForms.Forms
{
    public partial class EditFormBase<T> : Form
        where T : EditableViewModelBase
    {
        private readonly T editableViewModel;
        private bool saving;

        public EditFormBase()
        {
            this.saving = false;
            this.InitializeComponent();
        }

        public EditFormBase(T editableViewModel)
            : this()
        {
            this.editableViewModel = editableViewModel;
        }

        public virtual void ShowFor(IWin32Window owner, object model)
        {
            this.editableViewModel.BaseEntityObject = model;
            this.ShowDialog(owner);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.editableViewModel.BeginEdit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.saving = true;

            this.editableViewModel.EndEdit();
            this.Close();

            this.saving = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.editableViewModel.CancelEdit();
            this.Close();
        }

        private void EditFormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.saving)
            {
                this.editableViewModel.CancelEdit();
            }
        }
    }
}
