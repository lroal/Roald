// Type: System.Windows.Controls.DataGridTemplateColumn
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using System.Runtime;
using System.Windows;

namespace System.Windows.Controls
{
    public class DataGridTemplateColumn : DataGridColumn
    {
        public static readonly DependencyProperty CellTemplateProperty;
        public static readonly DependencyProperty CellTemplateSelectorProperty;
        public static readonly DependencyProperty CellEditingTemplateProperty;
        public static readonly DependencyProperty CellEditingTemplateSelectorProperty;

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public DataGridTemplateColumn();

        public DataTemplate CellTemplate { get; set; }
        public DataTemplateSelector CellTemplateSelector { get; set; }
        public DataTemplate CellEditingTemplate { get; set; }
        public DataTemplateSelector CellEditingTemplateSelector { get; set; }

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem);

        protected internal override void RefreshCellContent(FrameworkElement element, string propertyName);
    }
}
