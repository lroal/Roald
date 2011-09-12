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
            _c.RegisterType<IGridRegionFactory, GridRegionFactory>();
            _c.RegisterType<IGridRegionSetup, GridRegion>();
            _c.RegisterType<IGridLineRegionSetup, GridLineRegion>();
            _c.RegisterType<IGridLineRegionFactory, GridLineRegionFactory>();
            _c.RegisterType<ICellRegionFactory, CellRegionFactory>();
            _c.RegisterType<ICellRegionSetup, CellRegion>();
            _c.RegisterType<ICurrenciesView, CurrenciesWindow>();
            _c.RegisterType<IGetCurrenciesService, GetCurrenciesService>();
            _c.RegisterType<ICurrencyPresenterFactory, CurrencyPresenterFactory>();
            _c.RegisterType<IDataGridRegionFactory, DataGridRegionFactory>();
            _c.RegisterType<IDataGridRegionSetup, DataGridRegion>();
            _c.RegisterType<IDataGridLineRegionSetup, DataGridLineRegion>();
            _c.RegisterType<IDataGridLineRegionFactory, DataGridLineRegionFactory>();
            _c.RegisterType<IDataCellRegionFactory, DataCellRegionFactory>();
            _c.RegisterType<IDataCellRegionSetup, DataCellRegion>();

        }
    }
}