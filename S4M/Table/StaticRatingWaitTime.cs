﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class StaticRatingWaitTime
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? SalonId { get; set; }
        public DateTime? WorkDate { get; set; }
        public int? BillGreat { get; set; }
        public int? BillGood { get; set; }
        public int? BillBad { get; set; }
        public int? Star1 { get; set; }
        public int? Star2 { get; set; }
        public int? Star3 { get; set; }
        public int? Star4 { get; set; }
        public int? Star5 { get; set; }
        public double? Point { get; set; }
        public int? SpeedCut { get; set; }
        public int? RankingPoint { get; set; }
        public int? RankingSpeedCut { get; set; }
        public int? BillNotImages { get; set; }
        public int? BillErrors { get; set; }
        public int? Before15p { get; set; }
        public int? Between15pAnd20p { get; set; }
        public int? After20p { get; set; }
        public int? NotTime { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? StaffType { get; set; }
        public int? TotalShinecombo { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public int? TotalBillService { get; set; }
    }
}