using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    public interface ICompositeGridSetup : ICompositeGrid
    {
        void Setup(UserControl region);
    }
}