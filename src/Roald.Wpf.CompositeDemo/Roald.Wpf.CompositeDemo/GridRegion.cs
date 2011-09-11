using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class GridRegion : IGridRegionSetup
    {
        private readonly IGridLineRegionFactory _gridLineRegionFactory;
        private Grid _grid;
        private int _lineNo = -1;

        public GridRegion(IGridLineRegionFactory gridLineRegionFactory)
        {
            _gridLineRegionFactory = gridLineRegionFactory;
        }

        public IGridLineRegion CreateLine()
        {            
            _lineNo++;
            var rowDefinition = new RowDefinition();
            _grid.RowDefinitions.Add(rowDefinition);
            return _gridLineRegionFactory.Create(_grid, _lineNo);            
        }

        public void Setup(Grid grid)
        {
            _grid = grid;
        }
    }
}