using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Repository.Mockup
{
    public class EnumDefine
    {
        public enum InventoryType
        {
            [Description("Kho tổng")]
            MainWareHouse = 1,
            [Description("Kho Salon")]
            SalonWareHouse = 2,
            [Description("Kho nhân viên")]
            EmployeeWareHouse = 3,
            [Description("Kho nhà cung cấp")]
            ProviderWareHose = 4
        }
        public enum ConsumptionType
        {
            [Description("Tiêu thụ vật tư theo định lượng")]
            QuantitfySupplies = 4,
            [Description("Tiêu thụ vật tư theo số lượng khách")]
            QuantitfyCustomer = 2,
        }
        public enum OrderType
        {
            [Description("Nhập")]
            Import = 1,
            [Description("Xuất")]
            Export = 2
        }
        public enum CosmeticType
        {
            [Description("Sản phẩm bán")]
            ProductSell = 1,
            [Description("Vật tư")]
            Supply = 2
        }
        public enum OrderStatusType
        {
            [Description("Chưa Order")]
            NotOrderYet = 1,
            [Description("Đã Order")]
            Ordered = 2,
            [Description("Từ chối")]
            Reject = 3,
            [Description("Chờ nhận hàng")]
            WaitReceived = 4,
            [Description("Đã nhận hàng")]
            Received = 5,
            [Description("Đã xuất hàng")]
            OrderExported = 6,
        }
    }
}
