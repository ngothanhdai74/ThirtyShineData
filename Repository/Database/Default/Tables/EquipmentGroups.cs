﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("Equipment_Groups")]
    public partial class EquipmentGroups
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(10)]
        public string GroupCode { get; set; }
        public bool? IsActive { get; set; }
    }
}