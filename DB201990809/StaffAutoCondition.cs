﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class StaffAutoCondition
    {
        public int Id { get; set; }
        public int? StaffTypeId { get; set; }
        public int? SkillLevelId { get; set; }
        public int? StaffId { get; set; }
        public int? SDate { get; set; }
        public double? Point { get; set; }
        public int? Kcs { get; set; }
        public int? Warning { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifieldTime { get; set; }
        public bool? IsDetele { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}