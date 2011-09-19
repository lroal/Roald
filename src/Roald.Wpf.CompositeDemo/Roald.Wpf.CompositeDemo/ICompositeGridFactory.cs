using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    public interface ICompositeGridFactory 
    {
        ICompositeGrid Create(Grid grid);
    }
}