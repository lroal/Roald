using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IRegionSetup : IRegion
    {
        void Setup(ContentControl control);
    }
}