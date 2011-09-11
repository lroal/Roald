using System;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    internal class CurrencyPresenterFactory : ICurrencyPresenterFactory
    {
        private readonly IUnityContainer _container;

        public CurrencyPresenterFactory(IUnityContainer container)
        {
            _container = container;
        }

        public ICurrencyPresenter Create(ICurrency currency)
        {
            var instance = _container.Resolve<ICurrencyPresenterSetup>();
            instance.Setup(currency);
            return instance;
        }
    }
}