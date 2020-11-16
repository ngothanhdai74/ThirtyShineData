﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class SalonDailyCost
    {
        [Key]
        public int Id { get; set; }
        public int SalonId { get; set; }
        public double ElectricityAndWaterBill { get; set; }
        public double RentWithTax { get; set; }
        public double CapitalSpending { get; set; }
        public double AdvertisementExpend { get; set; }
        public double ShippingExpend { get; set; }
        public double InternetAndPhoneBill { get; set; }
        public double SocialInsuranceAndFixedCost { get; set; }
        public double IncomeTaxes { get; set; }
        public double SalonUnplannedSpending { get; set; }
        public double ThaiHaRentAndSeviceCost { get; set; }
        public double OfficeStaffSalary { get; set; }
        public double SalesSalary { get; set; }
        public double ItSalary { get; set; }
        public double OfficeStaffSocialInsurance { get; set; }
        public double UnplannedSpending { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReportDate { get; set; }
        public bool IsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifyTime { get; set; }
        public double DailyCostInventory { get; set; }
        public double ProductPrice { get; set; }
        public double Compensation { get; set; }
        public double OtherIncome { get; set; }
        [Column("SMDistribution")]
        public double Smdistribution { get; set; }
        [Column("PayOffKCS")]
        public double PayOffKcs { get; set; }
        [Column("SMSExpenses")]
        public double Smsexpenses { get; set; }
        public double Tax { get; set; }
        public double SecurityCheckoutSalary { get; set; }
    }
}