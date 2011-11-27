using System.Collections.Generic;

namespace Roald.Sql
{
    internal class Query<TTableMap> : IQuery, IQuerySetup<TTableMap>
        where TTableMap : ITableMap
    {
        private readonly ISelectSqlFactory<TTableMap> _sqlFactory;
        private readonly IRowFetcher<TTableMap> _rowFetcher;
        private IEnumerable<IFilter> _filters;
        private ITableSpan _tableSpan;

        public Query( ISelectSqlFactory<TTableMap> sqlFactory, IRowFetcher<TTableMap> rowFetcher)
        {
            _sqlFactory = sqlFactory;
            _rowFetcher = rowFetcher;
        }

        public IQuery Setup(ITableSpan tableSpan, IEnumerable<IFilter> filters)
        {
            _tableSpan = tableSpan;
            _filters = filters;
            return this;
        }

        public IEnumerable<IRow> Execute()
        {
            var sql = _sqlFactory.Create(_tableSpan, _filters);
            return _rowFetcher.Fetch(_tableSpan,sql);
        }
    }
} ;