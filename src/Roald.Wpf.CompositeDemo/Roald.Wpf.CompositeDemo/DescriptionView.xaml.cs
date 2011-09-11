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
    /// Interaction logic for DescriptionView.xaml
    /// </summary>
    public partial class DescriptionView : UserControl, IDescriptionView
    {
        public DescriptionView()
        {
            InitializeComponent();
        }

        public void SetDescription(string description)
        {
            _description.Text = description;
        }
    }
}
