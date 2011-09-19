using NUnit.Framework;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrenciesPresenterSpecs.New.Activated
{
    [TestFixture]
    internal class When_CurrenciesReceived: CurrenciesReceived_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Activate_CurrencyPresenter1_In_LineRegion1()
        {
            CurrencyPresenter1.AssertWasCalled(x => x.Activate(Row2));
        }

        [Test]
        public void It_Should_Activate_CurrencyPresenter2_In_LineRegion2()
        {
            CurrencyPresenter2.AssertWasCalled(x => x.Activate(Row1));
        }
    }
}