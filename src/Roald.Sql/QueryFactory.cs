using System.Collections.Generic;

namespace Roald.Sql
{
    public class QueryFactory<TTableMap> where TTableMap : TableMap
    {
        private readonly Factory<Query<TTableMap>> _innerFactory;

        public QueryFactory(Factory<Query<TTableMap>> innerFactory)
        {
            _innerFactory = innerFactory;
        }

        public virtual Query Create(TableSpan tableSpan, IEnumerable<Filter> filters)
        {
            var instance = _innerFactory.Create();
            instance.Setup(tableSpan, filters);
            return instance;
        }
    }
}