using Rhino.Mocks;
using Roald.Sql.ByOrder.BySelectSql;

namespace Roald.Sql._Specs._SelectSql
{
    internal abstract class New_Act : Base_Act
    {
        protected SelectSql<TableMap> SelectSql { get; set; }
        protected TopColumnSql<TableMap> ColumnSql = MockRepository.GenerateStub<TopColumnSql<TableMap>>();
        protected TopWhereSqlFactory<TableMap> WhereSqlFactory = MockRepository.GenerateStub<TopWhereSqlFactory<TableMap>>();
        protected TopJoinSql JoinSql = MockRepository.GenerateStub<TopJoinSql>();
        protected StatementFactory<TableMap> StatementFactory = MockRepository.GenerateStub<StatementFactory<TableMap>>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            SelectSql = new SelectSql<TableMap>(ColumnSql,WhereSqlFactory,JoinSql,StatementFactory);
        }


    }

    
}