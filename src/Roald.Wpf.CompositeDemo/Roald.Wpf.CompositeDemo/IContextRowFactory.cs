using System;

namespace Roald.CompositeDemo
{
    internal interface IContextRowFactory
    {
        IContextRow Create();
    }
}