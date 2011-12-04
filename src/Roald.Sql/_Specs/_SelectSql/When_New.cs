using NUnit.Framework;

namespace Roald.Sql._Specs._SelectSql
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
        public void It_Sets_Statement()
        {
            Assert.AreEqual("SELECT top.Column1,top.Column2 from FakeTable",SelectSql.Statement);
        }

    }
}