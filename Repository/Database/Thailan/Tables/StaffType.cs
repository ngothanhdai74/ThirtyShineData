﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Staff_Type")]
    public partial class StaffType
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        [StringLength(300)]
        public string Meta { get; set; }
        public bool? Publish { get; set; }
        public byte? IsDelete { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Order { get; set; }
        [StringLength(300)]
        public string SkillLevelIds { get; set; }
        public bool? IsSpecialBillRating { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}