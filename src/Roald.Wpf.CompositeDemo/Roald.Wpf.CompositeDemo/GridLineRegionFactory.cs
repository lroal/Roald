using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class GridLineRegionFactory : IGridLineRegionFactory
    {
        private readonly IUnityContainer _container;

        public GridLineRegionFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IGridLineRegion Create(Grid grid, int lineNo)
        {
            var instance = _container.Resolve<IGridLineRegionSetup>();
            instance.Setup(grid, lineNo);
            return instance;
        }
    }
}