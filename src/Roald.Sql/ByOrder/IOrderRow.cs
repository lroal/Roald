namespace Roald.Sql.ByOrder
{
    public interface IOrderRow : IRowJacket
{
    
     int? OrderNo { get; }
     string WayBillNo { get; }
     IConsigneeRow Consignee { get; }
}
}