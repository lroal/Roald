using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IColumnFactorySetup : IColumnFactory
    {
        void Setup(DataGrid grid);
    }
}