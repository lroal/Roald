namespace Roald.Sql
{
    internal interface IPrimaryKeyFilterFactory<TTableMap>
    {
        IPrimaryKeyFilter Create(IPrimaryKeyValue primaryKeyValue);
    }
}