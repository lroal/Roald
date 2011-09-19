using System;
using System.Collections.Generic;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrenciesPresenterSpecs.New.Activated
{
    internal abstract class CurrenciesReceived_Act : Activate_Act
    {
        protected ICurrencyPresenter CurrencyPresenter1 = MockRepository.GenerateStub<ICurrencyPresenter>();
        protected ICurrencyPresenter CurrencyPresenter2 = MockRepository.GenerateStub<ICurrencyPresenter>();
        protected ICompositeGrid Grid = MockRepository.GenerateStub<ICompositeGrid>();
        protected List<ICurrency> Currencies = new List<ICurrency>();
        protected ICurrency Currency1 = MockRepository.GenerateStub<ICurrency>();
        protected ICurrency Currency2 = MockRepository.GenerateStub<ICurrency>();
        protected IRow Row1 = MockRepository.GenerateStub<IRow>();
        protected IRow Row2 = MockRepository.GenerateStub<IRow>();


        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubView();
            StubGridRegion();
            StubCurrencies();
            StubCurrencyPresenterFactory();
        }

        private void StubView()
        {
            View.Stub(x => x.Grid).Return(Grid);
        }

        private void StubGridRegion()
        {
            Grid.Stub(x => x.CreateRow()).Return(Row2).Repeat.Once();
            Grid.Stub(x => x.CreateRow()).Return(Row1).Repeat.Once();
        }

        private void StubCurrencies()
        {
            Currencies.Add(Currency1);
            Currencies.Add(Currency2);
        }

        private void StubCurrencyPresenterFactory()
        {
            CurrencyPresenterFactory.Stub(x => x.Create(Currency1)).Return(CurrencyPresenter1);
            CurrencyPresenterFactory.Stub(x => x.Create(Currency2)).Return(CurrencyPresenter2);
        }


        protected override void Act()
        {
            SuccessHandler.Invoke(Currencies);
        }

        
    }
}