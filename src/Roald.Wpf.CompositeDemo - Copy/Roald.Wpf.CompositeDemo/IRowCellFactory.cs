using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IRowCellFactory
    {
        IRowCell Create(Grid grid );
    }
}