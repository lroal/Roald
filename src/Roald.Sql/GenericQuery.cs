using System.Collections.Generic;

namespace Roald.Sql
{
    public class GenericQuery<TTableMap> : Query
        where TTableMap : TableMap
    {
        private readonly SelectSqlFactory<TTableMap> _sqlFactory;
        private readonly RowFetcher<TTableMap> _rowFetcher;
        private IEnumerable<Filter> _filters;
        private TableSpan _tableSpan;

        public GenericQuery()
        {
        }

        public GenericQuery( SelectSqlFactory<TTableMap> sqlFactory, RowFetcher<TTableMap> rowFetcher)
        {
            _sqlFactory = sqlFactory;
            _rowFetcher = rowFetcher;
        }

        public virtual Query Setup(TableSpan tableSpan, IEnumerable<Filter> filters)
        {
            _tableSpan = tableSpan;
            _filters = filters;
            return this;
        }

        public virtual IEnumerable<Row> Execute()
        {
            var sql = _sqlFactory.Create(_tableSpan, _filters);
            return _rowFetcher.Fetch(_tableSpan,sql);
        }
    }
} 