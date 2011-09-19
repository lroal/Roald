using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal class CompositeGrid : ICompositeGridSetup
    {
        private readonly IRowFactoryFactory _rowFactoryFactory;
        private readonly IColumnFactoryFactory _columnFactoryFactory;
        private readonly ICompositeDataContext _context;
        private IRowFactory _rowFactory;
        private IColumnFactory _columnFactory;

        public CompositeGrid(IRowFactoryFactory rowFactoryFactory, IColumnFactoryFactory columnFactoryFactory,
                              ICompositeDataContext context)
        {
            _rowFactoryFactory = rowFactoryFactory;
            _columnFactoryFactory = columnFactoryFactory;
            _context = context;
        }

        public void Setup(ContentControl contentControl)
        {
            var grid = new DataGrid();
            grid.AutoGenerateColumns = false;
            contentControl.Content = grid;
            _rowFactory = _rowFactoryFactory.Create(grid, _context);
            _columnFactory = _columnFactoryFactory.Create(grid);
        }

        public IRow CreateRow()
        {
            return _rowFactory.Create();
        }

        public void CreateLeftAlignColumn(string header)
        {
            _columnFactory.CreateLeftAligned(header);
        }

    }
}