using System;
using System.Windows;

namespace Roald.CompositeDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    internal partial class CurrenciesWindow : Window, ICurrenciesView
    {
        private readonly ICompositeGridFactory _gridFactory;

        public CurrenciesWindow(ICompositeGridFactory gridFactory)
        {
            _gridFactory = gridFactory;
            InitializeComponent();
            Grid = _gridFactory.Create(_gridRegion);
            Grid.CreateLeftAlignColumn("Code");
            Grid.CreateLeftAlignColumn("Value");
            Grid.CreateLeftAlignColumn("Description");
        }

        public new void Activate()
        {
            Show();
        }
        public void DeActivate()
        {
            Close();
        }

        public ICompositeGrid Grid { get; private set; }

        public IDataGridRegion GridRegion { get; private set; }

        public void ShowError(string title, string errorMsg)
        {
            throw new NotImplementedException();
        }


    }
}
