using NUnit.Framework;

namespace Roald.Katas.TennisGameSpecs
{
    [TestFixture]
    internal class When_Constructed : Construct_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Then_Score_Is_Love_All()
        {
            Assert.AreEqual("love all", Game.Score);
        }

    }
}