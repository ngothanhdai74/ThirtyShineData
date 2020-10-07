﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class Stylist4MenStudent
    {
        public int Id { get; set; }
        /// <summary>
        /// Tên đầy đủ
        /// </summary>
        public string Fullname { get; set; }
        /// <summary>
        /// Giới tính : 1|Nam, 2|Nữ, 3|Khác
        /// </summary>
        public byte? Gender { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Email (Hoặc tên đăng nhập)
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Mật khẩu đăng nhập (App)
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public int? SnDay { get; set; }
        /// <summary>
        /// Tháng sinh
        /// </summary>
        public int? SnMonth { get; set; }
        /// <summary>
        /// Năm sinh
        /// </summary>
        public int? SnYear { get; set; }
        /// <summary>
        /// Thành phố ID
        /// </summary>
        public int? CityId { get; set; }
        /// <summary>
        /// Quân/Huyện ID
        /// </summary>
        public int? DistrictId { get; set; }
        /// <summary>
        /// Địa chỉ cụ thể
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Class ID
        /// </summary>
        public int? ClassId { get; set; }
        /// <summary>
        /// True | Đã tốt nghiệp, False | Chưa tốt nghiệp
        /// </summary>
        public bool? IsGraduate { get; set; }
        /// <summary>
        /// True|Học viên được nhận làm nhân viên của 30Shine
        /// </summary>
        public bool? IsHire { get; set; }
        /// <summary>
        /// Thời gian tạo bản ghi
        /// </summary>
        public DateTime? CreatedTime { get; set; }
        /// <summary>
        /// Thời gian chỉnh sửa bản ghi lần cuối
        /// </summary>
        public DateTime? ModifiedTime { get; set; }
        /// <summary>
        /// True|Xuất bản bản ghi, False|Không xuất bản bản ghi
        /// </summary>
        public bool? Publish { get; set; }
        /// <summary>
        /// True|Đánh dấu bản ghi sang trạng thái xóa
        /// </summary>
        public bool? IsDelete { get; set; }
        public string Note { get; set; }
        public string ImageCmt1 { get; set; }
        public string ImageCmt2 { get; set; }
        public int? NumberOfCreateProfile { get; set; }
        public bool? IsAccept { get; set; }
        public int? TotalAmountCollected { get; set; }
        public int? TotalAmountPaid { get; set; }
        public int? TotalBill { get; set; }
        public int? LevelOfConcern { get; set; }
        public int? StudyPackageId { get; set; }
        public string NumberCmt { get; set; }
        public int? PointLtcat { get; set; }
        public int? Vote { get; set; }
        public string Images { get; set; }
        public int? PointTheoryCut { get; set; }
        public int? SalonId { get; set; }
        public int? StatusTuition { get; set; }
        public int? PointLtkn { get; set; }
        public int? Type { get; set; }
        public int? StaffId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}