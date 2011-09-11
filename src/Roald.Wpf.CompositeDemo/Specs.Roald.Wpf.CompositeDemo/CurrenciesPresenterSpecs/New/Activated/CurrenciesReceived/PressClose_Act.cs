namespace Roald.CompositeDemo.CurrenciesPresenterSpecs.New.Activated.CurrenciesReceived
{
    internal abstract class PressClose_Act : CurrenciesReceived_Act
    {

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Presenter.OnClosePressed();
        }
    }
}