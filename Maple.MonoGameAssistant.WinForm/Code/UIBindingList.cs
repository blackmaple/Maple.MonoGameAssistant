using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Maple.MonoGameAssistant.WinForm
{
    public class UIBindingList<T> : BindingList<T>
    {
        public UIBindingList() : base() { }
        public UIBindingList(IList<T> list) : base(list) { }

        public void AddRange(IEnumerable<T> list)
        {
            ArgumentNullException.ThrowIfNull(list);
            this.RaiseListChangedEvents = false;
            foreach (var data in list)
            {
                this.Add(data);
            }
            this.RaiseListChangedEvents = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));
        }


        public void RemoveRange(IEnumerable<T> list)
        {
            ArgumentNullException.ThrowIfNull(list);
            this.RaiseListChangedEvents = false;
            foreach (var data in list)
            {
                this.Remove(data);
            }
            this.RaiseListChangedEvents = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));
        }

        public void ReplaceRange(IEnumerable<T> list)
        {
            ArgumentNullException.ThrowIfNull(list);
            this.RaiseListChangedEvents = false;
            this.Clear();
            foreach (var data in list)
            {
                this.Add(data);
            }
            this.RaiseListChangedEvents = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));
        }
    }

}
