using NUnit.Framework;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._TopColumnSql
{
    [TestFixture]
    internal class When_New : New_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Then_ToString_Should_Expected_String()
        {
            Assert.AreEqual(ExpectedString,TopColumnSql.ToString());
        }

    }
}