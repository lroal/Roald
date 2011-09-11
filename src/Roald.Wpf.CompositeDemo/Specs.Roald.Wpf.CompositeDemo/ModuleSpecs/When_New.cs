using Microsoft.Practices.Unity;
using NUnit.Framework;
using Rhino.Mocks;
using UnityContainerExtensions = Microsoft.Practices.Unity.UnityContainerExtensions;

namespace Roald.CompositeDemo.ModuleSpecs
{
    [TestFixture]
    internal class When_New : New_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Register_CurrenciesView()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICurrenciesView, CurrenciesWindow>());
        }

        [Test]
        public void It_Should_Register_CurrenciesPresenter()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICurrenciesPresenter, CurrenciesPresenter>());
        }

        [Test]
        public void It_Should_Register_CurrencyPresenter()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICurrencyPresenterSetup, CurrencyPresenter>());
        }

        [Test]
        public void It_Should_Register_GridRegionFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IGridRegionFactory, GridRegionFactory>());
        }

        [Test]
        public void It_Should_Register_GridRegionSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IGridRegionSetup, GridRegion>());
        }

        [Test]
        public void It_Should_Register_GridLineRegionFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IGridLineRegionFactory, GridLineRegionFactory>());
        }

        [Test]
        public void It_Should_Register_GridLineRegionSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IGridLineRegionSetup, GridLineRegion>());
        }

        [Test]
        public void It_Should_Register_CellRegionFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICellRegionFactory, CellRegionFactory>());
        }

        [Test]
        public void It_Should_Register_CellRegionSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICellRegionSetup, CellRegion>());
        }

        [Test]
        public void It_Should_Register_CodeView()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICodeView, CodeView>());
        }

        [Test]
        public void It_Should_Register_ValueView()
        {
            Container.AssertWasCalled(x => x.RegisterType<IValueView, ValueView>());
        }

        [Test]
        public void It_Should_Register_DescriptionView()
        {
            Container.AssertWasCalled(x => x.RegisterType<IDescriptionView, DescriptionView>());
        }

        [Test]
        public void It_Should_Register_GetCurrenciesService()
        {
            Container.AssertWasCalled(x => x.RegisterType<IGetCurrenciesService, GetCurrenciesService>());
        }

        [Test]
        public void It_Should_Register_CurrencyPresenterFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICurrencyPresenterFactory, CurrencyPresenterFactory>());
        }

        

    }
}