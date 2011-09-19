using System;
using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrenciesPresenterSpecs.New
{
    [TestFixture]
    internal class When_Activating : Activate_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Activate_The_View()
        {
            View.AssertWasCalled(x => x.Activate());
        }

        [Test]
        public void It_Should_GetCurrencies_Async()
        {
            GetCurrenciesService.AssertWasCalled(
                x =>
                x.GetCurrencies(Arg<Action<IEnumerable<ICurrency>>>.Is.Anything, Arg<Action<Exception>>.Is.Anything));
        }
    }
}