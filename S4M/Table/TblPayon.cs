﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class TblPayon
    {
        public int Id { get; set; }
        /// <summary>
        /// Bộ phận nhân viên Id...
        /// </summary>
        public int? TypeStaffId { get; set; }
        /// <summary>
        /// Id dịch vụ, sản phẩm...
        /// </summary>
        public int? KeyId { get; set; }
        /// <summary>
        /// Id bậc kỹ năng...
        /// </summary>
        public int? ForeignId { get; set; }
        /// <summary>
        /// Giá trị trả cho nhân viên trên mỗi sản phẩm hoặc dịch vụ
        /// </summary>
        public int? Value { get; set; }
        public string Hint { get; set; }
        public bool? Publish { get; set; }
        public byte? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Lương cứng
        /// </summary>
        public int? BaseSalary { get; set; }
        /// <summary>
        /// Cách tính lương cứng : 1 - Theo tháng | 2 - Theo ngày| 3 - Lương part-time | 4 -  Lương phụ cấp | 5 - Hệ số điểm hài lòng | 6 - Hệ số bill | 7 - Hệ số khách quay lại
        /// </summary>
        public byte? PayByTime { get; set; }
        public string Description { get; set; }
        public int? StaffId { get; set; }
        public string Key { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}