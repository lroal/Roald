using System;
using System.Windows;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class DataCellRegion : IDataCellRegionSetup
    {
        private ContentControl _control;

        public void Add(object view)
        {
            _control.Content = view;
        }

        public void Remove(object view)
        {
            _control.Content = null;
        }

        public void Setup(ContentControl control)
        {            
            _control = control;
        }

    }
}