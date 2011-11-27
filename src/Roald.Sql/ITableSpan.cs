using System.Collections.Generic;

namespace Roald.Sql
{
    public interface ITableSpan
    {
        ITableSpan Include<TReference>() where TReference : IReference;
        IEnumerable<ITableSpanLeg> Legs { get; }
    }
}