namespace Roald.CompositeDemo
{
    internal interface ICurrenciesView
    {
        void Activate();
        void DeActivate();
        ICompositeGrid Grid { get; }
        void ShowError(string title, string errorMsg);
    }
}