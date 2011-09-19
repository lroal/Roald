using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IRowSetup : IRow
    {
        void Setup(Grid grid);
    }
}