﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class SalaryIncome
    {
        [Key]
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? SalonId { get; set; }
        public double? FixedSalary { get; set; }
        public double? AllowanceSalary { get; set; }
        public double? OvertimeSalary { get; set; }
        public double? ServiceSalary { get; set; }
        public double? ProductSalary { get; set; }
        public double? BehaveSalary { get; set; }
        public double? RatingPoint { get; set; }
        public int? BillNormal { get; set; }
        public int? BillNormalGreat { get; set; }
        public int? BillNormalGood { get; set; }
        public int? BillNormalBad { get; set; }
        public int? BillNormalNoRating { get; set; }
        public int? BillSpecial { get; set; }
        public int? BillSpecialGreat { get; set; }
        public int? BillSpecialGood { get; set; }
        public int? BillSpecialBad { get; set; }
        public int? BillSpecialNoRating { get; set; }
        [Column(TypeName = "date")]
        public DateTime? WorkDate { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public double? TotalIncome { get; set; }
        public double? GrandTotalIncome { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public int? LevelId { get; set; }
        [Column("KPISalary")]
        public double Kpisalary { get; set; }
        public double? TempSalary { get; set; }
        public double? TopupProductSalary { get; set; }
    }
}