using System;
using System.Collections.Generic;

namespace Roald.Sql.ByOrder
{
    internal class ConsigneeMap : TableMap
    {
        public ConsigneeMap()
        {
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