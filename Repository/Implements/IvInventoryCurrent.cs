using DB201990809;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uitility.Common;

namespace Repository.Implements
{
    public class IvInventoryCurrentRepo : BaseRepository<_20190809Context, IvInventoryCurrent>, IIvInventoryCurrent
    {
        public IvInventoryCurrentRepo(_20190809Context context) : base(context) { }

        public async Task AutomaticCreateOrder()
        {
            try
            {
                //groupby các vật tư cùng 1 kho salon
                var inventories = from i in _dbContext.IvInventoryCurrent
                                  group i by i.InventoryId;

                foreach (var productsGroup in inventories)
                {
                    var key = productsGroup.Key;// inventioryId
                    if (key.HasValue)
                    {
                        var order = new SuppliesOrder(key.Value);
                        foreach (var product in productsGroup)
                        {
                            //số dịch vụ
                            int serviceCount = await CalculateServiceCount(salonId: 1);
                            // định lượng
                            decimal quantify = await CalculateQuantify(serviceId: 1);
                            //tồn kho tự động tính toán
                            decimal inventoryRemain = product.Begin.GetValueOrDefault() + product.Import.GetValueOrDefault() - product.Export.GetValueOrDefault() - (serviceCount * quantify);
                            // tồn an toàn
                            decimal safeInventory = await GetSafeInventory(productId: 1);
                            if (inventoryRemain <= safeInventory)
                            {
                                //tự động tính toán số lượng vật tư cần trả cho kho salon
                                var MaxInventory = await GetMaxInventory(product.Id);
                                order.AddSupply(new Supply(product.Id, MaxInventory));
                            }
                        }
                        //tự động tạo đơn trả từ kho tổng về kho salon
                        var result = await CreateOrder(order);
                        //
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task Process()
        {

            var pageIndex = 0;
            var pageSize = 100;
            var paging = new Paging(pageIndex, pageSize);
            var data = await QueryAsync(paging);

            if (data?.Any() == true)
            {
                var totalPage = paging.TotalRow / pageSize + (paging.TotalRow % pageSize == 0 ? 0 : 1);
                while (pageIndex < totalPage)
                {
                    // handler data

                    //
                    pageIndex++;
                    paging = new Paging(pageIndex, pageSize);
                    data = await QueryAsync(paging);
                }
            }
        }
        private async Task<bool> CreateOrder(SuppliesOrder order)
        {
            try
            {

                return false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private async Task<decimal> GetMaxInventory(int productId)
        {

            return -1;
        }
        private async Task<decimal> GetSafeInventory(int productId)
        {

            return -1;
        }
        private async Task<int> CalculateServiceCount(int salonId)
        {

            return -1;
        }
        private async Task<decimal> CalculateQuantify(int serviceId)
        {

            return -1;
        }
    }
    public class SuppliesOrder
    {
        public SuppliesOrder(int inventoryId)
        {
            InventoryId = inventoryId;
            Supplies = new List<Supply>();
        }
        public int InventoryId { get; set; }
        public List<Supply> Supplies { get; set; }
        public void AddSupply(Supply supply)
        {
            Supplies.Add(supply);
        }
    }
    public class Supply
    {
        public Supply(int productId, decimal quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
    }
}
