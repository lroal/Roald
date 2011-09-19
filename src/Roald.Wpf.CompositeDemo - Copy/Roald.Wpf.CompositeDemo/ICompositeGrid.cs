namespace Roald.CompositeDemo
{
    public interface ICompositeGrid
    {
        IColumn CreateColumn();
        IRow CreateRow();
    }
}