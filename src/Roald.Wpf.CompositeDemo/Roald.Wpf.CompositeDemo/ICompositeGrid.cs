namespace Roald.CompositeDemo
{
    public interface ICompositeGrid 
    {
        IRow CreateRow();
        void CreateLeftAlignColumn(string header);
    }
}