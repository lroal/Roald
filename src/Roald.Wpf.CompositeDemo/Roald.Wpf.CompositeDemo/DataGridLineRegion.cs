using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    public class DataGridLineRegion : IDataGridLineRegionSetup, INotifyPropertyChanged
    {
        private readonly IDataCellRegionFactory _cellRegionFactory;

        public DataGridLineRegion(IDataCellRegionFactory cellRegionFactory)
        {
            Cells = new ObservableCollection<Control>();            
            _cellRegionFactory = cellRegionFactory;
        }

        public IDataCellRegion CreateCell()
        {
            var control = new ContentControl();
            control.IsTabStop = false;
            var cell=  _cellRegionFactory.Create(control);
            Cells.Add(control);;
            return cell;
        }

        public void Setup(DataGrid dataGrid)
        {
            dataGrid.Items.Add(this);
        }

        public ObservableCollection<Control> Cells
        {
            get; private set; }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}