using System;

namespace Roald.Sql
{
    public class SpanTree<TTableMap>
        where TTableMap : TableMap
    {

        public SpanTree()
        {
        }

        public virtual TTableSpan  Include<TTableSpan, TReference>()
            where TTableSpan : TableSpan
            where TReference : Reference
        {
            throw new NotImplementedException();
        }
    }
}