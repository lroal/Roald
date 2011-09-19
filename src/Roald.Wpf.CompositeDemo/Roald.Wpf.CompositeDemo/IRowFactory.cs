using System;
using System.Collections.ObjectModel;

namespace Roald.CompositeDemo
{
    public interface IRowFactory
    {
        IRow Create();
    }
}