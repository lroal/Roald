using System;
using Rhino.Mocks;

namespace Roald.Sql._Specs._SelectSqlFactory
{
    internal abstract class New_Act : Base_Act
    {
        protected Factory<SelectSql<FakeMap>> InnerFactory = MockRepository.GenerateStub<Factory<SelectSql<FakeMap>>>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Factory = new SelectSqlFactory<FakeMap>(InnerFactory);
        }

        protected SelectSqlFactory<FakeMap> Factory { get; set; }
    }
}