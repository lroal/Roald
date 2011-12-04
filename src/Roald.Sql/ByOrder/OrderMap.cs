using System;
using System.Collections.Generic;

namespace Roald.Sql.ByOrder
{
    public class OrderMap : TableMap
    {
        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public virtual PrimaryKeyMap PrimaryKey
        {
            get { throw new NotImplementedException(); }
        }

        public virtual IEnumerable<ColumnMap> Columns
        {
            get { throw new NotImplementedException(); }
        }

        public virtual IEnumerable<string> ColumnDiscriminators
        {
            get { throw new NotImplementedException(); }
        }

        public virtual string FormulaDiscriminator
        {
            get { throw new NotImplementedException(); }
        }
    }
}