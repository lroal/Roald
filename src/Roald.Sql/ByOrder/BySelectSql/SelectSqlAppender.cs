using System;

namespace Roald.Sql.ByOrder.BySelectSql
{
    public class SelectSqlAppender
    {
        public virtual string Append(string statement, SqlElement element)
        {
            var toString = element.ToString();
            if (toString == String.Empty)
                return statement;
            return statement + " " + toString;
        }
    }
}