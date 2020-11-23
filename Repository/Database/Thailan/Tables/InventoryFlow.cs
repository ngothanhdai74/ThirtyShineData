﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Inventory_Flow")]
    public partial class InventoryFlow
    {
        [Key]
        public int Id { get; set; }
        public int? InvenId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? Cost { get; set; }
        public int? Price { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}