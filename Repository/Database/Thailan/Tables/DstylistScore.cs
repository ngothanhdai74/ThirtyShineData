﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("DStylistScore")]
    public partial class DstylistScore
    {
        [Key]
        [Column("DStylistScoreId")]
        public int DstylistScoreId { get; set; }
        public int? StylistId { get; set; }
        public int? Appearence { get; set; }
        public int? Communication { get; set; }
        [Column("AvgSCSC")]
        public double? AvgScsc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastDateUpdate { get; set; }
        public double? AvgTimeCut { get; set; }
        public double? StylistScore { get; set; }
    }
}