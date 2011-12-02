using System;

namespace Roald.Sql
{
    public class SqlLineToRowService<TTableMap>  where TTableMap : TableMap
    {
        private readonly SqlLineToRowServiceFactory _sqlLineToRowServiceFactory;
        private readonly Row _row;

        public SqlLineToRowService()
        {
        }

        public SqlLineToRowService(SqlLineToRowServiceFactory sqlLineToRowServiceFactory, Row row, RowCache rowCache)
        {
            _sqlLineToRowServiceFactory = sqlLineToRowServiceFactory;
            _row = row;
        }

        public virtual Row ToRow(TableSpan tableSpan, SqlLine line)
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