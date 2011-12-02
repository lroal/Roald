using System;

namespace Roald.Sql
{
    public class SqlResult
    {
        public virtual SqlLine GetLine()
        {
            throw new NotImplementedException();
        }

        public virtual bool HasMoreLines()
        {
            throw new NotImplementedException();
        }

    }
}