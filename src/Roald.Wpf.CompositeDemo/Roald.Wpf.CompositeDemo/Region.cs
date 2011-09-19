using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    class Region : IRegionSetup
    {
        private ContentControl _control;

        public void Add(object view)
        {
            _control.Content = view;
        }

        public void Remove(object view)
        {
            _control.Content = view;
        }

        public void Setup(ContentControl control)
        {
            _control = control;
        }
    }
}