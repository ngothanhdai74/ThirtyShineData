﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("StaticServices_Profit")]
    public partial class StaticServicesProfit
    {
        [Key]
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public int? TongHoaDon { get; set; }
        public int? ShinCombo { get; set; }
        public int? KidCombo { get; set; }
        public int? Protein { get; set; }
        public int? Duoi { get; set; }
        public int? Uon { get; set; }
        public int? Nhuom { get; set; }
        public int? Tay { get; set; }
        public int? TayX2 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? WorkDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        [Column("SCSCBill")]
        public int? Scscbill { get; set; }
        [Column("SCSCPoint")]
        public int? Scscpoint { get; set; }
        [Column("SCSCAVG")]
        public double? Scscavg { get; set; }
        public int? BillLongTime { get; set; }
        public double? LongTimePercent { get; set; }
    }
}