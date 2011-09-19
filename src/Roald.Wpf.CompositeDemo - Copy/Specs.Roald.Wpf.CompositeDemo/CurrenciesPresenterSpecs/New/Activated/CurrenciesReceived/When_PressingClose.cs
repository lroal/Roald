using NUnit.Framework;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrenciesPresenterSpecs.New.Activated.CurrenciesReceived
{
    [TestFixture]
    internal class When_PressingClose : PressClose_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Deactivate_View()
        {
            View.AssertWasCalled(x => x.DeActivate());
        }

        [Test]
        public void It_Should_Deactivate_CurrencyPresenter1()
        {
            CurrencyPresenter1.AssertWasCalled(x => x.DeActivate());
        }

        [Test]
        public void It_Should_Deactivate_CurrencyPresenter2()
        {
            CurrencyPresenter2.AssertWasCalled(x => x.DeActivate());
        }

    }
}