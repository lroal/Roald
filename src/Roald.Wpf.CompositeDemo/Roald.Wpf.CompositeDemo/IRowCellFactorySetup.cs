using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface  IRowCellFactorySetup : IRowCellFactory
    {
        void Setup(Grid grid);
    }
}