namespace Roald.Sql
{
    internal interface ISqlLineToRowServiceFactory
    {
        ISqlLineToRowService<TTableMap> Create<TTableMap>() where TTableMap : ITableMap;
    }
}