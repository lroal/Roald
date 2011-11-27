namespace Roald.Sql
{
    internal interface ISqlResult
    {
        ISqlLine GetLine();
        bool HasMoreLines();     

    }
}