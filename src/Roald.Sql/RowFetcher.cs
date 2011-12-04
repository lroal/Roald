using System.Collections.Generic;

namespace Roald.Sql
{
    public class RowFetcher<TTableMap> where TTableMap : TableMap
    {
        private readonly SelectSqlExecuter _sqlExecuter;
        private readonly SqlLineToRowService<TTableMap> _sqlLineToRowService;
        private List<Row> _rows;
        private SqlResult _result;
        private TableSpan _tableSpan;
        private SelectSql _sql;

        public RowFetcher()
        {
        }

        public RowFetcher(SelectSqlExecuter sqlExecuter, SqlLineToRowService<TTableMap> sqlLineToRowService)
        {
            _sqlExecuter = sqlExecuter;
            _sqlLineToRowService = sqlLineToRowService;
        }

        public virtual IEnumerable<Row> Fetch(TableSpan tableSpan, SelectSql sql)
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
            _rows = new List<Row>();
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