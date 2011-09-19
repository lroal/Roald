using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class Column : IColumnSetup
    {
        private readonly IColumnCellFactoryFactory _cellFactoryFactory;
        private IColumnCellFactory _cellFactory;

        public Column(IColumnCellFactoryFactory cellFactoryFactory)
        {
            _cellFactoryFactory = cellFactoryFactory;
        }

        public ICell CreateCell()
        {
            return _cellFactory.Create();
        }

        public void Setup(Grid grid)
        {
            var columnDef = new ColumnDefinition();
            grid.ColumnDefinitions.Add(columnDef);
            _cellFactory = _cellFactoryFactory.Create(grid);
        }
    }
}