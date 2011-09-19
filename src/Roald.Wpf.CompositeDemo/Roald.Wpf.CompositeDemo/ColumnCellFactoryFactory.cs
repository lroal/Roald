using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class ColumnCellFactoryFactory : IColumnCellFactoryFactory
    {
        private readonly IUnityContainer _container;

        public ColumnCellFactoryFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IColumnCellFactory Create(Grid grid)
        {
            var instance = _container.Resolve<IColumnCellFactorySetup>();
            instance.Setup(grid);
            return instance;
        }
    }
}