using System;
using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    public interface IRegionFactory
    {
        IRegion Create(ContentControl control);
    }

    class RegionFactory : IRegionFactory
    {
        private readonly IUnityContainer _container;

        public RegionFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IRegion Create(ContentControl control)
        {
            var instance = _container.Resolve<IRegionSetup>();
            instance.Setup(control);
            return instance;
        }
    }
}