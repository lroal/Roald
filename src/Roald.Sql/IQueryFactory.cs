using System.Collections.Generic;

namespace Roald.Sql
{
    internal interface IQueryFactory<TTableMap>
        where TTableMap : ITableMap
    {
        IQuery Create(ITableSpan tableSpan, IEnumerable<IFilter> filters);
    }
}