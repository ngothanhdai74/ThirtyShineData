﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("TypeError_SpecailCus")]
    public partial class TypeErrorSpecailCus
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("SpecailCus_ID")]
        public int? SpecailCusId { get; set; }
        [Column("TypeError_SpecialCus_ID")]
        public int? TypeErrorSpecialCusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Publish { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}