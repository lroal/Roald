using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    internal class DataGridRegionFactory : IDataGridRegionFactory
    {
        private readonly IUnityContainer _container;

        public DataGridRegionFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IDataGridRegion Create(DataGrid dataGrid)
        {
            var instance = _container.Resolve<IDataGridRegionSetup>();
            instance.Setup(dataGrid);
            return instance;
        }
    }
}