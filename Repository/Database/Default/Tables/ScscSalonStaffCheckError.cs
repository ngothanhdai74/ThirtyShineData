﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("SCSC_SalonStaffCheckError")]
    public partial class ScscSalonStaffCheckError
    {
        [Key]
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public int? StaffId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkDate { get; set; }
        public bool? IsDefault { get; set; }
        [StringLength(500)]
        public string Reason { get; set; }
        [StringLength(50)]
        public string WorkWeek { get; set; }
    }
}