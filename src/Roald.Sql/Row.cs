using System;

namespace Roald.Sql
{
    public class Row
    {
        public virtual TRowJacket GetRelated<TRowJacket, TReference>()
            where TRowJacket : RowJacket
            where TReference : Reference
        {
            throw new NotImplementedException();
        }

        public virtual void CreateFromDb(SqlLine line)
        {
            throw new NotImplementedException();
        }
    }
}