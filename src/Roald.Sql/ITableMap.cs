using System;
using System.Collections.Generic;

namespace Roald.Sql
{
    public interface ITableMap
    {        
        IPrimaryKeyMap PrimaryKey { get; }
        IEnumerable<IColumnMap> Columns { get; }
        IEnumerable<string> ColumnDiscriminators { get; }
        string FormulaDiscriminator { get; }
    }
}