﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("TuyenDung_UngVien")]
    public partial class TuyenDungUngVien
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string FullName { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        /// <summary>
        /// Số Chứng Minh Thư
        /// </summary>
        [Column("CMT")]
        [StringLength(50)]
        public string Cmt { get; set; }
        /// <summary>
        /// Ảnh CMT 1
        /// </summary>
        [Column("CMTimg1")]
        [StringLength(300)]
        public string Cmtimg1 { get; set; }
        /// <summary>
        /// Ảnh CMT2
        /// </summary>
        [Column("CMTimg2")]
        [StringLength(300)]
        public string Cmtimg2 { get; set; }
        [StringLength(300)]
        public string MainImg { get; set; }
        /// <summary>
        /// Thời gian tạo hồ sơ ứng viên, cũng chính là bước 1
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Step1Time { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Step1ModifiedTime { get; set; }
        /// <summary>
        /// Thời gian cập nhật ở bước 2, là bước nhập ảnh, link video
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? Step2Time { get; set; }
        /// <summary>
        /// Bước cuối cùng, duyệt ứng viên
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StepEndTime { get; set; }
        public bool? IsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Step2ModifiedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StepEndModifiedTime { get; set; }
        /// <summary>
        /// Ảnh kỹ năng
        /// </summary>
        [StringLength(300)]
        public string ImgSkill1 { get; set; }
        /// <summary>
        /// Ảnh kỹ năng
        /// </summary>
        [StringLength(300)]
        public string ImgSkill2 { get; set; }
        /// <summary>
        /// Link video kỹ năng, có thể là link youtube
        /// </summary>
        [StringLength(300)]
        public string VideoLink { get; set; }
        public int? DepartmentId { get; set; }
        public string Step2Note { get; set; }
        public bool? Approve { get; set; }
        public string StepEndNote { get; set; }
        public int? UngVienStatusId { get; set; }
        public string KyNangHoaChat { get; set; }
        public string StepEndNoteStaff { get; set; }
        public int? NguoiGioiThieuId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgaySinh { get; set; }
        public int? NguonTuyenDungId { get; set; }
        [Column("salonId")]
        public int? SalonId { get; set; }
        public int? GioiTinhId { get; set; }
        [StringLength(300)]
        public string ImgSkillDaoTao1 { get; set; }
        [StringLength(300)]
        public string ImgSkillDaoTao2 { get; set; }
        public string StepEndNoteDaoTao { get; set; }
        public string LinkFaceBook { get; set; }
        public int? TinhThanhId { get; set; }
        [StringLength(300)]
        public string MainImg2 { get; set; }
        [Column("Point_Figure")]
        public int? PointFigure { get; set; }
        [Column("Test_VH")]
        [StringLength(150)]
        public string TestVh { get; set; }
        [Column("Parse_VH")]
        public bool? ParseVh { get; set; }
        public bool? TestAgain { get; set; }
        [Column("TesterID")]
        public int? TesterId { get; set; }
        public int? StaffId { get; set; }
        [StringLength(150)]
        public string TestCut { get; set; }
        [StringLength(150)]
        public string TestChemistry { get; set; }
        public bool? PassCut { get; set; }
        public bool? TestCutAgain { get; set; }
        public bool? PassChemistry { get; set; }
        public bool? TestChemistryAgain { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ProvidedDate { get; set; }
        [StringLength(300)]
        public string ProvidedLocale { get; set; }
        public int? StatusRelationId { get; set; }
        [StringLength(300)]
        public string Address { get; set; }
        public int? RecruimentId { get; set; }
    }
}