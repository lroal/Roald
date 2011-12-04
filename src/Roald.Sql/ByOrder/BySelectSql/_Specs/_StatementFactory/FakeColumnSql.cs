using System;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._StatementFactory
{
    internal class FakeColumnSql : ColumnSql
    {
        public override string ToString()
        {
            return "<columns>";
        }

        public void Add(ColumnSql other)
        {
            throw new NotImplementedException();
        }
    }
}