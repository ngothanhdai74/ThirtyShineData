﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class StynextBill
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int? StylistId { get; set; }
        public int? SkinnerId { get; set; }
        public int? StynextGroupId { get; set; }
        public int? GroupLeaderId { get; set; }
        public int? SalonId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? BillDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? ReturnAfterDays { get; set; }
        public bool? IsGuaranteed { get; set; }
        public int? ReturnBillId { get; set; }
        public int? CheckinId { get; set; }
        public double? ServiceUpsaleMoney { get; set; }
        public int? BookingId { get; set; }
    }
}