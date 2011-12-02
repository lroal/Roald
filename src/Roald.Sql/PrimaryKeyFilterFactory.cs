namespace Roald.Sql
{
    public interface PrimaryKeyFilterFactory<TTableMap>
    {
        PrimaryKeyFilter Create(PrimaryKeyValue primaryKeyValue);
    }
}