﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class StatisticScscError
    {
        [Key]
        public int Id { get; set; }
        public int? StylistId { get; set; }
        public int? SalonId { get; set; }
        public int? TongKhongAnhScsc { get; set; }
        public int? TongAnhLoiScsc { get; set; }
        public int? TongAnhMoScsc { get; set; }
        public int? TongKhongMoScsc { get; set; }
        public int? TongLoiScscHoacUon { get; set; }
        public int? TongDiemScsc { get; set; }
        public int? TongErrorShape { get; set; }
        public int? TongErrorComplatetion { get; set; }
        public int? TongErrorSharpNess { get; set; }
        public int? TongKhongAnhUon { get; set; }
        public int? TongBillUon { get; set; }
        public int? TongAnhUon { get; set; }
        public int? TongMoLechUon { get; set; }
        public int? TongLoiUon { get; set; }
        public int? TongErrorHairTip { get; set; }
        public int? TongErrorHairRoots { get; set; }
        public int? TongErrorHairWaves { get; set; }
        [Column(TypeName = "date")]
        public DateTime? WorkDate { get; set; }
        public bool IsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public int? TotalBill { get; set; }
        public int? TongDiemUon { get; set; }
        public int? TongMoLechUonScsc { get; set; }
        public int? TongErrorConnective { get; set; }
        public int? TongBillChuaDanhGia { get; set; }
        public int? TongBillCat { get; set; }
        public int? TongLoiCaUonVaCat { get; set; }
        public int TongBillChuaDanhGiaCur { get; set; }
        public int TongBillChuaDanhGiaScsc { get; set; }
        public int TongBillChuaDanhGiaScscandCur { get; set; }
        public int TotalCreative { get; set; }
        public int TotalBillNeedCheck { get; set; }
    }
}