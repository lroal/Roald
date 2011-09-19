using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IColumnCellSetup : IColumnCell
    {
        void Setup(Grid grid);
    }
}