using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IColumnSetup : IColumn
    {
        void Setup(DataGrid grid);
    }
}