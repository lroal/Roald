using System;
using Rhino.Mocks;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._StatementFactory.New
{
    internal abstract class Create_Act : New_Act
    {
        protected WhereSql WhereSql = MockRepository.GenerateStub<WhereSql>();
        protected JoinSql JoinSql = MockRepository.GenerateStub<JoinSql>();
        protected FakeColumnSql ColumnSql = new FakeColumnSql();
        protected string Returned { get; set; }
        protected string AppendResult1 = "joinAdderResult";
        protected string ExpectedStatement = "SELECT ...";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubAppender();
        }

        private void StubAppender()
        {
            Appender.Stub(x => x.Append("SELECT <columns> FROM <TableName> AS <alias>",JoinSql)).Return(AppendResult1);
            Appender.Stub(x => x.Append(AppendResult1, WhereSql)).Return(ExpectedStatement);
        }

        


        protected override void Act()
        {
            Returned = Factory.Create(ColumnSql, JoinSql, WhereSql);
        }

    }
}