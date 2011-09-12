using System.Windows.Controls;

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
            _dataGrid = dataGrid;
        }
    }
}