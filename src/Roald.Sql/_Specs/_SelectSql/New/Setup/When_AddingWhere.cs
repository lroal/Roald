using NUnit.Framework;
using Rhino.Mocks;

namespace Roald.Sql._Specs._SelectSql.New.Setup
{
    [TestFixture]
    internal class When_AddingWhere : AddWhere_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Call_Add_On_WhereSql()
        {
            WhereSql.AssertWasCalled(x => x.Add(AddedWhere));
        }

    }
}