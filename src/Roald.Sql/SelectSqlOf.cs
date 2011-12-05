using System.Collections.Generic;
using Roald.Sql.ByOrder.BySelectSql;

namespace Roald.Sql
{
    public class SelectSql<TTableMap> : SelectSql
        where TTableMap : TableMap
    {
        private readonly TopWhereSqlFactory<TableMap> _whereSqlFactory;
        private readonly StatementFactory<TTableMap> _statementFactory;
        private WhereSql _whereSql;
        private readonly ColumnSql _columnSql;
        private readonly JoinSql _joinSql;

        public SelectSql()
        {
        }

        public SelectSql(TopColumnSql<TableMap> columnSql, TopWhereSqlFactory<TableMap> whereSqlFactory,
                         TopJoinSql joinSql, StatementFactory<TTableMap> statementFactory)
        {
            _columnSql = columnSql;
            _joinSql = joinSql;
            _whereSqlFactory = whereSqlFactory;
            _statementFactory = statementFactory;
        }

        public void AddJoin(JoinSql joinSql)
        {
            _joinSql.Add(joinSql);
        }

        public void AddColumn(ColumnSql columnSql)
        {
            _columnSql.Add(columnSql);
        }

        public override string ToString()
        {
            return _statementFactory.Create(_columnSql, _joinSql, _whereSql); 
        }

        public virtual void Setup(IEnumerable<Filter> filters)
        {
            _whereSql = _whereSqlFactory.Create(filters);
        }
    }
}