using System.Collections.ObjectModel;

namespace Roald.CompositeDemo
{
    class CompositeDataContext : ObservableCollection<IContextRow>, ICompositeDataContext
    {
        private readonly IContextRowFactory _contextRowFactory;

        public CompositeDataContext(IContextRowFactory contextRowFactory)
        {
            _contextRowFactory = contextRowFactory;
        }

        public IContextRow CreateContextRow()
        {
            var row =  _contextRowFactory.Create();
            Add(row);            
            return row;
        }

        public void Foo()
        {
            this.RemoveAt(1);
        }

    }
}