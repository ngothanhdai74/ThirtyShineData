﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class ReportProductivity
    {
        public int Id { get; set; }
        public int? TongBill { get; set; }
        /// <summary>
        /// doanh thu mỹ phẩm
        /// </summary>
        public int? RevenueProduct { get; set; }
        /// <summary>
        /// doanh thu dịch vụ
        /// </summary>
        public int? RevenueService { get; set; }
        public int? StaffId { get; set; }
        public int? IsSkinner { get; set; }
        public DateTime? Creatdate { get; set; }
        public int? SalonId { get; set; }
        public decimal? WorkHour { get; set; }
        public int? ShineCombo { get; set; }
        public int? Sc2 { get; set; }
        public int? Sc3 { get; set; }
        public int? Sc4 { get; set; }
        public int? DvSkinner { get; set; }
        public int? UonCaoCap { get; set; }
        public int? UonTieuChuan { get; set; }
        public int? NhuomCaoCap { get; set; }
        public int? NhuomTieuChuan { get; set; }
        public int? DuongToc { get; set; }
    }
}