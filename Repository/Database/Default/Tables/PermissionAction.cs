﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class PermissionAction
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}