﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class IvInventoryHistory
    {
        [Key]
        public int Id { get; set; }
        public int? InventoryId { get; set; }
        public int ProductId { get; set; }
        public double Cost { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AccountingDate { get; set; }
        public int? Begin { get; set; }
        public int? Import { get; set; }
        public int? Export { get; set; }
        public int? SellOrUse { get; set; }
        public int? End { get; set; }
        public double? Volume { get; set; }
        public double? Quantify { get; set; }
        public double? VolumeRemain { get; set; }
        public int? SuggestOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDelete { get; set; }
        public int UsedInService { get; set; }
        public int ExportToStaff { get; set; }
        [Column("ExportToMainWH")]
        public int ExportToMainWh { get; set; }
        public int ExportToSalon { get; set; }
        public int ImportFromPartner { get; set; }
        public int ImportFromSalon { get; set; }
        public int ImportFromStaff { get; set; }
        public int ImportFromReturn { get; set; }
        public int BeingTransported { get; set; }
        [Column("ImportFromMainWH")]
        public int ImportFromMainWh { get; set; }
    }
}