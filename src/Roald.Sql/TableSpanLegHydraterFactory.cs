using System;

namespace Roald.Sql
{
    public class TableSpanLegHydraterFactory<TTableMap> where TTableMap : TableMap
    {
        public TableSpanLegHydraterFactory()
        {
        }

        public virtual TableSpanLegHydrater<TTableMap> Create(TableSpanLeg leg)
        {
            throw new NotImplementedException();
        }
    }
}