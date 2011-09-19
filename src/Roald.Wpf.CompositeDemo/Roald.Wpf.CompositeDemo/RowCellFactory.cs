using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class RowCellFactory : IRowCellFactorySetup
    {
        private readonly IUnityContainer _container;
        private int _columnNo;
        private IContextRow _contextRow;

        public RowCellFactory(IUnityContainer container)
        {
            _container = container;
        }

        public ICell Create()
        {
            var instance = _container.Resolve<ICellSetup>();
            instance.Setup(_contextRow);
            _columnNo++;
            return instance;
        }

        public void Setup(IContextRow contextRow)
        {
            _contextRow = contextRow;
        }
    }
}