﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("TrackingWeb_DataV2")]
    public partial class TrackingWebDataV2
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EventID")]
        public int? EventId { get; set; }
        public int? Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [StringLength(50)]
        public string TokenKey { get; set; }
        [StringLength(200)]
        public string Meta { get; set; }
        [Column("VersionID")]
        public int? VersionId { get; set; }
        public int? Counting { get; set; }
        [Column("StylistID")]
        public int? StylistId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TrackDate { get; set; }
        [Column("SalonID")]
        public int? SalonId { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [Column("Booking_ID")]
        public int? BookingId { get; set; }
        [Column("Hour_ID")]
        public int? HourId { get; set; }
        public int? CountFrames { get; set; }
        [StringLength(255)]
        public string CusNote1 { get; set; }
        [StringLength(255)]
        public string CusNote2 { get; set; }
        [StringLength(255)]
        public string Device { get; set; }
        [StringLength(500)]
        public string SalonNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeSalonNote { get; set; }
        public int? PopupSalonStatis { get; set; }
        public int? PopupStylistStatis { get; set; }
        [Column("IDSalonBackUP")]
        public int? IdsalonBackUp { get; set; }
        [Column("IDStylistBackUp")]
        public int? IdstylistBackUp { get; set; }
        [StringLength(5)]
        public string VersionWeb { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public int? SalonType { get; set; }
        public int? CityId { get; set; }
        public bool? IsClickVoucher { get; set; }
        public bool? IsClickChooseCity { get; set; }
        public bool? GuideSkipping { get; set; }
        public bool? GuideStep { get; set; }
    }
}