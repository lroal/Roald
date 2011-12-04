using System;
using System.Collections.Generic;

namespace Roald.Sql
{
    public interface TableMap
    {
        string Name { get; }
        PrimaryKeyMap PrimaryKey { get; }
        IEnumerable<ColumnMap> Columns { get; }
        IEnumerable<string> ColumnDiscriminators { get; }
        string FormulaDiscriminator { get; }
    }
}