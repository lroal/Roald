// Type: System.Windows.Controls.DataGridTextColumn
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System.ComponentModel;
using System.Runtime;
using System.Windows;
using System.Windows.Media;

namespace System.Windows.Controls
{
    public class DataGridTextColumn : DataGridBoundColumn
    {
        public static readonly DependencyProperty FontFamilyProperty;
        public static readonly DependencyProperty FontSizeProperty;
        public static readonly DependencyProperty FontStyleProperty;
        public static readonly DependencyProperty FontWeightProperty;
        public static readonly DependencyProperty ForegroundProperty;

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public DataGridTextColumn();

        public static Style DefaultElementStyle { get; }
        public static Style DefaultEditingElementStyle { get; }
        public FontFamily FontFamily { get; set; }

        [Localizability(LocalizationCategory.None)]
        [TypeConverter(typeof (FontSizeConverter))]
        public double FontSize { get; set; }

        public FontStyle FontStyle { get; set; }
        public FontWeight FontWeight { get; set; }
        public Brush Foreground { get; set; }
        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem);
        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem);
        protected internal override void RefreshCellContent(FrameworkElement element, string propertyName);
        protected override object PrepareCellForEdit(FrameworkElement editingElement, RoutedEventArgs editingEventArgs);
    }
}
