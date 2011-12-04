using Rhino.Mocks;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._StatementFactory.New
{
    internal abstract class Create_Act : New_Act
    {
        protected WhereSql WhereSql = MockRepository.GenerateStub<WhereSql>();
        protected JoinSql JoinSql = MockRepository.GenerateStub<JoinSql>();
        protected FakeColumnSql ColumnSql = new FakeColumnSql();
        protected string Returned { get; set; }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }


        protected override void Act()
        {
            Returned = Factory.Create(ColumnSql, JoinSql, WhereSql);
        }

    }
}