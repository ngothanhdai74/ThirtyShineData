﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class FlowTimeKeepingHis
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int SalonId { get; set; }
        public DateTime? WorkDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte? IsDelete { get; set; }
        public int? DoUserId { get; set; }
        public string Note { get; set; }
        public int? WorkHour { get; set; }
        public int? Type { get; set; }
        public bool? IsEnroll { get; set; }
        public int? WorkTimeId { get; set; }
        public string HourIds { get; set; }
        public DateTime? CheckinFirstTime { get; set; }
        public DateTime? CheckoutLastTime { get; set; }
        public int? DelayTime { get; set; }
        public bool? CheckEnroll { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public bool? Use2ndSubHours { get; set; }
        public int? TeamId { get; set; }
    }
}