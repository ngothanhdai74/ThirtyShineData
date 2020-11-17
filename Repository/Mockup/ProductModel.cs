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
        public static List<ProductModel> GetMock()
        {
            List<ProductModel> models = new List<ProductModel>();

            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1056,
                ProductId = 39,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1056,
                ProductId = 44,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1057,
                ProductId = 58,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1057,
                ProductId = 67,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1058,
                ProductId = 91,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1058,
                ProductId = 92,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1059,
                ProductId = 94,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1059,
                ProductId = 95,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1060,
                ProductId = 97,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1060,
                ProductId = 98,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1056,
                ProductId = 39,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1056,
                ProductId = 44,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1057,
                ProductId = 58,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1057,
                ProductId = 67,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1058,
                ProductId = 91,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1058,
                ProductId = 92,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1059,
                ProductId = 94,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1059,
                ProductId = 95,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1060,
                ProductId = 97,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });
            models.Add(new ProductModel()
            {
                Begin = 1,
                Export = 1,
                Import = 1,
                SellOrUse = 1,
                GroupQuantityId = 1060,
                ProductId = 98,
                Quantify = 1,
                IsBase = false,
                ProductIdChosen = 1,
                Volume = 3,
                ServiceUsedCount = 5,
            });

            return models;
        }
        public static bool Compare(List<ProductModel> model1)
        {
            List<ProductModel> model2 = GetMock();
            if (model1.Count == model2.Count)
            {
                for (int i = 0; i < model1.Count; i++)
                {
                    if (Compare(model1[i], model2[i]) == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private static bool Compare(ProductModel model1, ProductModel model2)
        {
            if (model1 == null || model2 == null)
            {
                return false;
            }
            if (model1.Begin == model2.Begin &&
               model1.Import == model2.Import &&
                model1.Export == model2.Export &&
                model1.SellOrUse == model2.SellOrUse &&
                model1.ProductId == model2.ProductId &&
                model1.Volume == model2.Volume &&
                model1.Quantify == model2.Quantify &&
                model1.ServiceUsedCount == model2.ServiceUsedCount &&
                model1.QuantityUsed == model2.QuantityUsed
                 )
            {
                return true;
            }
            return false;
        }
    }
}
