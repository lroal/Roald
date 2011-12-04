using System;
using Rhino.Mocks;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._StatementFactory
{
    internal abstract class New_Act : Base_Act
    {
        protected StatementFactory<TableMap> Factory { get; set; }
        protected TableMap TableMap = MockRepository.GenerateStub<TableMap>();
        protected FakeTopAlias Alias = new FakeTopAlias();
        protected const string TableName = "<TableName>";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            TableMap.Stub(x => x.Name).Return(TableName);
        }


        protected override void Act()
        {
            Factory = new StatementFactory<TableMap>(TableMap,Alias);
        }
    }
}