using NUnit.Framework;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrencyPresenterFactorySpecs.New
{
    [TestFixture]
    internal class When_Creating : Create_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Return_expected_Instance()
        {
            Assert.AreSame(ExpectedInstance, ReturnedInstance);
        }

        [Test]
        public void it_should_Setup_Instance()
        {
            ExpectedInstance.AssertWasCalled(x => x.Setup(Currency));
        }

    }
}