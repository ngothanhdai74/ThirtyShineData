﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class ServiceSalonTypeConfig
    {
        public int Id { get; set; }
        public int? SalonType { get; set; }
        public int? DepartmentId { get; set; }
        public int? ServiceId { get; set; }
        public double? ServiceCoefficient { get; set; }
        public double? ServiceBonus { get; set; }
        public double? CoefficientOvertimeHour { get; set; }
        public double? CoefficientOvertimeDay { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
    }
}