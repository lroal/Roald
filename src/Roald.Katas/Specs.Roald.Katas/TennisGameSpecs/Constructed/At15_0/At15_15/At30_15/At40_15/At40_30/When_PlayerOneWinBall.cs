using NUnit.Framework;

namespace Roald.Katas.TennisGameSpecs.Constructed.At15_0.At15_15.At30_15.At40_15.At40_30
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
        public void Then_PlayerOne_Wins()
        {
            Assert.AreEqual("player one wins", Game.Score);
        }

    }
}