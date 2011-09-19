using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class Row : IRowSetup
    {
        private readonly IRowCellFactory _cellFactory;
        private Grid _grid;

        public Row(IRowCellFactory cellFactory)
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