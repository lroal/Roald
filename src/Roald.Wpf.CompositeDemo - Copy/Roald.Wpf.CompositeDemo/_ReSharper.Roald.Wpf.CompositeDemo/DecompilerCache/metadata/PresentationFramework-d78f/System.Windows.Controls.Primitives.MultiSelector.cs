// Type: System.Windows.Controls.Primitives.MultiSelector
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System.Collections;
using System.ComponentModel;
using System.Runtime;

namespace System.Windows.Controls.Primitives
{
    public abstract class MultiSelector : Selector
    {
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        protected MultiSelector();

        protected bool CanSelectMultipleItems { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Category("Appearance")]
        [Bindable(true)]
        public IList SelectedItems { get; }

        protected bool IsUpdatingSelectedItems { get; }

        protected void BeginUpdateSelectedItems();
        protected void EndUpdateSelectedItems();
        public void SelectAll();
        public void UnselectAll();
    }
}
