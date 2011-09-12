namespace Roald.CompositeDemo
{
    internal interface ICurrenciesView
    {
        void Activate();
        void DeActivate();
        IDataGridRegion Region { get; }
        void ShowError(string title, string errorMsg);
    }
}