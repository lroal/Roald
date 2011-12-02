using System.Collections.Generic;

namespace Roald.Sql
{
    internal interface QueryGraphFactory<TTableMap>
        where TTableMap : TableMap
    {
        //IQueryGraph Create(TableSpan tableSpan);
    }
}