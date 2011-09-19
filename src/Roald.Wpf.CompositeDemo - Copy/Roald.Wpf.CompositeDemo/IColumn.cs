using System;

namespace Roald.CompositeDemo
{
    public interface IColumn
    {
        ICell CreateCell();
    }
}