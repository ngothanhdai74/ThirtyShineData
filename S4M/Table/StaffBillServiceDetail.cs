﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class StaffBillServiceDetail
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int ServiceId { get; set; }
        public int DepartmentId { get; set; }
        public int StaffId { get; set; }
        public int StaffLevelId { get; set; }
        public int OvertimeStatusValue { get; set; }
        public double RatingMark { get; set; }
        public double RatingMoney { get; set; }
        public double SalaryCoeficient { get; set; }
        public double ServiceCoeficient { get; set; }
        public double ServiceIncomeBonus { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? ModifyTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? WorkDate { get; set; }
        public int Quantity { get; set; }
        public double ConventionPoint { get; set; }
        public double? ServiceBonus { get; set; }
        public int BillSalonId { get; set; }
    }
}