using System;
using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class DataCellRegionFactory : IDataCellRegionFactory
    {
        private readonly IUnityContainer _container;

        public DataCellRegionFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IDataCellRegion Create(ContentControl control)
        {
            var instance = _container.Resolve<IDataCellRegionSetup>();
            instance.Setup(control);
            return instance;
        }
    }
}