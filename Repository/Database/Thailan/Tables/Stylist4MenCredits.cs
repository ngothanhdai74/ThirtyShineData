﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Stylist4Men_Credits")]
    public partial class Stylist4MenCredits
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Publish { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}