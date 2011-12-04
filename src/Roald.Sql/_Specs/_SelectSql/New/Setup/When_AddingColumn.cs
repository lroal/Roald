using NUnit.Framework;
using Rhino.Mocks;

namespace Roald.Sql._Specs._SelectSql.New.Setup
{
    [TestFixture]
    internal class When_AddingColumn : AddColumn_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Call_Add_On_ColumnSql()
        {
            ColumnSql.AssertWasCalled(x => x.Add(AddedColumn));
        }

    }
}