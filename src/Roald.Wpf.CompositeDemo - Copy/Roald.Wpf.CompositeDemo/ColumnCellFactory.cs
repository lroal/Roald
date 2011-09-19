using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class ColumnCellFactory : IColumnCellFactory
    {
        private readonly IUnityContainer _container;

        public ColumnCellFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IColumnCell Create(Grid grid)
        {
            var instance = _container.Resolve<IColumnCellSetup>();
            instance.Setup(grid);
            return instance;
        }
    }
}