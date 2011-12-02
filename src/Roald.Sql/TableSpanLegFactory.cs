using System;

namespace Roald.Sql
{
    public class TableSpanLegFactory
    {
        public TableSpanLegFactory()
        {
            
        }

        public virtual TableSpanLeg Create<TReference>() where TReference : Reference
        {
            throw new NotImplementedException();
        }

    }
}