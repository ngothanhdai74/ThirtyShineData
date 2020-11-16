﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class ManagerLogBefore
    {
        [Key]
        public int Id { get; set; }
        public int? SalonId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Today { get; set; }
        public long? TotalStylist { get; set; }
        public long? TotalSkinner { get; set; }
        public int? TotalWorkHourStylist { get; set; }
        public bool? IsFacilities { get; set; }
        [StringLength(500)]
        public string NoteFacilities { get; set; }
        public bool? IsChargeHotline { get; set; }
        public bool? IsHotline { get; set; }
        public bool? IsMonitor { get; set; }
        public int? ConfirmDryTowel { get; set; }
        public int? FirstWatch { get; set; }
        public int? SecondWatch { get; set; }
        public int? ThirdWatch { get; set; }
        public int? FourthWatch { get; set; }
        public int? FifthWatch { get; set; }
        public int? SixthWatch { get; set; }
        [StringLength(500)]
        public string NoteWatch { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
    }
}