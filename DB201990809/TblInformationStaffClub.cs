﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class TblInformationStaffClub
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? PointShape { get; set; }
        public int? PointCubes { get; set; }
        public int? PointDryingWar { get; set; }
        public int? PointFade { get; set; }
        public int? PointTatoo { get; set; }
        public int? PointCurling { get; set; }
        public int? PointDye { get; set; }
        public int? PointTheoryCut { get; set; }
        public int? PointPracticeCut { get; set; }
        public int? PointTheoryChemistry { get; set; }
        public int? PointPacticeChemistry { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Publish { get; set; }
        public string Images1 { get; set; }
        public string Images2 { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}