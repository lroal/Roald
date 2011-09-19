using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IColumnCellFactoryFactory
    {
        IColumnCellFactory Create(Grid grid);
    }
}