using System;
using System.Collections.Generic;

namespace Roald.Sql._Specs._SelectSqlFactory
{
    internal class FakeMap : TableMap
    {
        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public PrimaryKeyMap PrimaryKey
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<ColumnMap> Columns
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