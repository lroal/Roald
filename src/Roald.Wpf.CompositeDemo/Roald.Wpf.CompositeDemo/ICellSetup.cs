using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface ICellSetup : ICell
    {
        void Setup(Grid grid, int rowNo, int columnNo);
    }
}