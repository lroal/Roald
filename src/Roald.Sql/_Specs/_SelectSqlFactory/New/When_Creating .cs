using NUnit.Framework;

namespace Roald.Sql._Specs._SelectSqlFactory.New
{
    [TestFixture]
    internal class When_Creating : Create_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Returns_SelectSql()
        {
            Assert.AreSame(SelectSql, Returned);
        }

    }
}