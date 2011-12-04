using System;

namespace Roald.Sql.ByOrder.BySelectSql
{
    public class StatementFactory<TTableMap> where TTableMap : TableMap
    {
        private readonly TTableMap _tableMap;
        private readonly TopAlias _alias;

        public StatementFactory()
        {
            
        }
        public StatementFactory(TTableMap tableMap, TopAlias alias)
        {
            _tableMap = tableMap;
            _alias = alias;
        }

        public virtual string Create(ColumnSql columnSql, JoinSql joinSql, WhereSql whereSql)
        {
            throw new NotImplementedException();

        }

    }
}