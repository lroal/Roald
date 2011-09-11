using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface ICellRegionFactory
    {
        ICellRegion Create(Grid grid, int cellNo);
    }
}