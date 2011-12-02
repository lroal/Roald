using System.Collections.Generic;
using System.Linq;

namespace Roald.Sql
{
    public class GetRowByPrimaryService<TTableMap, TRowJacket> 
        where TTableMap : TableMap
        where TRowJacket : RowJacket
    {
        private readonly GetRowsService<TTableMap, TRowJacket> _getRowsService;
        private readonly PrimaryKeyFilterFactory<TTableMap> _primaryKeyFilterFactory;
        private TableSpan _tableSpan;
        private PrimaryKeyValue _primaryKeyValue;

        public GetRowByPrimaryService()
        {
            
        }
        public GetRowByPrimaryService(GetRowsService<TTableMap, TRowJacket> getRowsService, PrimaryKeyFilterFactory<TTableMap> primaryKeyFilterFactory)
        {
            _getRowsService = getRowsService;
            _primaryKeyFilterFactory = primaryKeyFilterFactory;
        }

        public virtual TRowJacket Get(TableSpan tableSpan, PrimaryKeyValue primaryKeyValue)
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

        public virtual TRowJacket TryGet(TableSpan tableSpan, PrimaryKeyValue primaryKeyValue)
        {
            _tableSpan = tableSpan;
            _primaryKeyValue = primaryKeyValue;
            return GetRows().FirstOrDefault();
        }
    }
}