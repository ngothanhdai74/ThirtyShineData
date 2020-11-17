using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Mockup
{
    public class OrderModel
    {
        public OrderModel()
        {
            Supplies = new List<OrderDetailModel>();
        }
        public List<OrderDetailModel> Supplies { get; set; }
        public void AddSupply(OrderDetailModel supply)
        {
            if (Supplies.Any(m => m.ProductId == supply.ProductId))
            {
                return;
            }
            Supplies.Add(supply);
        }
        //
        public int Id { get; set; }
        public string Code { get; set; }
        public int InventoryOrderId { get; set; }
        public int InventoryPartnerId { get; set; }
        public EnumDefine.OrderType OrderType { get; set; }
        public EnumDefine.OrderStatusType Status { get; set; }
        public string Note { get; set; }
        public int isAuto { get; set; }
        public EnumDefine.CosmeticType CosmeticType { get; set; }
        public int UserId { get; set; }
        public string imgs { get; set; }
    }
    public class OrderDetailModel
    {
        public int ProductId { get; set; }
        public int? QuantitySuggest { get; set; }
        public int QuantityOrder { get; set; }
    }
}
