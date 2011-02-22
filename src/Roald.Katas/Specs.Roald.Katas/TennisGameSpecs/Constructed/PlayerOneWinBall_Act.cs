namespace Roald.Katas.TennisGameSpecs.Constructed
{
    internal class PlayerOneWinBall_Act : Construct_Act
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