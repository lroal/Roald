﻿using System;
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
        public ValueView()
        {
            InitializeComponent();
        }

        public void SetValue(decimal value)
        {
            _value.Text = value.ToString();
        }
    }
}
