using System;
using System.Collections.Generic;

namespace Roald.Sql.ByOrder.BySelectSql
{
    public class TopColumnSql<TTableMap> : ColumnSql where TTableMap : TableMap
    {
        private readonly TTableMap _tableMap;
        private readonly TopAlias _alias;
        private readonly CommaDelimiter _commaDelimiter;
        private List<string> _list;
        private List<ColumnSql> _otherColumnSqls = new List<ColumnSql>();

        internal TopColumnSql()
        {
            
        }
        public TopColumnSql(TTableMap tableMap, TopAlias alias,CommaDelimiter commaDelimiter)
        {
            _tableMap = tableMap;
            _alias = alias;
            _commaDelimiter = commaDelimiter;
        }

        public override string ToString()
        {
            _list = new List<string>();           
            AddColumnMaps();
            AddOtherColumnSqls();
            return _commaDelimiter.Delimit(_list);
        }

        private void AddColumnMaps()
        {
            foreach (var columnMap in _tableMap.Columns)
            {
                _list.Add(string.Format("{0}.{1}", _alias, columnMap.Name));
            }
        }

        private void AddOtherColumnSqls()
        {
            foreach (var otherColumnSql in _otherColumnSqls)
            {
                _list.Add(otherColumnSql.ToString());
            }
        }

        public virtual void Add(ColumnSql other)
        {
            _otherColumnSqls.Add(other);
        }
    }
}