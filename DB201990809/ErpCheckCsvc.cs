﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class ErpCheckCsvc
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public int? StaffId { get; set; }
        public int? SalonId { get; set; }
        public DateTime? DateTime { get; set; }
        public string Description { get; set; }
        public int? CreatorId { get; set; }
        public bool? IsOk { get; set; }
        public bool? IsReported { get; set; }
        public DateTime? FixDate { get; set; }
        public int? FixStaffId { get; set; }
        public int? Status { get; set; }
        public int? Time { get; set; }
        public int? DoingStaffId { get; set; }
        public int? ConfirmStaffId { get; set; }
        public DateTime? DoingCreateDate { get; set; }
        public DateTime? ConfirmCreateDate { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}