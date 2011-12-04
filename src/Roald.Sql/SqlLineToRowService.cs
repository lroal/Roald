using System;

namespace Roald.Sql
{
    public class SqlLineToRowService<TTableMap> where TTableMap : TableMap
    {
        private readonly SqlLineToRowServiceFactory _sqlLineToRowServiceFactory;
        private readonly Row _row;
        private readonly TableSpanLegHydraterFactory<TTableMap> _legHydraterFactory;

        public SqlLineToRowService()
        {
        }

        public SqlLineToRowService(SqlLineToRowServiceFactory sqlLineToRowServiceFactory, Row row, RowCache rowCache,
                                   TableSpanLegHydraterFactory<TTableMap> legHydraterFactory)
        {
            _sqlLineToRowServiceFactory = sqlLineToRowServiceFactory;
            _row = row;
            _legHydraterFactory = legHydraterFactory;
        }

        public virtual Row ToRow(TableSpan tableSpan, SqlLine line)
        {
            _row.CreateFromDb(line);
            foreach (TableSpanLeg leg in tableSpan.Legs)
            {
                TableSpanLegHydrater<TTableMap> legHydrater = _legHydraterFactory.Create(leg);
                legHydrater.Hydrate(line);
            }
            return _row;
            throw new NotImplementedException();
        }
    }
}