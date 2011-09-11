namespace Roald.CompositeDemo
{
    internal interface ICurrencyPresenterFactory
    {
        ICurrencyPresenter Create(ICurrency currency);
    }
}