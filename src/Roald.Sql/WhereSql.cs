using System;

namespace Roald.Sql
{
    public interface WhereSql : SqlElement
    {
        void Add(WhereSql other);
       
    }
}