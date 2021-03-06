﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("Api_HairMode")]
    public partial class ApiHairMode
    {
        [Key]
        public int Id { get; set; }
        [StringLength(600)]
        public string Title { get; set; }
        public string Description { get; set; }
        [StringLength(400)]
        public string Thumb { get; set; }
        public string Images { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Publish { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public int? Order { get; set; }
        public int? CategoryId { get; set; }
        [StringLength(600)]
        public string CareLink { get; set; }
        public bool? ApplyForLevel { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}