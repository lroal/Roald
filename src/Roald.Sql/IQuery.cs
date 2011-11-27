using System.Collections.Generic;
using Roald.Sql.ByOrder;

namespace Roald.Sql
{
    internal interface IQuery
    {
        IEnumerable<IRow> Execute();
    }
}