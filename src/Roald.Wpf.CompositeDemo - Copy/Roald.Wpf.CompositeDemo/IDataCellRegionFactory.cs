using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    public interface IDataCellRegionFactory
    {
        IDataCellRegion Create(ContentControl control);
    }
}