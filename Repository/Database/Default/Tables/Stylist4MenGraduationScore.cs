﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("Stylist4Men_GraduationScore")]
    public partial class Stylist4MenGraduationScore
    {
        [Key]
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? PointPracticeCut { get; set; }
        public int? PointTheoryCut { get; set; }
        public int? PointTheoryChemistry { get; set; }
        public int? PointPacticeChemistry { get; set; }
        public int? StatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Publish { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}