﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    /// <summary>
    /// Dinh muc cho salon
    /// </summary>
    public partial class KpiSalons
    {
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public double? Kpi { get; set; }
        public DateTime? KpiMonth { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}