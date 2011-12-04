using System;
using System.Collections.Generic;

namespace Roald.Sql
{
    public class WhereSqlFactory<TTableMap> where TTableMap : TableMap 
    {
        public virtual WhereSql Create(Alias alias, IEnumerable<Filter> filters)
        {
            throw new NotImplementedException();
        }
    }
}