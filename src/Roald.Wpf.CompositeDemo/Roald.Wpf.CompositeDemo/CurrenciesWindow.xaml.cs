using System;
using System.Windows;

namespace Roald.CompositeDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    internal partial class CurrenciesWindow : Window, ICurrenciesView
    {
        private readonly IGridRegionFactory _gridRegionFactory;

        public CurrenciesWindow(IGridRegionFactory gridRegionFactory)
        {
            _gridRegionFactory = gridRegionFactory;
            InitializeComponent();
            Region = _gridRegionFactory.Create(_currencyGrid);
        }

        public new void Activate()
        {
            Show();
        }
        public void DeActivate()
        {
            Close();
        }

        public IGridRegion Region { get; private set; }

        public void ShowError(string title, string errorMsg)
        {
            throw new NotImplementedException();
        }
    }
}
