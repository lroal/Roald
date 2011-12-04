using NUnit.Framework;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._StatementFactory.New
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
        public void Then_It_Returns_Expected_Statement()
        {
            Assert.AreEqual("SELECT <columns> FROM <TableName> AS <alias>", Returned);
        }

    }
}