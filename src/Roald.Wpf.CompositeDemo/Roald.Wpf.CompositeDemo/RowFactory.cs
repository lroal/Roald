using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class RowFactory :  IRowFactorySetup
    {
        private readonly IUnityContainer _container;       
        private ICompositeDataContext _dataContext;

        public RowFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IRow Create()
        {            
            var instance = _container.Resolve<IRowSetup>();
            var contextRow = _dataContext.CreateContextRow();
            instance.Setup(contextRow);
            return instance;
        }

        public void Setup(ICompositeDataContext dataContext)
        {
            _dataContext = dataContext;            
        }
    }
}