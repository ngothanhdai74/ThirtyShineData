﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Booking_Statistic_Slot")]
    public partial class BookingStatisticSlot
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("SalonID")]
        public int? SalonId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? WorkDate { get; set; }
        public int? Slot { get; set; }
        public double? PercentSlot { get; set; }
        public bool? IsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}