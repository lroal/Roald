using System;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    internal class CompositeDemoModule
    {
        private readonly IUnityContainer _c;

        public CompositeDemoModule(IUnityContainer container)
        {
            _c = container;
            _c.RegisterType<ICurrenciesPresenter, CurrenciesPresenter>();
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
            _c.RegisterType<IRowCellFactory, RowCellFactory>();
            _c.RegisterType<IRowCellSetup, RowCell>();
            _c.RegisterType<IColumnFactory, ColumnFactory>();
            _c.RegisterType<IColumnSetup, Column>();
            _c.RegisterType<IColumnCellFactory, ColumnCellFactory>();
            _c.RegisterType<IColumnCellSetup, ColumnCell>();
            

        }
    }
}