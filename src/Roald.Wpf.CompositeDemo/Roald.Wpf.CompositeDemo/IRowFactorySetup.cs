namespace Roald.CompositeDemo
{
    internal interface IRowFactorySetup : IRowFactory
    {
        void Setup(ICompositeDataContext dataContext);
    }
}