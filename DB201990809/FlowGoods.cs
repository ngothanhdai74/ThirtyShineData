﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class FlowGoods
    {
        public int Id { get; set; }
        public int ExportGoodsId { get; set; }
        /// <summary>
        /// Id của vật tư
        /// </summary>
        public int GoodsId { get; set; }
        /// <summary>
        /// Giá gốc
        /// </summary>
        public int? Cost { get; set; }
        /// <summary>
        /// Giá
        /// </summary>
        public int? Price { get; set; }
        /// <summary>
        /// Số lượng
        /// </summary>
        public int? Quantity { get; set; }
        /// <summary>
        /// % Khuyến mãi
        /// </summary>
        public int? VoucherPercent { get; set; }
        /// <summary>
        /// Tiền khuyễn mãi
        /// </summary>
        public int? PromotionMoney { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte? IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}