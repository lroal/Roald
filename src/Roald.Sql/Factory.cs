using Microsoft.Practices.Unity;

namespace Roald.Sql
{
    public class Factory<T>
    {
        private readonly IUnityContainer _container;

        public Factory()
        {
        }

        public Factory(IUnityContainer container)
        {
            _container = container;
        }

        public virtual T Create()
        {
            //todo
            return _container.Resolve<T>();
        }
    }

}