namespace Roald.Sql
{
    public interface ITableSpanLeg 
    {
        IReference Reference { get; }
        ITableSpan Span { get; }
    }
}