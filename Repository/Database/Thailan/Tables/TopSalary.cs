﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class TopSalary
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Id bộ phận
        /// </summary>
        [Column("departmentId")]
        public int DepartmentId { get; set; }
        /// <summary>
        /// Id của nhân viên
        /// </summary>
        [Column("staffId")]
        public int StaffId { get; set; }
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        [Required]
        [Column("staffName")]
        [StringLength(100)]
        public string StaffName { get; set; }
        /// <summary>
        /// Tên salon
        /// </summary>
        [Required]
        [Column("salonName")]
        [StringLength(500)]
        public string SalonName { get; set; }
        /// <summary>
        /// level
        /// </summary>
        [Required]
        [Column("skillLevel")]
        [StringLength(100)]
        public string SkillLevel { get; set; }
        /// <summary>
        /// Lương
        /// </summary>
        [Column("salary")]
        public double Salary { get; set; }
        /// <summary>
        /// tháng
        /// </summary>
        [Column("month")]
        public int Month { get; set; }
        /// <summary>
        /// năm
        /// </summary>
        [Column("year")]
        public int Year { get; set; }
        [Column("createTime", TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
        [Column("isDelete")]
        public bool? IsDelete { get; set; }
    }
}