using System;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IRowCellFactoryFactory
    {
        IRowCellFactory Create(IContextRow contextRow);
    }
}