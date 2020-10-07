﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class ExportGoods
    {
        public int Id { get; set; }
        /// <summary>
        /// Id người xuất hàng
        /// </summary>
        public int ExportId { get; set; }
        /// <summary>
        /// Id người nhận hàng
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// Danh sách Id hàng hóa (dạng json)
        /// </summary>
        public string GoodsIds { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Cấp độ xuất hàng : 1|Kho xuất cho salon, 2|Salon xuất cho thợ
        /// </summary>
        public int? Level { get; set; }
        public byte? IsDelete { get; set; }
        public int? SalonId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}