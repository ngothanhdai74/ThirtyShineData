﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class StynextStaticData
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? StynextGroupId { get; set; }
        public int? SalonId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? WorkDate { get; set; }
        public int? TotalBill { get; set; }
        public int? TotalReturn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public double? ServiceRevenue { get; set; }
        public double? ProductRevenue { get; set; }
        public double? ServiceCommission { get; set; }
        public double? ProductCommission { get; set; }
        public double? FixedSalary { get; set; }
        public double? FixedSalaryTest { get; set; }
        public double BehaveSalary { get; set; }
        public double? GuaranteeServiceCommission { get; set; }
        public double? OvertimeHourServiceRevenue { get; set; }
        public double? OvertimeDayServiceRevenue { get; set; }
        public int? TotalReturnR45 { get; set; }
        public double? RxBonus { get; set; }
        public double? OvertimeBonus { get; set; }
        public double? ServiceUpsaleSalary { get; set; }
        public int? TotalUpsale { get; set; }
        public double? RxBonus30 { get; set; }
        public double? RxBonus45 { get; set; }
    }
}