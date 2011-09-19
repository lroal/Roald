using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class Row : IRowSetup
    {
        private readonly IRowCellFactoryFactory _cellFactoryFactory;
        private IRowCellFactory _cellFactory;   

        public Row(IRowCellFactoryFactory cellFactoryFactory)
        {
            _cellFactoryFactory = cellFactoryFactory;
        }

        public ICell CreateCell()
        {
            return _cellFactory.Create();
        }

        public void Setup(Grid grid)
        {
            //var dataGrid = new DataGrid();
            //dataGrid.Columns.Add()

            var rowDef = new RowDefinition();
            grid.RowDefinitions.Add(rowDef);
            _cellFactory = _cellFactoryFactory.Create(grid);
        }
    }
}