﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("tbl_Form_Misstake")]
    public partial class TblFormMisstake
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Formality { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column("isDelete")]
        public bool? IsDelete { get; set; }
        [Column("isPuslish")]
        public bool? IsPuslish { get; set; }
        [StringLength(50)]
        public string Slug { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}