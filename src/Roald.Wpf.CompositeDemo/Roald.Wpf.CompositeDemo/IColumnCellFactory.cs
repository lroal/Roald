using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IColumnCellFactory
    {
        ICell Create();
    }
}