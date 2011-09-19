using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IRowCellSetup : IRowCell
    {
        void Setup(Grid grid);
    }
}