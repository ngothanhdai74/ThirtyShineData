﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Statistics_XuatVatTu")]
    public partial class StatisticsXuatVatTu
    {
        /// <summary>
        /// ID : Tự tăng
        /// 
        /// </summary>
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        /// <summary>
        /// 0
        /// </summary>
        [Key]
        [Column("ExportGoods_ID")]
        public int ExportGoodsId { get; set; }
        /// <summary>
        /// tổng bill trong lần xuất vâth tư
        /// </summary>
        [Column("TotalBill_XuatVatTu")]
        public int? TotalBillXuatVatTu { get; set; }
        /// <summary>
        /// Nhân viên được xuất vật tư
        /// </summary>
        [Column("Staff_ID")]
        public int? StaffId { get; set; }
        /// <summary>
        /// Salon được xuất vật tư 
        /// </summary>
        [Column("Salon_ID")]
        public int? SalonId { get; set; }
        /// <summary>
        /// Ngày xuất vật tư
        /// </summary>
        [Column("Date_XuatVatTu", TypeName = "date")]
        public DateTime? DateXuatVatTu { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        /// <summary>
        /// Cập nhật trạng thái xóa hay không (1 là đã xóa ? 0 là chưa xóa).
        /// </summary>
        public bool? IsDelete { get; set; }
        [Column("Product_ID")]
        public int? ProductId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}