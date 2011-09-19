using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Roald.CompositeDemo
{
    internal interface ICompositeDataContext :  INotifyCollectionChanged, INotifyPropertyChanged, ICollection<IContextRow>
    {
        IContextRow CreateContextRow();
    }
}