using System;
using System.Windows;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class CellRegion : ICellRegionSetup
    {
        private int _rowNo;
        private Grid _grid;
        private int _cellNo;

        public void Add(object view)
        {
            var theView = (UIElement) view;
            _grid.Children.Add(theView);
            Grid.SetColumn(theView, _cellNo);
            Grid.SetRow(theView, _rowNo);

        }

        public void Remove(object view)
        {
            _grid.Children.Remove((UIElement) view);
        }

        public void Setup(Grid grid, int cellNo)
        {
            _grid = grid;
            _cellNo = cellNo;
            _rowNo = grid.RowDefinitions.Count - 1;
        }
    }
}