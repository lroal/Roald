using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class ColumnFactory : IColumnFactory
    {
        private readonly IUnityContainer _container;

        public ColumnFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IColumn Create(Grid grid)
        {
            var instance = _container.Resolve<IColumnSetup>();
            instance.Setup(grid);
            return instance;
        }
    }
}