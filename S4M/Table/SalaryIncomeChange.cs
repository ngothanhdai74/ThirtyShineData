﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class SalaryIncomeChange
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? SalonId { get; set; }
        public string ChangedType { get; set; }
        public int? ChangedTypeId { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public int? Point { get; set; }
        public int? ScoreFactor { get; set; }
        public DateTime? WorkDate { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}