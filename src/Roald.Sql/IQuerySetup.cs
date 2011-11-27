using System.Collections.Generic;

namespace Roald.Sql
{
    internal interface IQuerySetup<TTableMap>
        where TTableMap : ITableMap
    {
        IQuery Setup(ITableSpan tableSpan,IEnumerable<IFilter> filters);
    }
}