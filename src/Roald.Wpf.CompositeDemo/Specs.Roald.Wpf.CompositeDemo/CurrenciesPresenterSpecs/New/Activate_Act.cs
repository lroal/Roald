using System;
using System.Collections;
using System.Collections.Generic;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrenciesPresenterSpecs.New
{
    internal abstract class Activate_Act : New_Act
    {

        protected Action<IEnumerable<ICurrency>> SuccessHandler { get; set; }
        protected Action<Exception> ErrorHandler;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubGetCurrencies();            
        }

        private void StubGetCurrencies()
        {
            GetCurrenciesService.Stub(x => x.GetCurrencies(null, null)).IgnoreArguments().WhenCalled(OnGetCurrencies);
        }

        private void OnGetCurrencies(MethodInvocation obj)
        {
            SuccessHandler = (Action<IEnumerable<ICurrency>>) obj.Arguments[0];
            ErrorHandler = (Action<Exception>) obj.Arguments[1];
        }

        protected override void Act()
        {
            Presenter.Activate();
        }
    }
}