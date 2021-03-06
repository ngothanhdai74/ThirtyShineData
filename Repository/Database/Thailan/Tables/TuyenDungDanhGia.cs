﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("TuyenDung_DanhGia")]
    public partial class TuyenDungDanhGia
    {
        [Key]
        public int Id { get; set; }
        [Column("UngVienID")]
        public int? UngVienId { get; set; }
        [Column("UserTestID")]
        public int? UserTestId { get; set; }
        [Column("MapSkillLevelID")]
        [StringLength(200)]
        public string MapSkillLevelId { get; set; }
        [StringLength(200)]
        public string ImgSkill1 { get; set; }
        [StringLength(200)]
        public string ImgSkill2 { get; set; }
        [StringLength(200)]
        public string VideoLink { get; set; }
        [StringLength(200)]
        public string KyNangHoaChat { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public string Note { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}