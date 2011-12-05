using NUnit.Framework;

namespace Roald.Sql.ByOrder.BySelectSql._Specs._SelectSqlAppender.New
{
    [TestFixture]
    internal class When_AppendingNonEmpty : AppendNonEmpty_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Returns_Concatenated_String_With_Space_Between()
        {
            Assert.AreEqual("initialStatement appended", Returned);
        }

    }
}