using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    public class CompositeGrid : ICompositeGridSetup
    {
        private Grid _grid;
        private readonly IRowFactory _rowFactory;
        private readonly IColumnFactory _columnFactory;

        public CompositeGrid(IRowFactory rowFactory, IColumnFactory columnFactory)
        {
            _rowFactory = rowFactory;
            _columnFactory = columnFactory;
        }

        public void Setup(Grid grid)
        {            
            _grid = grid;
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