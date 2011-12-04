using System;

namespace Roald.Sql
{
    public interface SelectSql
    {
        SelectSql AddWhere(WhereSql whereSql);
        SelectSql AddJoin(JoinSql joinSql);
        SelectSql AddColumn(ColumnSql columnSql);
        string Statement { get; }
    }

    public class JoinSql
    {
    }

    public class ColumnSql
    {
    }

    public class WhereSql
    {
    }

    public class SelectSql<TTableMap>  : SelectSql
        where TTableMap : TableMap
    {
        private readonly TTableMap _tableMap;

        public SelectSql()
        {
            
        }
        public SelectSql(TTableMap tableMap)
        {
            _tableMap = tableMap;
        }

        public SelectSql AddWhere(WhereSql whereSql)
        {
            throw new NotImplementedException();
        }

        public SelectSql AddJoin(JoinSql joinSql)
        {
            throw new NotImplementedException();
        }

        public SelectSql AddColumn(ColumnSql columnSql)
        {
            throw new NotImplementedException();
        }

        public string Statement
        {
            get { return string.Format("SELECT {0},"); }
        }
    }
}