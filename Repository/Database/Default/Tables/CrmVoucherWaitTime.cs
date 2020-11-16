﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("CRM_VoucherWaitTime")]
    public partial class CrmVoucherWaitTime
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("BillID")]
        public int? BillId { get; set; }
        [Column("CustomerID")]
        public int? CustomerId { get; set; }
        [Column("CheckinID")]
        public int? CheckinId { get; set; }
        [Column("StylistID")]
        public int? StylistId { get; set; }
        [Column("SkinnerID")]
        public int? SkinnerId { get; set; }
        [Column("SalonID")]
        public int? SalonId { get; set; }
        public double? VoucherPercent { get; set; }
        public bool? IsUsed { get; set; }
        public bool? IsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public double? CheckinPoint { get; set; }
        public double? CheckinMoney { get; set; }
        public double? SkinnerPoint { get; set; }
        public double? SkinnerMoney { get; set; }
        public double? StylistPoint { get; set; }
        public double? StylistMoney { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}