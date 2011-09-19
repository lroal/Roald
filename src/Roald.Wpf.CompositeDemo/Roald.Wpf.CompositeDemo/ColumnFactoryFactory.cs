using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class ColumnFactoryFactory : IColumnFactoryFactory
    {
        private readonly IUnityContainer _container;

        public ColumnFactoryFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IColumnFactory Create(DataGrid grid)
        {
            var instance = _container.Resolve<IColumnFactorySetup>();
            instance.Setup(grid);
            return instance;
        }
    }
}