﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class SmBillTempFlowService
    {
        public int Id { get; set; }
        public int? BillId { get; set; }
        public int? ServiceId { get; set; }
        public int? Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? IsDelete { get; set; }
        public int? Quantity { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? SalonId { get; set; }
        public int? SellerId { get; set; }
        public double? VoucherPercent { get; set; }
        public byte? CoefficientRating { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}