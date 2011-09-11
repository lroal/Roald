using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface ICellRegionSetup : ICellRegion
    {
        void Setup(Grid grid, int cellNo);
    }
}