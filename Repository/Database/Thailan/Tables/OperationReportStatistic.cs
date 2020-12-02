﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class OperationReportStatistic
    {
        [Key]
        public int Id { get; set; }
        public int SalonId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifedDate { get; set; }
        public bool IsDelete { get; set; }
        public int? TotalBill { get; set; }
        public int? BillOldCustomer { get; set; }
        public int? BillNewCustomer { get; set; }
        public int? BookInAdvance { get; set; }
        public int? CancelBook { get; set; }
        public int? BookAll { get; set; }
        public int? TotalBuyShineMember { get; set; }
        public int? NewCustomerMember { get; set; }
        public int? OldCustomerMember { get; set; }
        public int? ShineMemberComeBack { get; set; }
        public int? TotalIncomePerShineMember { get; set; }
        [Column(TypeName = "decimal(19, 2)")]
        public decimal? TotalIncomePerStylist { get; set; }
        [Column(TypeName = "decimal(19, 2)")]
        public decimal? TotalBillPerStylist { get; set; }
        [Column(TypeName = "decimal(19, 2)")]
        public decimal? TotalIncomePerTime { get; set; }
        [Column(TypeName = "decimal(19, 2)")]
        public decimal? TotalBillPerTime { get; set; }
        [Column(TypeName = "decimal(19, 2)")]
        public decimal? TotalStylistWorkTime { get; set; }
        [Column(TypeName = "decimal(19, 2)")]
        public decimal? TotalSkinnerWorkTime { get; set; }
        public int? AvgRating { get; set; }
        public int? Mark1and2 { get; set; }
        public int? StaffError { get; set; }
        public int? LongWait { get; set; }
        public int? BillWithoutImage { get; set; }
        [StringLength(2000)]
        public string Revenue { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public int? SpecialCustomer { get; set; }
        public int? TotalIncome { get; set; }
    }
}