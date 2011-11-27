using System.Collections.Generic;

namespace Roald.Sql
{
    internal interface IRowFetcher<TTableMap>
        where TTableMap : ITableMap
    {
        IEnumerable<IRow> Fetch(ITableSpan tableSpan, ISelectSql filters);
    }
}