namespace Roald.Sql
{
    public interface JoinSql : SqlElement
    {
         void Add(JoinSql other);
    }
}