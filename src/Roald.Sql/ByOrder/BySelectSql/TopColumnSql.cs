using System;

namespace Roald.Sql.ByOrder.BySelectSql
{
    public class TopColumnSql<TTableMap> : ColumnSql where TTableMap : TableMap
    {
        public virtual void Add(ColumnSql other)
        {
            throw new NotImplementedException();
        }
    }
}