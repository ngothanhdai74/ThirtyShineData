﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class TopSalary
    {
        public int Id { get; set; }
        /// <summary>
        /// Id bộ phận
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// Id của nhân viên
        /// </summary>
        public int StaffId { get; set; }
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string StaffName { get; set; }
        /// <summary>
        /// Tên salon
        /// </summary>
        public string SalonName { get; set; }
        /// <summary>
        /// level
        /// </summary>
        public string SkillLevel { get; set; }
        /// <summary>
        /// Lương
        /// </summary>
        public double Salary { get; set; }
        /// <summary>
        /// tháng
        /// </summary>
        public int Month { get; set; }
        /// <summary>
        /// năm
        /// </summary>
        public int Year { get; set; }
        public DateTime CreateTime { get; set; }
        public bool? IsDelete { get; set; }
    }
}