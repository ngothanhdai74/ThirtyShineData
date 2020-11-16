﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class IvInventoryCurrentTrace
    {
        [Key]
        public int Id { get; set; }
        public int? InventoryId { get; set; }
        public int? ProductId { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? MaxInventorySuggest { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? UsedEnd { get; set; }
        public bool? IsOrder { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AccountingDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public bool IsDelete { get; set; }
        public int? InventoryCurrentId { get; set; }
        public bool? IsEnough { get; set; }
        [StringLength(100)]
        public string TypeCheck { get; set; }
    }
}