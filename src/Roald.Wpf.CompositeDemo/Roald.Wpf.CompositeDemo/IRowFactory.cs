using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    public interface IRowFactory
    {
        IRow Create(Grid grid);
    }
}