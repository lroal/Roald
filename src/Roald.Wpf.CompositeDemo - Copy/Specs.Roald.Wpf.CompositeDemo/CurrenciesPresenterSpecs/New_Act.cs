using System;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrenciesPresenterSpecs
{
    internal abstract class New_Act
    {
        protected CurrenciesPresenter Presenter { get; set; }
        protected ICurrenciesView View = MockRepository.GenerateStub<ICurrenciesView>();
        protected IGetCurrenciesService GetCurrenciesService = MockRepository.GenerateStub<IGetCurrenciesService>();
        protected ICurrencyPresenterFactory CurrencyPresenterFactory = MockRepository.GenerateStub<ICurrencyPresenterFactory>();

        protected virtual void Arrange()
        {
        }

        protected virtual void Act()
        {
            Presenter = new CurrenciesPresenter(View,GetCurrenciesService,CurrencyPresenterFactory);
        }
    }

    internal interface ICurrenciesPresenter
    {
    }
}