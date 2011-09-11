using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IGridRegionFactory
    {
        IGridRegion Create(Grid grid);
    }
}