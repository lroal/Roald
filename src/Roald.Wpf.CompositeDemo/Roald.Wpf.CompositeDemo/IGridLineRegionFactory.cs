using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IGridLineRegionFactory
    {
        IGridLineRegion Create(Grid grid,int lineNo);

    }
}