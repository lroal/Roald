using System.Collections.Generic;

namespace Roald.Sql
{
    public interface SelectSqlFactory<TTableMap>
        where TTableMap : TableMap
    {
        SelectSql Create(TableSpan tableSpan, IEnumerable<Filter> filter);
    }
}