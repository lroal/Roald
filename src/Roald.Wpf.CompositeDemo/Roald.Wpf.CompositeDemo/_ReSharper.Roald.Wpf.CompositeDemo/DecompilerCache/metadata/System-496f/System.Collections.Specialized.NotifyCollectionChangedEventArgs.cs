// Type: System.Collections.Specialized.NotifyCollectionChangedEventArgs
// Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.dll

using System;
using System.Collections;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace System.Collections.Specialized
{
    [TypeForwardedFrom("WindowsBase, Version=3.0.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index);
        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems);

        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems,
                                                int startingIndex);

        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem);

        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem,
                                                int index);

        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems);

        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems,
                                                int startingIndex);

        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index,
                                                int oldIndex);

        public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index,
                                                int oldIndex);

        public NotifyCollectionChangedAction Action { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public IList NewItems { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public IList OldItems { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public int NewStartingIndex { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public int OldStartingIndex { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }
    }
}
