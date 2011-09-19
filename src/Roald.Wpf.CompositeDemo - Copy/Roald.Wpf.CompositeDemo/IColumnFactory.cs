using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    public interface IColumnFactory
    {
        IColumn Create(Grid grid);
    }
}