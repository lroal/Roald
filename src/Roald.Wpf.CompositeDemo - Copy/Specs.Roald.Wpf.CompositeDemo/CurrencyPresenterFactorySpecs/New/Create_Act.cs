using System;
using Microsoft.Practices.Unity;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrencyPresenterFactorySpecs.New
{
    internal abstract class Create_Act : New_Act
    {
        protected ICurrencyPresenterSetup ExpectedInstance = MockRepository.GenerateStub<ICurrencyPresenterSetup>();
        protected ICurrency Currency = MockRepository.GenerateStub<ICurrency>();
        protected ICurrencyPresenter ReturnedInstance { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubContainer();

        }

        private void StubContainer()
        {
            Container.Stub(x => x.Resolve(typeof (ICurrencyPresenterSetup))).Return(ExpectedInstance);
        }


        protected override void Act()
        {
            ReturnedInstance = Factory.Create(Currency);
        }
    }
}