using System;

namespace Roald.Sql
{
    public class TableSpanLegHydrater<TTableMap> where TTableMap : TableMap
    {
        private TableSpanLeg _leg;

        public TableSpanLegHydrater()
        {
        }

        public virtual void Setup(TableSpanLeg leg)
        {
            _leg = leg;
        }

        public virtual void Hydrate(SqlLine line)
        {
            throw new NotImplementedException();
        }
    }
}