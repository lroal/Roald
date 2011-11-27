using System;
using System.Collections.Generic;

namespace Roald.Sql.ByOrder
{
    class OrderMap : IOrderMap
    {
        
        public Guid TableId
        {
            get { throw new NotImplementedException(); }
        }

        public IPrimaryKeyMap PrimaryKey
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<IColumnMap> Columns
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<string> ColumnDiscriminators
        {
            get { throw new NotImplementedException(); }
        }

        public string FormulaDiscriminator
        {
            get { throw new NotImplementedException(); }
        }
    }
}