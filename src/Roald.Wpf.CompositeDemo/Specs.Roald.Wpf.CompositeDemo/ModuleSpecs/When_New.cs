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
            Container.AssertWasCalled(x => x.RegisterType<ICurrencyGridPresenter, CurrencyGridPresenter>());
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

        [Test]
        public void It_Should_Register_CompositeGrid()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICompositeGridSetup, CompositeGrid>());
        }

        [Test]
        public void It_Should_Register_RowSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRowSetup, Row>());
        }

        [Test]
        public void It_Should_Register_RowCellFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRowCellFactorySetup, RowCellFactory>());
        }

        [Test]
        public void It_Should_Register_RowCellSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICellSetup, Cell>());
        }


        [Test]
        public void It_Should_Register_ColumnFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IColumnFactory, ColumnFactory>());
        }


        [Test]
        public void It_Should_Register_CompositeGridFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICompositeGridFactory, CompositeGridFactory>());
        }

        [Test]
        public void It_Should_Register_RowCellFactoryFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRowCellFactoryFactory, RowCellFactoryFactory>());
        }

        [Test]
        public void It_Should_Register_RegionFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRegionFactory, RegionFactory>());
        }

        [Test]
        public void It_Should_Register_RegionSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRegionSetup, Region>());
        }


        [Test]
        public void It_Should_Register_CellView()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICellView, CellView>());
        }

        [Test]
        public void It_Should_Register_CompositeDataContext()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICompositeDataContext, CompositeDataContext>());
        }       

        [Test]
        public void It_Should_Register_RowFactoryFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRowFactoryFactory, RowFactoryFactory>());
        }

        [Test]
        public void It_Should_Register_RowFactorySetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRowFactorySetup, RowFactory>());
        }

        [Test]
        public void It_Should_Register_ContextRow()
        {
            Container.AssertWasCalled(x => x.RegisterType<IContextRowSetup, ContextRow>());
        }

        [Test]
        public void It_Should_Register_ColumnFactoryFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IColumnFactoryFactory, ColumnFactoryFactory>());
        }

        [Test]
        public void It_Should_Register_ColumnFactorySetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IColumnFactorySetup, ColumnFactory>());
        }

        [Test]
        public void It_Should_Register_ContextRowFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IContextRowFactory, ContextRowFactory>());
        }

        

   }
}