using Microsoft.Practices.Unity;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrencyPresenterFactorySpecs
{
    internal abstract class New_Act
    {
        protected CurrencyPresenterFactory Factory { get; set; }
        protected IUnityContainer Container = MockRepository.GenerateStub<IUnityContainer>();

        protected virtual void Arrange()
        {
        }

        protected virtual void Act()
        {
            Factory = new CurrencyPresenterFactory(Container);
        }

        
    }
}