using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IDataGridRegionSetup : IDataGridRegion
    {
        void Setup(DataGrid grid);
    }
}