namespace Roald.CompositeDemo
{
    class Row : IRowSetup
    {
        private readonly IRowCellFactoryFactory _cellFactoryFactory;
        private IRowCellFactory _cellFactory;   

        public Row(IRowCellFactoryFactory cellFactoryFactory)
        {
            _cellFactoryFactory = cellFactoryFactory;
        }

        public ICell CreateCell()
        {
            return _cellFactory.Create();
        }

        public void Setup(IContextRow contextRow)
        {
            _cellFactory = _cellFactoryFactory.Create(contextRow);
        }
    }
}