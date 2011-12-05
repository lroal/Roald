using System;
using System.Collections.Generic;
using Rhino.Mocks;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._TopColumnSql
{
    internal abstract class New_Act : Base_Act
    {
        protected TopColumnSql<TableMap> TopColumnSql { get; set; }
        protected TopAlias Alias = new FakeAlias("_top");
        protected TableMap TableMap = MockRepository.GenerateStub<TableMap>();
        protected List<ColumnMap> ColumnMaps = new List<ColumnMap>();
        protected ColumnMap ColumnMap1 = MockRepository.GenerateStub<ColumnMap>();
        protected ColumnMap ColumnMap2 = MockRepository.GenerateStub<ColumnMap>();
        protected const string ColumnName1 = "Column1";
        protected const string ColumnName2 = "Column2";
        protected CommaDelimiter CommaDelimiter = MockRepository.GenerateStub<CommaDelimiter>();
        protected string ExpectedString = "_top.Column1,_top.Column2";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubColumnMap1();
            StubColumnMap2();
            StubColumnMaps();
            StubTableMap();
            StubCommaDelimiter();
        }

        private void StubColumnMap2()
        {
            ColumnMap2.Stub(x => x.Name).Return(ColumnName2);
        }

        private void StubColumnMap1()
        {
            ColumnMap1.Stub(x => x.Name).Return(ColumnName1);
        }

        private void StubCommaDelimiter()
        {
            CommaDelimiter.Stub(x => x.Delimit(new[] {"_top.Column1", "_top.Column2"})).Return(ExpectedString);
        }


        private void StubColumnMaps()
        {
            ColumnMaps.Add(ColumnMap1);
            ColumnMaps.Add(ColumnMap2);
        }

        private void StubTableMap()
        {
            TableMap.Stub(x => x.Columns).Return(ColumnMaps);
        }


        protected override void Act()
        {
            TopColumnSql = new TopColumnSql<TableMap>(TableMap, Alias, CommaDelimiter);
        }

    }
}