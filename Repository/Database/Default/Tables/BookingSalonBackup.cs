﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("Booking_SalonBackup")]
    public partial class BookingSalonBackup
    {
        [Key]
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public int? SalonBackupId { get; set; }
        public bool IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}