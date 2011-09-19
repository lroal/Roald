namespace Roald.CompositeDemo
{
    public interface IRegion
    {
        void Add(object view);
        void Remove(object view);
    }
}