using System;

namespace Roald.Sql
{
    public interface WhereSql
    {
        void Add(WhereSql other);
       
    }
}