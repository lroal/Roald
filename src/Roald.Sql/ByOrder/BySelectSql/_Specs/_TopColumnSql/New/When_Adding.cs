using NUnit.Framework;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._TopColumnSql.New
{
    [TestFixture]
    internal class When_Adding : Add_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Then_ToString_Should_Return_ExpectedString()
        {
            Assert.AreEqual(ExpectedStringAfterAdd, TopColumnSql.ToString());
        }

    }
}