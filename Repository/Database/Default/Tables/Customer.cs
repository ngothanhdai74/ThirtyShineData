﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Fullname { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [Column("SN_day")]
        public int? SnDay { get; set; }
        [Column("SN_month")]
        public int? SnMonth { get; set; }
        [Column("SN_year")]
        public int? SnYear { get; set; }
        public int? Age { get; set; }
        [Column(TypeName = "ntext")]
        public string Address { get; set; }
        [Column("Customer_Code")]
        [StringLength(50)]
        public string CustomerCode { get; set; }
        [Column("Info_Flow")]
        public int? InfoFlow { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public byte? Publish { get; set; }
        public byte? IsDelete { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? SalonId { get; set; }
        public string FingerTemplate { get; set; }
        [StringLength(20)]
        public string FingerToken { get; set; }
        public byte[] FingerTemplateBn { get; set; }
        public bool? IsAppointment { get; set; }
        [Column("Customer_Code1")]
        [StringLength(50)]
        public string CustomerCode1 { get; set; }
        public bool? DeleteByDuplicate { get; set; }
        [Column("isNoInfor")]
        public bool? IsNoInfor { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(250)]
        public string AccessToken { get; set; }
        public bool? IsOld { get; set; }
        [StringLength(150)]
        public string FacebookId { get; set; }
        public string Avatar { get; set; }
        public int? TotalPoint { get; set; }
        public bool? IsSms { get; set; }
        [StringLength(150)]
        public string GoogleId { get; set; }
        [StringLength(10)]
        public string CheckCode { get; set; }
        public int? ThreadId { get; set; }
        public bool? Veryfied { get; set; }
        public int? ChatbotFacebookId { get; set; }
        public int? TotalMoneyBillservice { get; set; }
        public int? TotalBillservice { get; set; }
        [Column("OTP")]
        [StringLength(10)]
        public string Otp { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public int? St1 { get; set; }
        public int? St2 { get; set; }
        public int? Salon1 { get; set; }
        public int? Salon2 { get; set; }
        public double Score { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateLastBillService { get; set; }
        public int? MemberType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MemberStartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MemberEndTime { get; set; }
        public int? MemberProductId { get; set; }
        [StringLength(30)]
        public string Occupation { get; set; }
        public int? WardId { get; set; }
        public int? LastBillId { get; set; }
        public bool? IsAnonymous { get; set; }
    }
}