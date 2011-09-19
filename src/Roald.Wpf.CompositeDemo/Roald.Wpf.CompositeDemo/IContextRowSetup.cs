namespace Roald.CompositeDemo
{
    internal interface IContextRowSetup : IContextRow
    {
        void Setup(int numberOfColumns);
    }
}