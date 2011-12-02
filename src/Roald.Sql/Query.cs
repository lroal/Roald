using System.Collections.Generic;

namespace Roald.Sql
{
    public interface Query
    {
        IEnumerable<Row> Execute();
    }
}