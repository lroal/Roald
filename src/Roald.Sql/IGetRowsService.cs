using System.Collections.Generic;
using Roald.Sql.ByOrder;

namespace Roald.Sql
{
    public interface IGetRowsService<TTableMap, out TRowJacket>
        where TTableMap : ITableMap
        where TRowJacket : IRowJacket
    {
        IEnumerable<TRowJacket> Get(ITableSpan tableSpan, IEnumerable<IFilter> filters);

    }
}