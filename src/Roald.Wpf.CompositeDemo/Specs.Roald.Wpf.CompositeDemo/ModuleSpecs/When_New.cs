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

        [Test]
        public void It_Should_Register_DataGridRegionFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IDataGridRegionFactory, DataGridRegionFactory>());
        }

        [Test]
        public void It_Should_Register_DataGridRegionSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IDataGridRegionSetup, DataGridRegion>());
        }

        [Test]
        public void It_Should_Register_DataGridLineRegionFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IDataGridLineRegionFactory, DataGridLineRegionFactory>());
        }

        [Test]
        public void It_Should_Register_DataGridLineRegionSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IDataGridLineRegionSetup, DataGridLineRegion>());
        }

        [Test]
        public void It_Should_Register_DataCellRegionFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IDataCellRegionFactory, DataCellRegionFactory>());
        }

        [Test]
        public void It_Should_Register_DataCellRegionSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IDataCellRegionSetup, DataCellRegion>());
        }

        

    }
}