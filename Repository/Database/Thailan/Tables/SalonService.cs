﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Salon_Service")]
    public partial class SalonService
    {
        [Key]
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public int? ServiceId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [Column("HeSoHL")]
        public int? HeSoHl { get; set; }
        public bool? IsCheck { get; set; }
        public bool? IsCheckSalon { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}