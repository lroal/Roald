using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface ICellSetup : ICell
    {
        void Setup(IContextRow contextRow);
    }
}