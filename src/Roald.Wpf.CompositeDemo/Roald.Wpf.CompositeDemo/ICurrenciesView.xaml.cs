namespace Roald.CompositeDemo
{
    internal interface ICurrenciesView
    {
        void Activate();
        void DeActivate();
        IGridRegion Region { get; }
        void ShowError(string title, string errorMsg);
    }
}