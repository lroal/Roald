using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class RowFactory :  IRowFactory
    {
        private readonly IUnityContainer _container;

        public RowFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IRow Create(Grid grid)
        {
            var instance = _container.Resolve<IRowSetup>();
            instance.Setup(grid);
            return instance;
        }
    }
}