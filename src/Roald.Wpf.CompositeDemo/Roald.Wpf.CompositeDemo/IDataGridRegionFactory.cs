using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IDataGridRegionFactory
    {
        IDataGridRegion Create(DataGrid grid);
    }
}