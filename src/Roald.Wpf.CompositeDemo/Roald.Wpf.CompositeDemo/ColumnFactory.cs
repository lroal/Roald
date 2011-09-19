using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Roald.CompositeDemo
{
    internal class ColumnFactory : IColumnFactorySetup
    {        
        private DataGrid _grid;
        private int _index;

        public void CreateLeftAligned(string header)
        {
            var column = new DataGridTemplateColumn();
            column.Header = header;
            var template = new DataTemplate();
            var factory = new FrameworkElementFactory(typeof(ContentControl));
            template.VisualTree = factory;
            factory.SetValue(Control.IsTabStopProperty, false);
            string cellString = string.Format("[{0}]", _index);
            factory.SetBinding(ContentControl.ContentProperty, new Binding(cellString));
            column.CellTemplate = template;
            _grid.Columns.Add(column);
            _index++;
        }

        public void Setup(DataGrid grid)
        {
            _grid = grid;
        }
    }
}