using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Roald.CompositeDemo
{
    /// <summary>
    /// Interaction logic for CellView.xaml
    /// </summary>
    public partial class CellView : UserControl, ICellView
    {

        public CellView()
        {
            InitializeComponent();
        }

        public void Add(object content)
        {
            _content.Content = (UIElement) content;
        }

        public void Clear()
        {
            _content.Content = null;
        }
    }

    public interface ICellView
    {
        void Add(object content);
        void Clear();
    }

}
