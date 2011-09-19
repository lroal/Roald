namespace Roald.CompositeDemo
{
    internal interface IRowSetup : IRow
    {
        void Setup(IContextRow contextRow);
    }
}