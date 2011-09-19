using System;
using System.Collections.Generic;

namespace Roald.CompositeDemo
{
    internal interface IGetCurrenciesService
    {
        void GetCurrencies(Action<IEnumerable<ICurrency>>  successHandler,Action<Exception> errorHandler);
    }
}