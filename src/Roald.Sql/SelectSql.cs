namespace Roald.Sql
{
    public interface SelectSql
    {
        void AddJoin(JoinSql joinSql);
        void AddColumn(ColumnSql columnSql);
    }
}