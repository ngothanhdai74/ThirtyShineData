﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class ManagerLog
    {
        public int Id { get; set; }
        public int? SalonId { get; set; }
        public DateTime? Today { get; set; }
        public int? MinWorkHour1st { get; set; }
        public int? WorkHourOf1stDay { get; set; }
        public int? MaxWorkHour1st { get; set; }
        public int? MinWorkHour2ndDay { get; set; }
        public int? WorkHourOf2ndDay { get; set; }
        public int? MaxWorkHour2nd { get; set; }
        public int? MinWorkHour3rd { get; set; }
        public int? WorkHourOf3rdDay { get; set; }
        public int? MaxWorkHour3rd { get; set; }
        public bool? ConfirmTimekeeping { get; set; }
        public byte? TotalSlot5C { get; set; }
        public bool? ConfirmBillToday { get; set; }
        public byte? ConfirmServicesToday { get; set; }
        public byte? ConfirmGoodsToday { get; set; }
        public byte? ConfirmServicesTomorrow { get; set; }
        public byte? ConfirmGoodsTomorrow { get; set; }
        public bool? ReportLimitedFacilities { get; set; }
        public byte? FeedbackOfFacilities { get; set; }
        public byte? YetAcceptanceOfFacilites { get; set; }
        public byte? NoImportantFacilitesProblem { get; set; }
        public string NoteLimitedFacilities { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public string InspectionImages { get; set; }
    }
}