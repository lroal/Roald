using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IDataCellRegionFactory
    {
        IDataCellRegion Create(ContentControl control);
    }
}