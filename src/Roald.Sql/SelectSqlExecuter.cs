namespace Roald.Sql
{
    public interface SelectSqlExecuter
    {
        SqlResult Execute(SelectSql sql);
    }
}