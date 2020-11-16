﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class SalaryConfig
    {
        [Key]
        public int Id { get; set; }
        public int? TypeWork { get; set; }
        public int? DepartmentId { get; set; }
        public int? LevelId { get; set; }
        public double? FixedSalary { get; set; }
        public double? AllowanceSalary { get; set; }
        public double? OvertimeSalary { get; set; }
        public double? RattingSalary { get; set; }
        public double? ProductBonus { get; set; }
        public double? BehaveSalary { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}