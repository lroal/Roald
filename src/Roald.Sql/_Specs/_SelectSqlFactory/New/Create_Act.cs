using System;
using System.Collections.Generic;
using Rhino.Mocks;

namespace Roald.Sql._Specs._SelectSqlFactory.New
{
    internal abstract class Create_Act : New_Act
    {
        protected IEnumerable<Filter> Filters = new List<Filter>();
        protected TableSpan TableSpan = MockRepository.GenerateStub<TableSpan>();
        protected SelectSql Returned;
        protected SelectSql<FakeMap> SelectSql = MockRepository.GenerateStub<SelectSql<FakeMap>>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubInnerFactory();
        }

        private void StubInnerFactory()
        {
            InnerFactory.Stub(x => x.Create()).Return(SelectSql);
        }


        protected override void Act()
        {
            Returned = Factory.Create(TableSpan, Filters);
        }

    }

}