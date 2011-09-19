using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IRowFactoryFactory
    {
        IRowFactory Create(DataGrid dataGrid,ICompositeDataContext context);
    }
}