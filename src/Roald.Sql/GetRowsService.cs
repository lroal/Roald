using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Roald.Sql.ByOrder;

namespace Roald.Sql
{
    class GetRowsService<TTableMap, TRowJacket> : IGetRowsService<TTableMap, TRowJacket> where TTableMap : ITableMap where TRowJacket : IRowJacket
    {
        private readonly IQueryFactory<TTableMap> _queryFactory;
        private readonly IUnityContainer _container;

        public GetRowsService(IQueryFactory<TTableMap> queryFactory,IUnityContainer container)
        {
            _queryFactory = queryFactory;
            _container = container;
        }

        public IEnumerable<TRowJacket> Get(ITableSpan tableSpan, IEnumerable<IFilter> filters)
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