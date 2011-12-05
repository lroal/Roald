namespace Roald.Sql.ByOrder.BySelectSql
{
    public class StatementFactory<TTableMap> where TTableMap : TableMap
    {
        private readonly TTableMap _tableMap;
        private readonly TopAlias _alias;
        private readonly SelectSqlAppender _selectSqlAppender;
        private ColumnSql _columnSql;
        private JoinSql _joinSql;
        private WhereSql _whereSql;
        private string _query;

        public StatementFactory()
        {
            
        }
        public StatementFactory(TTableMap tableMap, TopAlias alias, SelectSqlAppender selectSqlAppender)
        {
            _tableMap = tableMap;
            _alias = alias;
            _selectSqlAppender = selectSqlAppender;
        }

        public virtual string Create(ColumnSql columnSql, JoinSql joinSql, WhereSql whereSql)
        {
            _columnSql = columnSql;
            _joinSql = joinSql;
            _whereSql = whereSql;
            AppendJoin();
            AppendWhere();
            return _query;

        }

        private void AppendJoin()
        {
            _query = _selectSqlAppender.Append(InitialSql,_joinSql);
        }

        private void AppendWhere()
        {
            _query = _selectSqlAppender.Append(_query,_whereSql);
        }

        private string InitialSql
        {
            get
            {
                return string.Format("SELECT {0} FROM {1} AS {2}", _columnSql, _tableMap.Name, _alias);    
            }
            
        }
    }
}