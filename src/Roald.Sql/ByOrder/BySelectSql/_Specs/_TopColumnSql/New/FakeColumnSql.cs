using System;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._TopColumnSql.New
{
    internal class FakeColumnSql : ColumnSql
    {
        private string _value;

        public FakeColumnSql(string value)
        {
            _value = value;
        }

        public override string  ToString()
        {
            return _value;
        }
        public void Add(ColumnSql other)
        {
            throw new NotImplementedException();
        }
    }
}