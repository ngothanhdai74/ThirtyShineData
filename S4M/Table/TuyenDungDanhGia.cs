﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class TuyenDungDanhGia
    {
        public int Id { get; set; }
        public int? UngVienId { get; set; }
        public int? UserTestId { get; set; }
        public string MapSkillLevelId { get; set; }
        public string ImgSkill1 { get; set; }
        public string ImgSkill2 { get; set; }
        public string VideoLink { get; set; }
        public string KyNangHoaChat { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string Note { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}