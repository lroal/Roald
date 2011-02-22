namespace Roald.Katas.TennisGameSpecs.Constructed.At15_0.At15_15.At30_15.At40_15.At40_30.Deuce.AdvantagePlayerOne
{
    internal class PlayerOneWinBall_Act : AdvantagePlayerOne_Act
    {

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Game.PlayerOneWinBall();
        }
    }
}