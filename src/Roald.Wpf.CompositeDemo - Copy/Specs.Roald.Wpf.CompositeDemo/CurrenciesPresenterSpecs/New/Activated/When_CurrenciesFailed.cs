using NUnit.Framework;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrenciesPresenterSpecs.New.Activated
{
    [TestFixture]
    internal class When_CurrenciesFailed : CurrenciesFailed_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_ShowError()
        {
            View.AssertWasCalled(x => x.ShowError("Error getting currencies", ErrorMsg));
            ;
        }

    }
}