﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    /// <summary>
    /// Diem KPI cho Point
    /// </summary>
    [Table("KPI_Property_Points")]
    public partial class KpiPropertyPoints
    {
        [Key]
        public int Id { get; set; }
        [Column("KPI_CriteriaId")]
        public int? KpiCriteriaId { get; set; }
        [StringLength(10)]
        public string PointValue { get; set; }
        public double? ConditonMax { get; set; }
        public double? ConditonMin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}