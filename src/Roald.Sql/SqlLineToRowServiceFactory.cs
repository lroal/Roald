namespace Roald.Sql
{
    public interface SqlLineToRowServiceFactory
    {
        SqlLineToRowService<TTableMap> Create<TTableMap>() where TTableMap : TableMap;
    }
}