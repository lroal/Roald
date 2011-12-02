using System;
using System.Collections.Generic;

namespace Roald.Sql
{
    public class QueryFactory<TTableMap> where TTableMap : TableMap
    {
        public virtual Query Create(TableSpan tableSpan, IEnumerable<Filter> filters)
        {
            throw new NotImplementedException();
        }
    }
}