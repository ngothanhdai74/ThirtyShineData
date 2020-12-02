﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class IvOrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? QuantityType1 { get; set; }
        public int? QuantityType2 { get; set; }
        public int? QuantityType3 { get; set; }
        public int? QuantityType4 { get; set; }
        public int? QuantityType5 { get; set; }
        public int? QuantitySuggest { get; set; }
        public int? QuantityOrder { get; set; }
        public int? QuantityExport { get; set; }
        public int? QuantityImport { get; set; }
        public int? Cost { get; set; }
        public bool? IsAuto { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDelete { get; set; }
        public int SalonReason { get; set; }
        [Column("WHReason")]
        public int Whreason { get; set; }
    }
}