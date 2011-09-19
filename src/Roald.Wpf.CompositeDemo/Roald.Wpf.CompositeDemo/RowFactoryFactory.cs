using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class RowFactoryFactory : IRowFactoryFactory
    {
        private readonly IUnityContainer _container;

        public RowFactoryFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IRowFactory Create(DataGrid dataGrid,ICompositeDataContext context)
        {
            var instance = _container.Resolve<IRowFactorySetup>();
            instance.Setup(context);            
            dataGrid.ItemsSource = context;
            return instance;
        }
    }
}