using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class RowCellFactoryFactory : IRowCellFactoryFactory
    {
        private readonly IUnityContainer _container;

        public RowCellFactoryFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IRowCellFactory Create(Grid grid)
        {
            var instance = _container.Resolve<IRowCellFactorySetup>();
            instance.Setup(grid);
            return instance;
        }
    }
}