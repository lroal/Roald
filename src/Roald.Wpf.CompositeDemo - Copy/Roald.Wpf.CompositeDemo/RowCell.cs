using System;
using System.Windows;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class RowCell : IRowCellSetup
    {
        private Grid _grid;
        private int _columnNo;
        private int _rowNo;

        public void Setup(Grid grid)
        {
            _grid = grid;
            _columnNo = _grid.ColumnDefinitions.Count;
            _rowNo = _grid.ColumnDefinitions.Count;
        }

        public void Add(object view)
        {
            _columnNo++;
            var element = (UIElement) view;
            _grid.Children.Add(element);
            Grid.SetRow(element, _rowNo);
            Grid.SetColumn(element, _columnNo);
        }

        public void Remove(object view)
        {
            _grid.Children.Remove((UIElement) view);
        }
    }
}