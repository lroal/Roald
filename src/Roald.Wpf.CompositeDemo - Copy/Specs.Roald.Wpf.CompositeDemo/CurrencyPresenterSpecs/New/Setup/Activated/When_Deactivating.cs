using NUnit.Framework;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrencyPresenterSpecs.New.Setup.Activated
{
    [TestFixture]
    internal class When_Deactivating : Deactivate_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Remove_CodeView_From_Cell1()
        {
            Cell1.AssertWasCalled(x => x.Remove(CodeView));
        }

        [Test]
        public void It_Should_Remove_ValueView_From_Cell2()
        {
            Cell2.AssertWasCalled(x => x.Remove(ValueView));
        }

        [Test]
        public void It_Should_Remove_DescriptionView_From_Cell3()
        {
            Cell3.AssertWasCalled(x => x.Remove(DescriptionView));
        }

    }
}