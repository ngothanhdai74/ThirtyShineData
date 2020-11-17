﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("KPI_Salon_Points")]
    public partial class KpiSalonPoints
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string PointValue { get; set; }
        public double? ConditionMax { get; set; }
        public double? ConditionMin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}