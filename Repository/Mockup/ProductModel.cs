using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWarehouseManagement.Models
{
    public class ProductModel
    {
        public int? Begin { get; set; }
        public int? Import { get; set; }
        public int? Export { get; set; }
        public int? SellOrUse { get; set; }
        public int? GroupQuantityId { get; set; }
        public bool IsBase { get; set; } // nếu == true: vật tư này sẽ mặc định được chọn để trừ đi trong nhóm vật tư
        public int? ProductId { get; set; }// Id vật tư
        public int? ProductIdChosen { get; set; }// vật tư được chọn do skinner chọn trên app
        public int? Volume { get; set; }// khổi lượng của vật tư đó khi vật tư đó đầy đủ
        public int? Quantify { get; set; }// định lượng sản phẩm đó mỗi lần sử dụng
        public int? ServiceUsedCount { get; set; }// số lần dịch vụ đã đc sử dụng sản phẩm này trong (distanceDay) ngày
        public decimal? QuantityUsed // số lượng sản phẩm này đã sử dụng trong (distanceDay) ngày
        {
            get
            {
                if (Volume.HasValue && Quantify.HasValue)
                {
                    var productCountValue = (Volume.Value / (Quantify.Value * 1.0m));// số lần sử dụng để có thể sài hết 1 sản phẩm
                    var value = ServiceUsedCount.GetValueOrDefault() / productCountValue;
                    return Math.Round(value);
                }
                return null;
            }
        }
        /// <summary>
        /// tồn kho erp tự động tính = tồn đầu ngày(Begin) + nhập(nếu có(Import)) - xuất(nếu có(Export)) - số lượng vật tư sử dụng trong (distanceDay) ngày qua
        /// </summary>
        public decimal? InventoryRemainComputed
        {
            get
            {
                if (Begin.HasValue && QuantityUsed.HasValue)
                {
                    return Begin.Value + Import.GetValueOrDefault() - Export.GetValueOrDefault() - SellOrUse.GetValueOrDefault() - QuantityUsed.Value;
                }
                return null;
            }
        }
    }
}
