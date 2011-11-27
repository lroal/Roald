using System;

namespace Roald.Sql
{
    class SqlLineToRowService<TTableMap> : ISqlLineToRowService<TTableMap> where TTableMap : ITableMap
    {
        private readonly ISqlLineToRowServiceFactory _sqlLineToRowServiceFactory;

        public SqlLineToRowService(ISqlLineToRowServiceFactory sqlLineToRowServiceFactory, IRow row, IRowCache rowCache)
        {
            _sqlLineToRowServiceFactory = sqlLineToRowServiceFactory;
        }

        public IRow ToRow(ITableSpan tableSpan, ISqlLine line)
        {
            tableSpan.
            throw new NotImplementedException();
        }
    }

    internal interface ISqlLineToRowServiceFactory
    {
        ISqlLineToRowService<TTableMap> Create<TTableMap>() where TTableMap : ITableMap;
    }
}