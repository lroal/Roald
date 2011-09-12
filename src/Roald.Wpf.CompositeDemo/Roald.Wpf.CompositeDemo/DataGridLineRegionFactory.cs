using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class DataGridLineRegionFactory : IDataGridLineRegionFactory
    {
        private readonly IUnityContainer _container;

        public DataGridLineRegionFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IDataGridLineRegion Create(DataGrid dataGrid)
        {
            var instance = _container.Resolve<IDataGridLineRegionSetup>();
            instance.Setup(dataGrid);
            return instance;
        }
    }
}