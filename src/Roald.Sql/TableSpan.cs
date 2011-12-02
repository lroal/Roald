using System.Collections.Generic;

namespace Roald.Sql
{
    public class TableSpan 
    {
        private readonly TableSpanLegFactory _tableSpanLegFactory;
        private readonly List<TableSpanLeg> _legs = new List<TableSpanLeg>();

        public TableSpan()
        {
        }

        public TableSpan(TableSpanLegFactory tableSpanLegFactory)
        {
            _tableSpanLegFactory = tableSpanLegFactory;
        }       
        
        public virtual TableSpan Include<TReference>() where TReference : Reference
        {
            var leg = _tableSpanLegFactory.Create<TReference>();
            _legs.Add(leg);
            return leg.Span;
        }

        public virtual IEnumerable<TableSpanLeg> Legs  
        {
            get { return _legs; }
        }
    }
}