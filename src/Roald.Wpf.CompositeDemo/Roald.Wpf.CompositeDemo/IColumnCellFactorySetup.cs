using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IColumnCellFactorySetup : IColumnCellFactory
    {
        void Setup(Grid grid);
    }
}