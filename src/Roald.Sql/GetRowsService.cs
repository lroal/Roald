using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace Roald.Sql
{
    public class GetRowsService<TTableMap, TRowJacket>  where TTableMap : TableMap where TRowJacket : RowJacket
    {
        private readonly QueryFactory<TTableMap> _queryFactory;
        private readonly IUnityContainer _container;

        public GetRowsService()
        {            
        }

        public GetRowsService(QueryFactory<TTableMap> queryFactory,IUnityContainer container)
        {
            _queryFactory = queryFactory;
            _container = container;
        }

        public virtual IEnumerable<TRowJacket> Get(TableSpan tableSpan, IEnumerable<Filter> filters)
        {
            var query = _queryFactory.Create(tableSpan, filters);
            var rows = query.Execute();
            var jackets = new List<TRowJacket>();
            foreach (var row in rows)
            {
                var jacket = _container.Resolve<TRowJacket>();
                jacket.Setup(row);
                jackets.Add(jacket);
            }
            return jackets;
        }
    }
}