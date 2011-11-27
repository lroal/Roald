using System.Collections.Generic;

namespace Roald.Sql
{
    internal interface IQueryGraphFactory<TTableMap>
        where TTableMap : ITableMap
    {
        IQueryGraph Create(ITableSpan tableSpan);
    }
}