namespace Roald.Sql.ByOrder.BySelectSql._Specs._SelectSqlAppender.New
{
    internal class NonEmptySqlElementFake : SqlElement
    {
        private string _value;

        public NonEmptySqlElementFake(string value)
        {
            _value = value;
        }
        

        public override string ToString()
        {
            return _value;
        }
    }
}