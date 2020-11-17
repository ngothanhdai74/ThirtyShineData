﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("Stylist4Men_Tuition")]
    public partial class Stylist4MenTuition
    {
        [Key]
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? AmountCollected { get; set; }
        public int? PayTheMoney { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreaetedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiledTime { get; set; }
        public bool? Publish { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}