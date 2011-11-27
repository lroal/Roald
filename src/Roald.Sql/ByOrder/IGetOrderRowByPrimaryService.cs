namespace Roald.Sql.ByOrder
{
    public interface IGetOrderRowByPrimaryService
    {
        IOrderRow Get(Sql.ITableSpan tableSpan,IPrimaryKeyValue keyValue);
    }
}