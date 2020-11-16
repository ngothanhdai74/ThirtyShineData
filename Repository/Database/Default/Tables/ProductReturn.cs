﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class ProductReturn
    {
        [Key]
        public int Id { get; set; }
        public int? BillId { get; set; }
        public int? SalonSellId { get; set; }
        public int? SalonReceiveId { get; set; }
        public int? SellerId { get; set; }
        public int? ReceiverId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public double? PriceProduct { get; set; }
        public int? ForSalary { get; set; }
        public int? VoucherPercent { get; set; }
        public double? ProductSalary { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOfBill { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ReturnMethod { get; set; }
    }
}