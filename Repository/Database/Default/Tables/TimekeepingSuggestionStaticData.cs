﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class TimekeepingSuggestionStaticData
    {
        public int Id { get; set; }
        public int? SalonId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkDate { get; set; }
        public int? SubHourId { get; set; }
        public int? BookingCount { get; set; }
        public int? SlotCount { get; set; }
        public int? SuggestedSlotCount { get; set; }
        [StringLength(30)]
        public string Weekday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? HourId { get; set; }
    }
}