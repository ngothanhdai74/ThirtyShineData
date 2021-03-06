﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class StaffAutoCondition
    {
        [Key]
        public int Id { get; set; }
        [Column("StaffType_Id")]
        public int? StaffTypeId { get; set; }
        [Column("SkillLevel_Id")]
        public int? SkillLevelId { get; set; }
        [Column("staff_Id")]
        public int? StaffId { get; set; }
        [Column("sDate")]
        public int? SDate { get; set; }
        public double? Point { get; set; }
        [Column("KCS")]
        public int? Kcs { get; set; }
        public int? Warning { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifieldTime { get; set; }
        public bool? IsDetele { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}