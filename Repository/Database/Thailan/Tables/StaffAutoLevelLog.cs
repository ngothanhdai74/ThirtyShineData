﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class StaffAutoLevelLog
    {
        [Key]
        public int Id { get; set; }
        [Column("Staff_Id")]
        public int? StaffId { get; set; }
        [Column("Salon_Id")]
        public int? SalonId { get; set; }
        [Column("StaffType_Id")]
        public int? StaffTypeId { get; set; }
        [Column("SkillLevel_Id")]
        public int? SkillLevelId { get; set; }
        [Column("SkillLevelup_Id")]
        public int? SkillLevelupId { get; set; }
        [Column("Levelup_Id")]
        public int? LevelupId { get; set; }
        [Column("sDate", TypeName = "datetime")]
        public DateTime? SDate { get; set; }
        public double? Point { get; set; }
        [Column("KCS")]
        public double? Kcs { get; set; }
        public int? Warning { get; set; }
        [Column("TSL_DanhGia")]
        [StringLength(300)]
        public string TslDanhGia { get; set; }
        public bool? StatusSkillLevel { get; set; }
        public int? Approval { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifieldTime { get; set; }
        public bool? IsCondition { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsLevelUp { get; set; }
        public bool? IsApproval { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}