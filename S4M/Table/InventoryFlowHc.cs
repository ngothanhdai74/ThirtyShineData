﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class InventoryFlowHc
    {
        public int Id { get; set; }
        public int? InvenId { get; set; }
        public int? ProductId { get; set; }
        public double? Quantity { get; set; }
        public int? Cost { get; set; }
        public int? Price { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}