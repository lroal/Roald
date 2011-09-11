using System;
using System.Collections.Generic;

namespace Roald.CompositeDemo
{
    internal interface IGetCurrenciesService
    {
        void GetCurrencies(Action<IEnumerable<ICurrency>>  successHandler,Action<Exception> errorHandler);
    }

    internal class Currency : ICurrency
    {
        public string Code { get; set; }

        public decimal Value { get; set; }

        public string Description { get; set; }
    }
}