namespace Roald.Katas.TennisGameSpecs.Constructed.At15_0.At15_15.At30_15.At40_15.At40_30.Deuce.AdvantagePlayerOne.Deuce.AdvantagePlayerTwo
{
    internal class PlayerTwoWinBall_Act : AdvantagePlayerTwo_Act
    {

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Game.PlayerTwoWinBall();
        }
    }
}