using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Roald.CompositeDemo
{
    class DataGridRegion : IDataGridRegionSetup
    {
        private readonly IDataGridLineRegionFactory _dataGridLineRegionFactory;
        private DataGrid _dataGrid;

        public DataGridRegion(IDataGridLineRegionFactory dataGridLineRegionFactory)
        {
            _dataGridLineRegionFactory = dataGridLineRegionFactory;
        }

        public IDataGridLineRegion CreateLine()
        {
            return _dataGridLineRegionFactory.Create(_dataGrid);
        }

        public void Setup(DataGrid dataGrid)
        {
            var index = 0;
            foreach (var column in dataGrid.Columns)
            {   var templateColumn = column as DataGridTemplateColumn;
                if (templateColumn !=  null)
                {
                    var template = new DataTemplate();
                    var factory = new FrameworkElementFactory(typeof(ContentControl));
                    template.VisualTree = factory;
                    factory.SetValue(Control.IsTabStopProperty, false);
                    var cellString = string.Format("Cells[{0}]", index);
                    factory.SetBinding(ContentControl.ContentProperty, new Binding(cellString));
                    templateColumn.CellTemplate = template;
                    index++;
                }
            }

            _dataGrid = dataGrid;
        }
    }
}