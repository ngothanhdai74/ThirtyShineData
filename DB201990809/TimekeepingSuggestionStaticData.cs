﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class TimekeepingSuggestionStaticData
    {
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public DateTime? WorkDate { get; set; }
        public int? SubHourId { get; set; }
        public int? BookingCount { get; set; }
        public int? SlotCount { get; set; }
        public int? SuggestedSlotCount { get; set; }
        public string Weekday { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? HourId { get; set; }
    }
}