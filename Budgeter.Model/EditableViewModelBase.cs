using System;
using System.Collections.Generic;
using System.Text;

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
