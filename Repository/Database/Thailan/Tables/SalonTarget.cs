﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class SalonTarget
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? WorkDate { get; set; }
        public int? SalonId { get; set; }
        [Column("KPIDistribution")]
        public double Kpidistribution { get; set; }
        public long? Type { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifielTime { get; set; }
        public bool? IsDelete { get; set; }
    }
}