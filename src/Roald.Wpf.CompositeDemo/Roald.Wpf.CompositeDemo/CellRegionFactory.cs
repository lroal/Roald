using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class CellRegionFactory : ICellRegionFactory
    {
        private readonly IUnityContainer _container;

        public CellRegionFactory(IUnityContainer container)
        {
            _container = container;
        }

        public ICellRegion Create(Grid grid, int cellNo)
        {
            var instance = _container.Resolve<ICellRegionSetup>();
            instance.Setup(grid, cellNo);
            return instance;
        }
    }
}