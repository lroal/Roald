using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class Column : IColumnSetup
    {
        private readonly IColumnCellFactory _cellFactory;
        private Grid _grid;

        public Column(IColumnCellFactory cellFactory)
        {
            _cellFactory = cellFactory;
        }

        public ICell CreateCell()
        {
            return _cellFactory.Create(_grid);
        }

        public void Setup(Grid grid)
        {
            _grid = grid;
        }
    }
}