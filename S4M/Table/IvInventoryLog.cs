﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class IvInventoryLog
    {
        public int Id { get; set; }
        public int? InventoryId { get; set; }
        public int? ProductId { get; set; }
        public int? BillId { get; set; }
        public int? Quantity { get; set; }
        public int? UserId { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}