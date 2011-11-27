namespace Roald.Sql
{
    internal interface ISelectSqlExecuter
    {
        ISqlResult Execute(ISelectSql sql);
    }
}