﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class SalaryConfigStaff
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? SalonId { get; set; }
        public int? SalaryConfigId { get; set; }
        public double? FixSalaryOscillation { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}