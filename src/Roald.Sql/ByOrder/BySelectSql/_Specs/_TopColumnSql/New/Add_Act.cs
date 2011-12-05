using Rhino.Mocks;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._TopColumnSql.New
{
    internal abstract class Add_Act : New_Act
    {
        protected ColumnSql AddedColumnSql = new FakeColumnSql("_2.ColumnX,_2.ColumnY");
        protected const string ExpectedStringAfterAdd = "ExpectedStringAfterAdd";
        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCommaDelimiter();
        }

        private void StubCommaDelimiter()
        {
            CommaDelimiter.Stub(x => x.Delimit(new[] {"_top.Column1", "_top.Column2", "_2.ColumnX,_2.ColumnY"})).Return(
                ExpectedStringAfterAdd);
        }

        protected override void Act()
        {
            TopColumnSql.Add(AddedColumnSql);
        }

    }
}