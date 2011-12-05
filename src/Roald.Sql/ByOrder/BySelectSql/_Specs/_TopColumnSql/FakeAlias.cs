namespace Roald.Sql.ByOrder.BySelectSql._Specs._TopColumnSql
{
    internal class FakeAlias : TopAlias
    {
        private string _value;

        public FakeAlias(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }
    }
}