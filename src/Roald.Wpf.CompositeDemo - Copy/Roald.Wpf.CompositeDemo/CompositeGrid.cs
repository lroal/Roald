using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    public class CompositeGrid : ICompositeGridSetup
    {
        private readonly Grid _grid;
        private readonly IRowFactory _rowFactory;
        private readonly IColumnFactory _columnFactory;

        public CompositeGrid(Grid grid, IRowFactory rowFactory, IColumnFactory columnFactory)
        {
            _grid = grid;
            _rowFactory = rowFactory;
            _columnFactory = columnFactory;
        }

        public void Setup(UserControl region)
        {
            region.Content = _grid;
        }

        public IColumn CreateColumn()
        {
            return _columnFactory.Create(_grid);
        }

        public IRow CreateRow()
        {
            return _rowFactory.Create(_grid);
        }
    }
}