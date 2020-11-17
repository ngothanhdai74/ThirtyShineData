﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    /// <summary>
    /// diem chuyen doi
    /// </summary>
    [Table("KPI_Point_Mappings")]
    public partial class KpiPointMappings
    {
        [Key]
        public int Id { get; set; }
        [StringLength(6)]
        public string Point { get; set; }
        public int? Value { get; set; }
        public byte? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public double? SalaryPercent { get; set; }
    }
}