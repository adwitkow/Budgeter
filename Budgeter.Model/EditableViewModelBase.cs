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

namespace Budgeter.Model
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "Unbound generic type")]
    public abstract class EditableViewModelBase<T> : EditableViewModelBase
    {
        public T BaseEntity { get; set; }

        public override object BaseEntityObject
        {
            get => this.BaseEntity;
            set => this.BaseEntity = (T)value; // TODO: Check type before casting
        }

        protected T BackupEntity { get; set; }

        public override void BeginEdit()
        {
            this.BackupEntity = (T)Activator.CreateInstance(typeof(T));
            this.CopyProperties(this.BaseEntity, this.BackupEntity);
        }

        public override void CancelEdit()
        {
            this.CopyProperties(this.BackupEntity, this.BaseEntity);
        }

        public override void EndEdit()
        {
            this.BackupEntity = (T)Activator.CreateInstance(typeof(T));
        }

        protected abstract void CopyProperties(T from, T to);
    }

    public abstract class EditableViewModelBase : ViewModelBase
    {
        public abstract object BaseEntityObject { get; set; }

        public abstract bool CanSave { get; }

        public abstract void BeginEdit();

        public abstract void CancelEdit();

        public abstract void EndEdit();
    }
}
