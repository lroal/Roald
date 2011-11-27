namespace Roald.Sql
{
    internal interface ISpanTree<TTableMap>
        where TTableMap : ITableMap

    {
        TTableSpan Include<TTableSpan, TReference>()
            where TTableSpan : Sql.ITableSpan
            where TReference : IReference;
    }
}