using System;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrencyPresenterSpecs
{
    internal abstract class New_Act
    {
        protected IValueView ValueView = MockRepository.GenerateStub<IValueView>();

        protected IDescriptionView DescriptionView = MockRepository.GenerateStub<IDescriptionView>();
        protected ICodeView CodeView = MockRepository.GenerateStub<ICodeView>();

        protected CurrencyPresenter Presenter { get; set; }

        protected virtual void Arrange()
        {
        }

        protected virtual void Act()
        {
            Presenter = new CurrencyPresenter(CodeView,ValueView,DescriptionView);
        }

    }
}