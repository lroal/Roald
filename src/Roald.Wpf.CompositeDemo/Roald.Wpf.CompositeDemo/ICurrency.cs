namespace Roald.CompositeDemo
{
    internal interface ICurrency
    {
        string Code { get; }
        decimal Value { get; }
        string Description { get; }
    }
}