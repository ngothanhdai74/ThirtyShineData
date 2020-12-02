﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Api_HairMode_Level")]
    public partial class ApiHairModeLevel
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        [StringLength(300)]
        public string Title { get; set; }
        [StringLength(600)]
        public string Description { get; set; }
        public int? Value { get; set; }
        public bool? Publish { get; set; }
        public bool? IsDelete { get; set; }
        public int? Order { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}