using NUnit.Framework;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._SelectSqlAppender.New
{
    [TestFixture]
    internal class When_AppendingEmpty : AppendEmpty_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Then_It_Returns_InitialStatement_Unchanged()
        {
            Assert.AreEqual(InitialStatement, Returned);
        }

    }
}