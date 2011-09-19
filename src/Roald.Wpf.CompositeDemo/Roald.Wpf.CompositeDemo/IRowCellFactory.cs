using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IRowCellFactory
    {
        ICell Create();
    }
}