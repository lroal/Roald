using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Roald.CompositeDemo
{

    class ColumnCellFactory : IColumnCellFactorySetup
    {
        private readonly IUnityContainer _container;
        private Grid _grid;
        private int _columnNo;
        private int _rowNo;

        public ColumnCellFactory(IUnityContainer container)
        {
            _container = container;
        }

        public ICell Create()
        {
            var instance = _container.Resolve<ICellSetup>();
            instance.Setup(_grid, _columnNo,_rowNo);
            _rowNo++;
            return instance;
        }

        public void Setup(Grid grid)
        {
            _grid = grid;
            _columnNo = grid.ColumnDefinitions.Count - 1;
        }
    }


}