﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class OperationReportConfig
    {
        [Key]
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public byte? SalonType { get; set; }
        [StringLength(1024)]
        public string DataJson { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        [Column(TypeName = "date")]
        public DateTime? MonthApply { get; set; }
        public bool? IsRegion { get; set; }
    }
}