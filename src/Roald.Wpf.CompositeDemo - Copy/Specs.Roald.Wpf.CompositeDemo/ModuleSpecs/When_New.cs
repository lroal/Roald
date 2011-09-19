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

        [Test]
        public void It_Should_Register_CompositeGrid()
        {
            Container.AssertWasCalled(x => x.RegisterType<ICompositeGrid, CompositeGrid>());
        }

        [Test]
        public void It_Should_Register_Row()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRow, Row>());
        }

        [Test]
        public void It_Should_Register_RowFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRowFactory, RowFactory>());
        }

        [Test]
        public void It_Should_Register_RowSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRowSetup, Row>());
        }

        [Test]
        public void It_Should_Register_RowCellFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRowCellFactory, RowCellFactory>());
        }

        [Test]
        public void It_Should_Register_RowCellSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IRowCellSetup, RowCell>());
        }


        [Test]
        public void It_Should_Register_Column()
        {
            Container.AssertWasCalled(x => x.RegisterType<IColumn, Column>());
        }

        [Test]
        public void It_Should_Register_ColumnFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IColumnFactory, ColumnFactory>());
        }

        [Test]
        public void It_Should_Register_ColumnSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IColumnSetup, Column>());
        }

        [Test]
        public void It_Should_Register_ColumnCellFactory()
        {
            Container.AssertWasCalled(x => x.RegisterType<IColumnCellFactory, ColumnCellFactory>());
        }

        [Test]
        public void It_Should_Register_ColumnCellSetup()
        {
            Container.AssertWasCalled(x => x.RegisterType<IColumnCellSetup, ColumnCell>());
        }




        


    }
}