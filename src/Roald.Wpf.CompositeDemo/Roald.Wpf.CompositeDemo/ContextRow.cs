using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class ContextRow : IContextRowSetup
    {
        private readonly ObservableCollection<Control> _cellViews = new ObservableCollection<Control>();
        private int _currentColumnNo;

        public UIElement this[int index]             
        {
            get
            {
                return _cellViews[index];
            }
        }

        public string Jalla
        {
            get { return "jalla"; }
        }


        public void AddCell(ICellView element)
        {
            _cellViews[_currentColumnNo] = (Control) element;
            _cellViews.Add((Control) (element));
            _currentColumnNo++;
        }

        public void Setup(int numberOfColumns)
        {
            for (int columnNo = 0; columnNo < numberOfColumns; columnNo++)
            {
                var content = new ContentControl();
                content.IsTabStop = false;
                _cellViews.Add(content);
            }
            
        }
    }
}