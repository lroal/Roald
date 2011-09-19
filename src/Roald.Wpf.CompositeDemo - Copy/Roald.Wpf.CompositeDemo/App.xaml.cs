using System.Windows;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IUnityContainer _container = new UnityContainer();
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            new CompositeDemoModule(_container);
            var presenter = _container.Resolve<ICurrenciesPresenter>();
            presenter.Activate();
        }

    }
}
