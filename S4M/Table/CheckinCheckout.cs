﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class CheckinCheckout
    {
        public int Id { get; set; }
        public DateTime? CheckinTime { get; set; }
        public DateTime? CheckoutTime { get; set; }
        public int? SalonId { get; set; }
        public int? StaffId { get; set; }
        public int? FlowTimeKeepingId { get; set; }
        public DateTime? WorkDate { get; set; }
        public bool? IsDelete { get; set; }
        public string UniqueKey { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public bool? IsComeLateConfirm { get; set; }
        public bool? IsLeaveEarlyConfirm { get; set; }
        public bool? IsLeaveEarly { get; set; }
        public bool? IsComeLate { get; set; }
    }
}