using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IGridLineRegionSetup : IGridLineRegion
    {
        void Setup(Grid grid, int lineNo);
    }
}