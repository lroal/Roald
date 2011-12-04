using System;
using Rhino.Mocks;

namespace Roald.Sql._Specs._SelectSql.New.Setup
{
    internal abstract class AddColumn_Act : Setup_Act
    {
        protected ColumnSql AddedColumn = MockRepository.GenerateStub<ColumnSql>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            SelectSql.AddColumn(AddedColumn);
        }
    }
}