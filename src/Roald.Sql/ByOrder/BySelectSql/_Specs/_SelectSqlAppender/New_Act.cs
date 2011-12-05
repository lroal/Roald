namespace Roald.Sql.ByOrder.BySelectSql._Specs._SelectSqlAppender
{
    internal abstract class New_Act : Base_Act
    {
        protected SelectSqlAppender Appender { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Appender = new SelectSqlAppender();
        }

    }

}