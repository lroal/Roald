using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IDataCellRegionSetup : IDataCellRegion
    {
        void Setup(ContentControl control);
    }
}