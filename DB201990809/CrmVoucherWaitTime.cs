﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class CrmVoucherWaitTime
    {
        public int Id { get; set; }
        public int? BillId { get; set; }
        public int? CustomerId { get; set; }
        public int? CheckinId { get; set; }
        public int? StylistId { get; set; }
        public int? SkinnerId { get; set; }
        public int? SalonId { get; set; }
        public double? VoucherPercent { get; set; }
        public bool? IsUsed { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public double? CheckinPoint { get; set; }
        public double? CheckinMoney { get; set; }
        public double? SkinnerPoint { get; set; }
        public double? SkinnerMoney { get; set; }
        public double? StylistPoint { get; set; }
        public double? StylistMoney { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}