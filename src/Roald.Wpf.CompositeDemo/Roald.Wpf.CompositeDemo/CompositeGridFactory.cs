using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class CompositeGridFactory : ICompositeGridFactory
    {
        private readonly IUnityContainer _container;

        public CompositeGridFactory(IUnityContainer container)
        {
            _container = container;
        }

        public ICompositeGrid Create(Grid grid)
        {
            var instance = _container.Resolve<ICompositeGridSetup>();
            instance.Setup(grid);
            return instance;
        }
    }
}