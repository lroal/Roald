using System;
using System.Collections.Generic;

namespace Roald.Sql
{
    public interface ITableMap
    {
        Guid TableId { get; }
        IPrimaryKeyMap PrimaryKey { get; }
        IEnumerable<IColumnMap> Columns { get; }
        IEnumerable<string> ColumnDiscriminators { get; }
        string FormulaDiscriminator { get; }
    }
}