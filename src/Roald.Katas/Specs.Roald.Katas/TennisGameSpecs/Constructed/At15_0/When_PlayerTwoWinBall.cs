using NUnit.Framework;

namespace Roald.Katas.TennisGameSpecs.Constructed.At15_0
{
    [TestFixture]
    internal class When_PlayerTwoWinBall : PlayerTwoWinBall_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Then_Score_Is_Fifteen_All()
        {
            Assert.AreEqual("fifteen all", Game.Score);
        }

    }
}