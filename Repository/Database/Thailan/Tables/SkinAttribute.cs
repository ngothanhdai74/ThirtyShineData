﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Skin_Attribute")]
    public partial class SkinAttribute
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string SkinTypeName { get; set; }
        public int? ParentId { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Status { get; set; }
        public int? Order { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}