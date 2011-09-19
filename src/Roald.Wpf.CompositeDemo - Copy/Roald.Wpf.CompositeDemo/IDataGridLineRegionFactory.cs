using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IDataGridLineRegionFactory
    {
        IDataGridLineRegion Create(DataGrid grid);

    }
}