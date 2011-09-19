// Type: System.Windows.Documents.Table
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationFramework.dll

using MS.Internal.Documents;
using System.Collections;
using System.ComponentModel;
using System.Runtime;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Markup;

namespace System.Windows.Documents
{
    [ContentProperty("RowGroups")]
    public class Table : Block, IAddChild, IAcceptInsertion
    {
        public static readonly DependencyProperty CellSpacingProperty;
        public Table();
        protected internal override IEnumerator LogicalChildren { get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TableColumnCollection Columns { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TableRowGroupCollection RowGroups { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        [TypeConverter(typeof (LengthConverter))]
        public double CellSpacing { get; set; }

        #region IAddChild Members

        void IAddChild.AddChild(object value);
        void IAddChild.AddText(string text);

        #endregion

        public override void BeginInit();
        public override void EndInit();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeColumns();

        protected override AutomationPeer OnCreateAutomationPeer();
    }
}
