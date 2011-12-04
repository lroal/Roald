using NUnit.Framework;
using Rhino.Mocks;

namespace Roald.Sql._Specs._SelectSql.New.Setup
{
    [TestFixture]
    internal class When_AddingJoin : AddJoin_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Call_Add_On_JoinSql()
        {
            JoinSql.AssertWasCalled(x => x.Add(AddedJoin));
        }

    }
}