﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class BillDiscount
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public bool? IsService { get; set; }
        public int? ProductServiceId { get; set; }
        public double? DiscountPercent { get; set; }
        public bool? IsAddedBySalon { get; set; }
        public string DiscountReason { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public string DiscountSource { get; set; }
    }
}