﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Marketing_ChienDich")]
    public partial class MarketingChienDich
    {
        [Key]
        public int Id { get; set; }
        [StringLength(600)]
        public string TieuDe { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? ChiPhi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayBatDau { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayKetThuc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifileDate { get; set; }
        public bool? IsDelete { get; set; }
        public int? SalonId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}