using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class RowCellFactoryFactory : IRowCellFactoryFactory
    {
        private readonly IUnityContainer _container;

        public RowCellFactoryFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IRowCellFactory Create(IContextRow contextRow)
        {
            var instance = _container.Resolve<IRowCellFactorySetup>();
            instance.Setup(contextRow);
            return instance;
        }
    }
}