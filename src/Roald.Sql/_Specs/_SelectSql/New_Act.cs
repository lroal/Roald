using System;
using System.Collections.Generic;
using Rhino.Mocks;
using Roald.Sql._Specs._SelectSqlFactory;

namespace Roald.Sql._Specs._SelectSql
{
    internal abstract class New_Act : Base_Act
    {
        protected SelectSql<TableMap> SelectSql { get; set; }
        protected TableMap TableMap = MockRepository.GenerateStub<TableMap>();

        protected static ColumnMap Column1 = MockRepository.GenerateStub<ColumnMap>();
        protected static ColumnMap Column2 = MockRepository.GenerateStub<ColumnMap>();
        protected List<ColumnMap> Columns = new List<ColumnMap>() {Column1, Column2};
        protected const string TableName = "FakeTable";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubTableMap();
        }

        private void StubTableMap()
        {
            TableMap.Stub(x => x.Columns).Return(Columns);
            TableMap.Stub(x => x.Name).Return(TableName);
        }


        protected override void Act()
        {
            SelectSql = new SelectSql<TableMap>(TableMap);
        }

        
    }
}