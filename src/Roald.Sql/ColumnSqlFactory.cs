using System;

namespace Roald.Sql
{
    public class ColumnSqlFactory<TTableMap> where TTableMap : TableMap
    {
       
        public virtual ColumnSql Create(Alias alias)
        {
            throw new NotImplementedException();
        }
    }
}