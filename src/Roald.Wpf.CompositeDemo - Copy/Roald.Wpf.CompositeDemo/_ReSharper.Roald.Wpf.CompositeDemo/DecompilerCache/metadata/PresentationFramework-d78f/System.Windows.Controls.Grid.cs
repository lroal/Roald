// Type: System.Windows.Controls.Grid
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System.Collections;
using System.ComponentModel;
using System.Runtime;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace System.Windows.Controls
{
    public class Grid : Panel, IAddChild
    {
        public static readonly DependencyProperty ShowGridLinesProperty;
        public static readonly DependencyProperty ColumnProperty;
        public static readonly DependencyProperty RowProperty;
        public static readonly DependencyProperty ColumnSpanProperty;
        public static readonly DependencyProperty RowSpanProperty;
        public static readonly DependencyProperty IsSharedSizeScopeProperty;
        public Grid();
        protected internal override IEnumerator LogicalChildren { get; }

        public bool ShowGridLines { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ColumnDefinitionCollection ColumnDefinitions { get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public RowDefinitionCollection RowDefinitions { get; }

        protected override int VisualChildrenCount { get; }

        #region IAddChild Members

        void IAddChild.AddChild(object value);
        void IAddChild.AddText(string text);

        #endregion

        public static void SetColumn(UIElement element, int value);

        [AttachedPropertyBrowsableForChildren]
        public static int GetColumn(UIElement element);

        public static void SetRow(UIElement element, int value);

        [AttachedPropertyBrowsableForChildren]
        public static int GetRow(UIElement element);

        public static void SetColumnSpan(UIElement element, int value);

        [AttachedPropertyBrowsableForChildren]
        public static int GetColumnSpan(UIElement element);

        public static void SetRowSpan(UIElement element, int value);

        [AttachedPropertyBrowsableForChildren]
        public static int GetRowSpan(UIElement element);

        public static void SetIsSharedSizeScope(UIElement element, bool value);
        public static bool GetIsSharedSizeScope(UIElement element);
        protected override Visual GetVisualChild(int index);
        protected override Size MeasureOverride(Size constraint);
        protected override Size ArrangeOverride(Size arrangeSize);

        protected internal override void OnVisualChildrenChanged(DependencyObject visualAdded,
                                                                 DependencyObject visualRemoved);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeColumnDefinitions();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRowDefinitions();
    }
}
