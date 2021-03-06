﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("Stylist4Men_Class")]
    public partial class Stylist4MenClass
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Tên lớp học
        /// </summary>
        [StringLength(200)]
        public string Name { get; set; }
        /// <summary>
        /// Ghi chú
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// Ngày bắt đầu (Khai giảng)
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// Ngày tốt nghiệp (Hoàn thành khóa học)
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? GraduateTime { get; set; }
        public bool? Publish { get; set; }
        public bool? IsDelete { get; set; }
        /// <summary>
        /// Thời gian tạo bản ghi
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        /// <summary>
        /// Thời gian sửa lần gần nhất
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        /// <summary>
        /// Trụ sở đào tạo (Sẽ ở 1 salon nào đó)
        /// </summary>
        public int? SalonId { get; set; }
        public int? HomeRoomTeacherId { get; set; }
        public int? TeacherPointCutId { get; set; }
        public int? TeacherOfTheClubId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}