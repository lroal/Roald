using System;

namespace Roald.Sql.ByOrder
{
    public class OrderRow : RowJacket
    {
        private Row _row;

        public OrderRow()
        {
        }

        public void Setup(Row row)
        {
            _row = row;
        }

        public virtual int? OrderNo
        {
            get { throw new NotImplementedException(); }
        }

        public virtual string WayBillNo
        {
            get { throw new NotImplementedException(); }
        }

        public virtual ConsigneeRow Consignee
        {
            get
            {
                return null;
                //return _row.GetRelated<ConsigneeRow,ConsigneeReference>();
            }
        }
    }
}