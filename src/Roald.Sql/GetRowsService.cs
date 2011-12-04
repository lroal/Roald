using System.Collections.Generic;

namespace Roald.Sql
{
    public class GetRowsService<TTableMap, TRowJacket>
        where TTableMap : TableMap 
        where TRowJacket : RowJacket
    {
        private readonly QueryFactory<TTableMap> _queryFactory;
        private readonly Factory<TRowJacket> _factory;

        public GetRowsService()
        {
        }

        public GetRowsService(QueryFactory<TTableMap> queryFactory, Factory<TRowJacket> factory)
        {
            _queryFactory = queryFactory;
            _factory = factory;
        }
        
        public virtual IEnumerable<TRowJacket> Get(TableSpan tableSpan, IEnumerable<Filter> filters)
        {
            Query query = _queryFactory.Create(tableSpan, filters);
            IEnumerable<Row> rows = query.Execute();
            var jackets = new List<TRowJacket>();
            foreach (Row row in rows)
            {
                var jacket = _factory.Create();
                jacket.Setup(row);
                jackets.Add(jacket);
            }
            return jackets;
        }
    }
}