﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class IvInventoryMaxService
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? InventoryId { get; set; }
        public int? InvMaxDay { get; set; }
        public decimal? InvMaxOld { get; set; }
        public decimal? InvMaxSugges { get; set; }
        public decimal? InvMaxUser { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}