namespace Roald.Sql
{
    public interface IRow
    {
        TRowJacket GetRelated<TRowJacket, TReference>()
            where TRowJacket : IRowJacket
            where TReference : IReference;

        void CreateFromDb(ISqlLine line);
    }
}