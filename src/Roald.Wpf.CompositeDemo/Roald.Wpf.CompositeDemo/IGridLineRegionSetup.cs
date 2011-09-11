using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IGridLineRegionSetup : IGridLineRegion
    {
        void Setup(Grid grid, int lineNo);
    }

    class GridLineRegion : IGridLineRegionSetup
    {
        private readonly ICellRegionFactory _cellRegionFactory;
        private int _lineNo;
        private Grid _grid;
        private int _cellNo = -1;

        public GridLineRegion(ICellRegionFactory cellRegionFactory)
        {
            _cellRegionFactory = cellRegionFactory;
        }

        public ICellRegion CreateCell()
        {
            _cellNo++;
            return _cellRegionFactory.Create(_grid, _cellNo);
        }

        public void Setup(Grid grid, int lineNo)
        {
            _grid = grid;
            _lineNo = lineNo;
        }
    }
}