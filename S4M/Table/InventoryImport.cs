﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class InventoryImport
    {
        public int Id { get; set; }
        public string ProductIds { get; set; }
        public int? TotalMoney { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CompleteBillTime { get; set; }
        public bool? IsDelete { get; set; }
        public int? SalonId { get; set; }
        /// <summary>
        /// Id người nhận
        /// </summary>
        public int? RecipientId { get; set; }
        /// <summary>
        /// Id người nhập liệu
        /// </summary>
        public int? DoId { get; set; }
        public string Note { get; set; }
        public DateTime? ImportDate { get; set; }
        public int? ImportType { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}