﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class SpecialCusDetail
    {
        public int Id { get; set; }
        public int? SpecialCusId { get; set; }
        public DateTime? CutErrorDate { get; set; }
        public int? StaffId { get; set; }
        public int? SalonId { get; set; }
        public int? QuantityInvited { get; set; }
        public double? DiscountServices { get; set; }
        public double? DiscountCosmetic { get; set; }
        public int? Note { get; set; }
        public bool? IsDelete { get; set; }
        public string ReasonDiff { get; set; }
        public int? QuantityFree { get; set; }
        public bool? IsMsm { get; set; }
        public int? Smsstatus { get; set; }
        public DateTime? SendDate { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}