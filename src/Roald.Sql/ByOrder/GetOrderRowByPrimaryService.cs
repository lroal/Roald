namespace Roald.Sql.ByOrder
{
    class GetOrderRowByPrimaryService : IGetOrderRowByPrimaryService
    {
        private readonly IGetRowByPrimaryService<IOrderMap,IOrderRow> _getRowByPrimaryService;

        public GetOrderRowByPrimaryService(IGetRowByPrimaryService<IOrderMap,IOrderRow> getRowByPrimaryService)
        {
            _getRowByPrimaryService = getRowByPrimaryService;
        }

        public IOrderRow Get(Sql.ITableSpan tableSpan,IPrimaryKeyValue keyValue)
        {
            return _getRowByPrimaryService.Get(tableSpan,keyValue);
        }

    }
}