namespace Roald.Sql
{
    public interface SelectSql
    {
        void AddWhere(WhereSql whereSql);
        void AddJoin(JoinSql joinSql);
        void AddColumn(ColumnSql columnSql);
    }
}