using System;
using System.Collections.Generic;

namespace Roald.CompositeDemo
{
    internal class CurrenciesPresenter : ICurrenciesPresenter
    {
        private readonly ICurrenciesView _view;
        private readonly IGetCurrenciesService _getCurrenciesService;
        private readonly ICurrencyPresenterFactory _currencyPresenterFactory;
        private readonly List<ICurrencyPresenter> _subPresenters = new List<ICurrencyPresenter>();

        public CurrenciesPresenter(ICurrenciesView view, IGetCurrenciesService getCurrenciesService, ICurrencyPresenterFactory currencyPresenterFactory)
        {
            _view = view;
            _getCurrenciesService = getCurrenciesService;
            _currencyPresenterFactory = currencyPresenterFactory;
        }

        public void Activate()
        {
            _view.Activate();
            _getCurrenciesService.GetCurrencies(OnCurrenciesReceived, OnError);
        }

        private void OnError(Exception exception)
        {
            _view.ShowError("Error getting currencies", exception.Message);
        }

        private void OnCurrenciesReceived(IEnumerable<ICurrency> currencies)
        {
            foreach (var currency in currencies)
            {
                var presenter = _currencyPresenterFactory.Create(currency);
                presenter.Activate(_view.Region.CreateLine());
                _subPresenters.Add(presenter);
            }
        }

        public void OnClosePressed()
        {
            _view.DeActivate();
            foreach (var presenter in _subPresenters)
            {
                presenter.DeActivate();
            }
        }
    }
}