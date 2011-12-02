namespace Roald.Sql
{
    public interface TableSpanLeg 
    {
        Reference Reference { get; }
        TableSpan Span { get; }
    }
}