using System;
using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    internal class GridRegionFactory : IGridRegionFactory
    {
        private readonly IUnityContainer _container;

        public GridRegionFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IGridRegion Create(Grid grid)
        {
            var instance = _container.Resolve<IGridRegionSetup>();
            instance.Setup(grid);
            return instance;
        }
    }
}