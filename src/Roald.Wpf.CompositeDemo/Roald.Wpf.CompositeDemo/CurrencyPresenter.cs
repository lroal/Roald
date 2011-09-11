using System;

namespace Roald.CompositeDemo
{
    internal class CurrencyPresenter : ICurrencyPresenterSetup
    {
        private readonly ICodeView _codeView;
        private readonly IValueView _valueView;
        private readonly IDescriptionView _descriptionView;
        private ICellRegion _descriptionCell;
        private ICellRegion _codeCell;
        private ICellRegion _valueCell;
        private ICurrency _currency;

        public CurrencyPresenter(ICodeView codeView,IValueView valueView, IDescriptionView descriptionView)
        {
            _codeView = codeView;
            _valueView = valueView;
            _descriptionView = descriptionView;
        }

        public void Activate(IGridLineRegion region)
        {
            _codeCell = region.CreateCell();
            _codeCell.Add(_codeView);
            _codeView.SetCode(_currency.Code);

            _valueCell = region.CreateCell();
            _valueCell.Add(_valueView);
            _valueView.SetValue(_currency.Value);
            
            _descriptionCell = region.CreateCell();            
            _descriptionCell.Add(_descriptionView);
            _descriptionView.SetDescription(_currency.Description);
        }

        public void DeActivate()
        {
            _codeCell.Remove(_codeView);
            _valueCell.Remove(_valueView);
            _descriptionCell.Remove(_descriptionView);
        }

        public void Setup(ICurrency currency)
        {
            _currency = currency;
        }
    }
}