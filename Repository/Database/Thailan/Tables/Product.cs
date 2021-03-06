﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        public int? Type { get; set; }
        public int? Price { get; set; }
        [Column("Old_Price")]
        public int? OldPrice { get; set; }
        public byte? IsVoucher { get; set; }
        public int? VoucherValue { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Column(TypeName = "ntext")]
        public string TechInfo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? Publish { get; set; }
        public byte? IsDelete { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? VoucherPercent { get; set; }
        public byte? Status { get; set; }
        public int? Cost { get; set; }
        public double? ForSalary { get; set; }
        public int? CategoryId { get; set; }
        public int? OnWebId { get; set; }
        public int? BrandId { get; set; }
        [StringLength(300)]
        public string Volume { get; set; }
        [StringLength(300)]
        public string ModelName { get; set; }
        public string MapIdProduct { get; set; }
        public int? PriceCombo { get; set; }
        public bool? CheckCombo { get; set; }
        public int? Order { get; set; }
        [Column("CheckInventoryHC")]
        public bool? CheckInventoryHc { get; set; }
        public int? GroupProductId { get; set; }
        public bool? IsCheckVatTu { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        [StringLength(50)]
        public string BarCode { get; set; }
        public int? MemberTypeAdd { get; set; }
        public int? MemberAddDay { get; set; }
        [StringLength(20)]
        public string InventoryType { get; set; }
        public int CoefficientOfWaitingDays { get; set; }
        public int StopBusiness { get; set; }
        [Column("unit")]
        [StringLength(20)]
        public string Unit { get; set; }
        [Column("Check_pro")]
        public bool? CheckPro { get; set; }
        [Column("image")]
        [StringLength(2000)]
        public string Image { get; set; }
        [Column("CampID")]
        public int? CampId { get; set; }
        public int? ExpDate { get; set; }
        [StringLength(20)]
        public string MemberCode { get; set; }
        public int IsPrepaid { get; set; }
        public bool IsNotCheck { get; set; }
        public int? MemberProductGroup { get; set; }
    }
}