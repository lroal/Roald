using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IColumnFactoryFactory
    {
        IColumnFactory Create(DataGrid grid);
    }
}