using System;
using System.Windows;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    internal partial class CurrenciesWindow : Window, ICurrenciesView
    {
        private readonly IDataGridRegionFactory _gridRegionFactory;

        public CurrenciesWindow(IDataGridRegionFactory gridRegionFactory)
        {
            _gridRegionFactory = gridRegionFactory;
            InitializeComponent();
            
            //Region = _gridRegionFactory.Create(_dataGrid);
        }

        public new void Activate()
        {
            Show();
        }
        public void DeActivate()
        {
            Close();
        }

        public IDataGridRegion Region { get; private set; }

        public void ShowError(string title, string errorMsg)
        {
            throw new NotImplementedException();
        }
    }
}
