using System.Collections.Generic;
using Rhino.Mocks;

namespace Roald.Sql._Specs._SelectSql.New
{
    internal abstract class Setup_Act : New_Act
    {
        protected static Filter Filter1 = MockRepository.GenerateStub<Filter>();
        protected IEnumerable<Filter> Filters = new List<Filter> {Filter1};
        protected WhereSql WhereSql = MockRepository.GenerateStub<WhereSql>();
        protected const string Statement = "select ...";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubWhereSqlFactory();
            StubStatementFactory();
        }

        private void StubWhereSqlFactory()
        {
            WhereSqlFactory.Stub(x => x.Create(Filters)).Return(WhereSql);
        }

        private void StubStatementFactory()
        {
            StatementFactory.Stub(x => x.Create(ColumnSql, JoinSql, WhereSql)).Return(Statement);
        }

        protected override void Act()
        {
            SelectSql.Setup(Filters);
        }
    }
}