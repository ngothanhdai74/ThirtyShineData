﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class BillDiscount
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public bool? IsService { get; set; }
        public int? ProductServiceId { get; set; }
        public double? DiscountPercent { get; set; }
        public bool? IsAddedBySalon { get; set; }
        [StringLength(300)]
        public string DiscountReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(200)]
        public string DiscountSource { get; set; }
    }
}