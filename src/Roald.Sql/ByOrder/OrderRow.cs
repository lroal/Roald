using System;

namespace Roald.Sql.ByOrder
{
    class OrderRow : IOrderRow
    {
        private IRow _row;

        public void Setup(IRow row)
        {
            _row = row;
        }

        public TRow GetRelated<TRow>()
        {
            throw new NotImplementedException();
        }

        public int? OrderNo
        {
            get { throw new NotImplementedException(); }
        }

        public string WayBillNo
        {
            get { throw new NotImplementedException(); }
        }

        public IConsigneeRow Consignee
        {
            get { return _row.GetRelated<IConsigneeRow,IConsigneeReference>(); }
        }
    }
}