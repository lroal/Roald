using System;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrencyPresenterSpecs.New
{
    internal abstract class Setup_Act : New_Act
    {
        protected ICurrency Currency = MockRepository.GenerateStub<ICurrency>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Presenter.Setup(Currency);
        }
    }

}