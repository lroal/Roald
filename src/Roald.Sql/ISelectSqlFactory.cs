using System.Collections.Generic;

namespace Roald.Sql
{
    internal interface ISelectSqlFactory<TTableMap>
        where TTableMap : ITableMap
    {
        ISelectSql Create(ITableSpan tableSpan, IEnumerable<IFilter> filter);
    }
}