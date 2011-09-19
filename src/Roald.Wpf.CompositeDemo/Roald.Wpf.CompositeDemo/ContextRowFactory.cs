using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class ContextRowFactory : IContextRowFactory
    {
        private readonly IUnityContainer _container;

        public ContextRowFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IContextRow Create()
        {
            var instance =  _container.Resolve<IContextRowSetup>();
            instance.Setup(3);
            return instance;
        }
    }
}