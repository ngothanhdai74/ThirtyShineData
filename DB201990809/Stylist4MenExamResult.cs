﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class Stylist4MenExamResult
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? TheoryExamId { get; set; }
        public double? DiemCao { get; set; }
        public double? DiemBatTepToc { get; set; }
        public double? DiemTongLuoc { get; set; }
        public double? DiemDangDung { get; set; }
        public double? DiemSayToc { get; set; }
        public int? UserUpload { get; set; }
        public int? UserUpdateTheoryScore { get; set; }
        public string NoteUpdateTheoryScore { get; set; }
        public DateTime? UpdateTheoryScoreTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string PracticalImgs { get; set; }
        public double? DiemHinhKhoi { get; set; }
        public double? DiemLienKet { get; set; }
        public double? DiemDuongNet { get; set; }
        public double? DiemHoanThien { get; set; }
        public double? DiemDongTac { get; set; }
        public double? DiemThoiGian { get; set; }
        public int? UserTestPratice { get; set; }
        public string NoteTestPratice { get; set; }
        public DateTime? TimeTestPratice { get; set; }
        public DateTime? UploadImageTime { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsPassTheory { get; set; }
        public bool? IsPassPratice { get; set; }
    }
}