using Roald.Sql.ByOrder;

namespace Roald.Sql
{
    public interface IGetRowByPrimaryService<TTableMap, out TRow>
        where TTableMap : ITableMap
        where TRow : IRowJacket
    {
        TRow Get(ITableSpan tableSpan,IPrimaryKeyValue primaryKeyValue);
        TRow TryGet(ITableSpan tableSpan, IPrimaryKeyValue primaryKeyValue);

    }
}