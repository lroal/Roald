namespace Roald.Sql.ByOrder
{
    public class GetOrderRowByPrimaryService : IGetOrderRowByPrimaryService
    {
        private readonly GetRowByPrimaryService<OrderMap,OrderRow> _getRowByPrimaryService;

        public GetOrderRowByPrimaryService(GetRowByPrimaryService<OrderMap,OrderRow> getRowByPrimaryService)
        {
            _getRowByPrimaryService = getRowByPrimaryService;
        }

        public virtual OrderRow Get(TableSpan tableSpan,PrimaryKeyValue keyValue)
        {
            return _getRowByPrimaryService.Get(tableSpan,keyValue);
        }

    }
}