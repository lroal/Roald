namespace Roald.CompositeDemo
{
    class Cell : ICellSetup
    {
        private readonly ICellView _cellView;

        public Cell(ICellView cellView)
        {
            _cellView = cellView;
        }

        public void Setup(IContextRow contextRow)
        {
            contextRow.AddCell(_cellView);
        }

        public void Add(object view)
        {
            _cellView.Add(view);
        }

        public void Remove(object view)
        {
            _cellView.Clear();
        }
    }
}