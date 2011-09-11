namespace Roald.CompositeDemo.CurrencyPresenterSpecs.New.Setup.Activated
{
    internal abstract class Deactivate_Act : Activate_Act
    {

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Presenter.DeActivate();
        }
    }
}