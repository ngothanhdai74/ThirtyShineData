﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Booking_Suggest")]
    public partial class BookingSuggest
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string CustomerPhone { get; set; }
        [StringLength(200)]
        public string CustomerName { get; set; }
        public int? SalonId { get; set; }
        public int? SalonSuggestId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsCall { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}