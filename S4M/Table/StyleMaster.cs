﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class StyleMaster
    {
        public int Id { get; set; }
        public string PostNumber { get; set; }
        public string StylistName { get; set; }
        public int? StylistId { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public byte? ImageSource { get; set; }
        public int? TotalLike { get; set; }
        public int? StyleMasterStatusId { get; set; }
        public DateTime? ApproveTime { get; set; }
        public int? ApproveUserId { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? BillId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public int AutoLikeNumber { get; set; }
        public bool? UseCurling { get; set; }
        public bool? UseHairDye { get; set; }
    }
}