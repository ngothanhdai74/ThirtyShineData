﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class MarketingChienDich
    {
        public int Id { get; set; }
        public string TieuDe { get; set; }
        public decimal? ChiPhi { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifileDate { get; set; }
        public bool? IsDelete { get; set; }
        public int? SalonId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}