using System.Collections.Generic;
using System.Linq;
using Roald.Sql.ByOrder;

namespace Roald.Sql
{
    internal class GetRowByPrimaryService<TTableMap, TRowJacket> : IGetRowByPrimaryService<TTableMap, TRowJacket>
        where TTableMap : ITableMap
        where TRowJacket : IRowJacket
    {
        private readonly IGetRowsService<TTableMap, TRowJacket> _getRowsService;
        private readonly IPrimaryKeyFilterFactory<TTableMap> _primaryKeyFilterFactory;
        private ITableSpan _tableSpan;
        private IPrimaryKeyValue _primaryKeyValue;

        public GetRowByPrimaryService(IGetRowsService<TTableMap, TRowJacket> getRowsService, IPrimaryKeyFilterFactory<TTableMap> primaryKeyFilterFactory)
        {
            _getRowsService = getRowsService;
            _primaryKeyFilterFactory = primaryKeyFilterFactory;
        }

        public TRowJacket Get(ITableSpan tableSpan, IPrimaryKeyValue primaryKeyValue)
        {
            _tableSpan = tableSpan;
            _primaryKeyValue = primaryKeyValue;
            return GetRows().First();
        }

        private IEnumerable<TRowJacket> GetRows()
        {
            var filter = _primaryKeyFilterFactory.Create(_primaryKeyValue);
            return _getRowsService.Get(_tableSpan, new[] {filter});
        }

        public TRowJacket TryGet(ITableSpan tableSpan, IPrimaryKeyValue primaryKeyValue)
        {
            _tableSpan = tableSpan;
            _primaryKeyValue = primaryKeyValue;
            return GetRows().FirstOrDefault();
        }
    }
}