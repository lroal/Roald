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
    /// Interaction logic for ValueView.xaml
    /// </summary>
    internal partial class ValueView : UserControl, IValueView
    {
        private decimal _value;

        public ValueView()
        {
            InitializeComponent();
            DataContext = this;
        }

        public void SetValue(decimal value)
        {
            _value = value;
        }

        public decimal Value
        {
            get { return _value; }

            set
            {
                if (value < 0)
                    throw new InvalidOperationException("cann be lesz than zero");
                _value = value;
            }
        }
    }
}
