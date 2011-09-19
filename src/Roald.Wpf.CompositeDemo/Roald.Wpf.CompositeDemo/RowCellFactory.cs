using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{
    class RowCellFactory : IRowCellFactorySetup
    {
        private readonly IUnityContainer _container;
        private Grid _grid;
        private int _rowNo;
        private int _columnNo;

        public RowCellFactory(IUnityContainer container)
        {
            _container = container;
        }

        public ICell Create()
        {
            var instance = _container.Resolve<ICellSetup>();
            instance.Setup(_grid,_rowNo,_columnNo);
            _columnNo++;
            return instance;
        }

        public void Setup(Grid grid)
        {
            _grid = grid;
            _rowNo = grid.RowDefinitions.Count-1;
        }
    }
}