namespace Roald.Sql
{
    internal interface ITableSpanLegFactory
    {
        ITableSpanLeg Create<TReference>() where TReference : IReference;
    }
}