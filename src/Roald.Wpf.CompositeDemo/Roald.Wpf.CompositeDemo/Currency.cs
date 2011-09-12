namespace Roald.CompositeDemo
{
    internal class Currency : ICurrency
    {
        public string Code { get; set; }

        public decimal Value { get; set; }

        public string Description { get; set; }
    }
}