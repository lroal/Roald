using NUnit.Framework;

namespace Roald.Katas.TennisGameSpecs.Constructed.At15_0.At15_15.At30_15.At40_15.At40_30.Deuce.AdvantagePlayerOne.Deuce.AdvantagePlayerTwo
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
        public void Then_PlayerTwo_Wins_Game()
        {
            Assert.AreEqual("player two wins", Game.Score);
        }

    }
}