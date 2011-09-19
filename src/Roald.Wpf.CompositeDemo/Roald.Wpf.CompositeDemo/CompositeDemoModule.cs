using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    internal class CompositeDemoModule
    {
        private readonly IUnityContainer _c;

        public CompositeDemoModule(IUnityContainer container)
        {
            _c = container;
            _c.RegisterType<ICurrencyGridPresenter, CurrencyGridPresenter>();
            _c.RegisterType<ICurrencyPresenterSetup, CurrencyPresenter>();
            _c.RegisterType<IValueView, ValueView>();
            _c.RegisterType<ICodeView, CodeView>();
            _c.RegisterType<IDescriptionView, DescriptionView>();
            _c.RegisterType<ICurrenciesView, CurrenciesWindow>();
            _c.RegisterType<IGetCurrenciesService, GetCurrenciesService>();
            _c.RegisterType<ICurrencyPresenterFactory, CurrencyPresenterFactory>();
            _c.RegisterType<IDataGridRegionFactory, DataGridRegionFactory>();
            _c.RegisterType<IDataGridRegionSetup, DataGridRegion>();
            _c.RegisterType<IDataGridLineRegionSetup, DataGridLineRegion>();
            _c.RegisterType<IDataGridLineRegionFactory, DataGridLineRegionFactory>();
            _c.RegisterType<IDataCellRegionFactory, DataCellRegionFactory>();
            _c.RegisterType<IDataCellRegionSetup, DataCellRegion>();
            _c.RegisterType<IRowFactory, RowFactory>();
            _c.RegisterType<IRowSetup, Row>();
            _c.RegisterType<IRowCellFactoryFactory, RowCellFactoryFactory>();
            _c.RegisterType<IRowCellFactorySetup, RowCellFactory>();
            _c.RegisterType<ICellSetup, Cell>();
            _c.RegisterType<IColumnFactory, ColumnFactory>();
            _c.RegisterType<ICompositeGridSetup, CompositeGrid>();
            _c.RegisterType<ICompositeGridFactory,CompositeGridFactory>();
            _c.RegisterType<ICellView, CellView>();
            _c.RegisterType<IColumnFactoryFactory, ColumnFactoryFactory>();
            _c.RegisterType<IColumnFactorySetup, ColumnFactory>();
            _c.RegisterType<ICompositeDataContext, CompositeDataContext>();
            _c.RegisterType<IRegionFactory, RegionFactory>();
            _c.RegisterType<IRegionSetup, Region>();
            _c.RegisterType<IRowFactoryFactory, RowFactoryFactory>();
            _c.RegisterType<IRowFactorySetup, RowFactory>();
            _c.RegisterType<IContextRowSetup, ContextRow>();
            _c.RegisterType<IContextRowFactory, ContextRowFactory>();
        }
    }
}