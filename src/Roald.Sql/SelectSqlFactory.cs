using System.Collections.Generic;

namespace Roald.Sql
{
    public class SelectSqlFactory<TTableMap>
        where TTableMap : TableMap
    {
        private readonly Factory<SelectSql<TTableMap>> _innerFactory;

        public SelectSqlFactory(Factory<SelectSql<TTableMap>> innerFactory)
        {
            _innerFactory = innerFactory;
        }

        public virtual  SelectSql Create(TableSpan tableSpan, IEnumerable<Filter> filter)
        {
            var instance = _innerFactory.Create();
            return instance;
        }
    }
}