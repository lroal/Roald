using NUnit.Framework;

namespace Roald.Sql._Specs._SelectSql.New
{
    [TestFixture]
    internal class When_Setup : Setup_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        
        [Test]
        public void Then_ToString_Should_Return_Statement()
        {
            Assert.AreEqual(Statement, SelectSql.ToString());
        }

    }
}