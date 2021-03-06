﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("Api_HairMode_Staff")]
    public partial class ApiHairModeStaff
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public int? StaffId { get; set; }
        public int? HairModeId { get; set; }
        public int? HairModeLevelId { get; set; }
        public bool? Publish { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsChecked { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}