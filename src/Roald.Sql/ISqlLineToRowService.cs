namespace Roald.Sql
{
    internal interface ISqlLineToRowService<TTableMap>
        where TTableMap : ITableMap
    {
        IRow ToRow(ITableSpan tableSpan,ISqlLine line);
    }
}