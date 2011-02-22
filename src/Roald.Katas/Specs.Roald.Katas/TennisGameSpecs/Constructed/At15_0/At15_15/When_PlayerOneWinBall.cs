using NUnit.Framework;

namespace Roald.Katas.TennisGameSpecs.Constructed.At15_0.At15_15
{
    [TestFixture]
    internal class When_PlayerOneWinBall : PlayerOneWinBall_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void Then_Score_Is_Thirty_Fifteen()
        {
            Assert.AreEqual("thirty fifteen", Game.Score);
        }

    }
}