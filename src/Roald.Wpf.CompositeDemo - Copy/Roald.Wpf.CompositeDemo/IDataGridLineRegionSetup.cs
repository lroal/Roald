using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IDataGridLineRegionSetup : IDataGridLineRegion
    {
        void Setup(DataGrid grid);
    }
}