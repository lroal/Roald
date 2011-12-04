using System;
using Rhino.Mocks;

namespace Roald.Sql._Specs._SelectSql.New.Setup
{
    internal abstract class AddWhere_Act : Setup_Act
    {
        protected WhereSql AddedWhere = MockRepository.GenerateStub<WhereSql>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            SelectSql.AddWhere(AddedWhere);
        }
    }
}