using Microsoft.Practices.Unity;
using Rhino.Mocks;

namespace Roald.CompositeDemo.ModuleSpecs
{
    internal abstract class New_Act
    {
        protected IUnityContainer Container = MockRepository.GenerateStub<IUnityContainer>();

        protected virtual void Arrange()
        {
        }

        protected virtual void Act()
        {
            new CompositeDemoModule(Container);

        }
    }
}
