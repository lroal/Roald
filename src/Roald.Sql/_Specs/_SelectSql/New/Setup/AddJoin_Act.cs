using System;
using Rhino.Mocks;

namespace Roald.Sql._Specs._SelectSql.New.Setup
{
    internal abstract class AddJoin_Act : Setup_Act
    {
        protected JoinSql AddedJoin = MockRepository.GenerateStub<JoinSql>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            SelectSql.AddJoin(AddedJoin);
        }
    }
}