namespace Roald.CompositeDemo
{
    internal interface ICurrencyPresenterSetup : ICurrencyPresenter
    {
        void Setup(ICurrency currency);
    }
}