using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class RowCellFactory : IRowCellFactory
    {
        private readonly IUnityContainer _container;

        public RowCellFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IRowCell Create(Grid grid)
        {
            var instance = _container.Resolve<IRowCellSetup>();
            instance.Setup(grid);
            return instance;
        }
    }
}