﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? SnDay { get; set; }
        public int? SnMonth { get; set; }
        public int? SnYear { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string CustomerCode { get; set; }
        public int? InfoFlow { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public byte? Publish { get; set; }
        public byte? IsDelete { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? SalonId { get; set; }
        public string FingerTemplate { get; set; }
        public string FingerToken { get; set; }
        public byte[] FingerTemplateBn { get; set; }
        public bool? IsAppointment { get; set; }
        public string CustomerCode1 { get; set; }
        public bool? DeleteByDuplicate { get; set; }
        public bool? IsNoInfor { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }
        public bool? IsOld { get; set; }
        public string FacebookId { get; set; }
        public string Avatar { get; set; }
        public int? TotalPoint { get; set; }
        public bool? IsSms { get; set; }
        public string GoogleId { get; set; }
        public string CheckCode { get; set; }
        public int? ThreadId { get; set; }
        public bool? Veryfied { get; set; }
        public int? ChatbotFacebookId { get; set; }
        public int? TotalMoneyBillservice { get; set; }
        public int? TotalBillservice { get; set; }
        public string Otp { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public int? St1 { get; set; }
        public int? St2 { get; set; }
        public int? Salon1 { get; set; }
        public int? Salon2 { get; set; }
        public double Score { get; set; }
        public DateTime? DateLastBillService { get; set; }
        public int? MemberType { get; set; }
        public DateTime? MemberStartTime { get; set; }
        public DateTime? MemberEndTime { get; set; }
        public int? MemberProductId { get; set; }
        public string Occupation { get; set; }
        public int? WardId { get; set; }
        public int? LastBillId { get; set; }
    }
}