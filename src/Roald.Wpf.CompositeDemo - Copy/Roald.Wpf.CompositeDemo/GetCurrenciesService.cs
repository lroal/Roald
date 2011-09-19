using System;
using System.Collections.Generic;

namespace Roald.CompositeDemo
{
    class GetCurrenciesService : IGetCurrenciesService
    {
        public void GetCurrencies(Action<IEnumerable<ICurrency>> successHandler, Action<Exception> errorHandler)
        {
            var usd = new Currency();
            usd.Code = "USD";
            usd.Value = 7.25m;
            usd.Description = "US Dollars";
            var euro = new Currency();
            euro.Code = "EUR";
            euro.Value = 10m;
            euro.Description = "European Union";
            var list = new List<ICurrency>();
            list.Add(usd);
            list.Add(euro);
            successHandler.Invoke(list);
        }
    }
}