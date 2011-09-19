using System.Windows;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class Cell : ICellSetup
    {
        private readonly ICellView _cellView;
        private Grid _grid;
        private int _columnNo;
        private int _rowNo;

        public Cell(ICellView cellView)
        {
            this._cellView = cellView;
        }

        public void Setup(Grid grid, int rowNo,int columnNo)
        {
            _grid = grid;
            _columnNo = columnNo;
            _rowNo = rowNo;
            var element = (UIElement)_cellView;
            _grid.Children.Add(element);
            Grid.SetRow(element, _rowNo);
            Grid.SetColumn(element, _columnNo);
        }

        public void Add(object view)
        {
            _cellView.Add(view);
        }

        public void Remove(object view)
        {
            _cellView.Clear();
        }
    }
}