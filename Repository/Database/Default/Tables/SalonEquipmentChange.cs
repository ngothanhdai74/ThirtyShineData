﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class SalonEquipmentChange
    {
        [Key]
        public int Id { get; set; }
        public int? EquipmentId { get; set; }
        public int? StaffId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
    }
}