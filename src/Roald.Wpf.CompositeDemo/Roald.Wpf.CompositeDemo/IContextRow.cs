using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Roald.CompositeDemo
{
    internal interface IContextRow
    {
        UIElement this[int index] { get; }
        string Jalla { get; }
        void AddCell(ICellView element);
    }
}