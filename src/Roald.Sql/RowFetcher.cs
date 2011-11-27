using System.Collections.Generic;

namespace Roald.Sql
{
    class RowFetcher<TTableMap> : IRowFetcher<TTableMap> where TTableMap : ITableMap
    {
        private readonly ISelectSqlExecuter _sqlExecuter;
        private readonly ISqlLineToRowService<TTableMap> _sqlLineToRowService;
        private List<IRow> _rows;
        private ISqlResult _result;
        private ITableSpan _tableSpan;
        private ISelectSql _sql;

        public RowFetcher(ISelectSqlExecuter sqlExecuter, ISqlLineToRowService<TTableMap> sqlLineToRowService)
        {
            _sqlExecuter = sqlExecuter;
            _sqlLineToRowService = sqlLineToRowService;
        }

        public IEnumerable<IRow> Fetch(ITableSpan tableSpan, ISelectSql sql)
        {
            _tableSpan = tableSpan;
            _sql = sql;
            Reset();
            ExecuteSql();
            ResultToRows();
            return _rows;
        }

        private void Reset()
        {
            _rows = new List<IRow>();
        }

        private void ExecuteSql()
        {
            _result = _sqlExecuter.Execute(_sql);
        }

        private void ResultToRows()
        {
            while (_result.HasMoreLines())
            {
                var line = _result.GetLine();
                var row = _sqlLineToRowService.ToRow(_tableSpan,line);
                _rows.Add(row);
            }
        }
    }
}