using System;

namespace Roald.Sql
{
    class SqlLineToRowService<TTableMap> : ISqlLineToRowService<TTableMap> where TTableMap : ITableMap
    {
        private readonly ISqlLineToRowServiceFactory _sqlLineToRowServiceFactory;
        private readonly IRow _row;

        public SqlLineToRowService(ISqlLineToRowServiceFactory sqlLineToRowServiceFactory, IRow row, IRowCache rowCache)
        {
            _sqlLineToRowServiceFactory = sqlLineToRowServiceFactory;
            _row = row;
        }

        public IRow ToRow(ITableSpan tableSpan, ISqlLine line)
        {
            _row.CreateFromDb(line);
            foreach (var leg in tableSpan.Legs)
            {
                //var sqlLineToRow = _sqlLineToRowServiceFactory.Create<()
                //leg.Reference
                    
            }
            //tableSpan.Legs
            throw new NotImplementedException();
        }
    }
}