namespace Roald.CompositeDemo
{
    internal interface IGridRegion
    {
        IGridLineRegion CreateLine();
    }

    internal interface IGridLineRegion
    {
        ICellRegion CreateCell();
    }

    internal interface ICellRegion
    {
        void Add(object view);
        void Remove(object view);
    }
}