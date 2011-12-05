namespace Roald.Sql.ByOrder.BySelectSql._Specs._SelectSqlAppender.New
{
    internal abstract class AppendEmpty_Act : New_Act
    {
        protected string Returned { get; set; }
        protected const string InitialStatement = "initialStatement";
        protected EmptySqlElementFake EmptySqlElement = new EmptySqlElementFake();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Returned = Appender.Append(InitialStatement, EmptySqlElement);
        }
    }
}