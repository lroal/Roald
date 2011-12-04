using System;
using System.Collections.Generic;

namespace Roald.Sql.ByOrder.BySelectSql
{
    public class TopWhereSqlFactory<TTableMap> where TTableMap : TableMap
    {
        public TopWhereSqlFactory()
        {
            
        }

        public TopWhereSqlFactory(TopAlias alias, WhereSqlFactory<TTableMap> innerFactory)
        {
            
        }

        public virtual WhereSql Create(IEnumerable<Filter> filters)
        {
            throw new NotImplementedException();
        }

    }
}