﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class IvMaxServiceInventoryNorms
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
        public decimal MaxInventoryOld { get; set; }
        public decimal MaxInventorySugges { get; set; }
        public decimal MaxUsedInServiceLastPeriod { get; set; }
        public decimal? MaxInventoryUserInput { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDelete { get; set; }
    }
}