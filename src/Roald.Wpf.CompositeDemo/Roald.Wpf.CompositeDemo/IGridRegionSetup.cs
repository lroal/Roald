using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IGridRegionSetup : IGridRegion
    {
        void Setup(Grid grid);
    }
}