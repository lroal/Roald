using System.Collections.Generic;

namespace Roald.Sql
{
    class TableSpan : ITableSpan
    {
        private readonly ITableSpanLegFactory _tableSpanLegFactory;
        private readonly List<ITableSpanLeg> _legs = new List<ITableSpanLeg>();

        public TableSpan(ITableSpanLegFactory tableSpanLegFactory)
        {
            _tableSpanLegFactory = tableSpanLegFactory;
        }       
        
        public ITableSpan Include<TReference>() where TReference : IReference
        {
            var leg = _tableSpanLegFactory.Create<TReference>();
            _legs.Add(leg);
            return leg.Span;
        }

        public IEnumerable<ITableSpanLeg> Legs  
        {
            get { return _legs; }
        }
    }
}