﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class IvInventoryCheckTime
    {
        public int Id { get; set; }
        public int? InventoryId { get; set; }
        public int? CheckTime { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? State { get; set; }
        public DateTime? BeginCheckDate { get; set; }
        public DateTime? EndCheckDate { get; set; }
        public DateTime? SellAfterCheckTime { get; set; }
    }
}