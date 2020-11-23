﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Inventory_Import")]
    public partial class InventoryImport
    {
        [Key]
        public int Id { get; set; }
        public string ProductIds { get; set; }
        public int? TotalMoney { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompleteBillTime { get; set; }
        public bool? IsDelete { get; set; }
        public int? SalonId { get; set; }
        /// <summary>
        /// Id người nhận
        /// </summary>
        public int? RecipientId { get; set; }
        /// <summary>
        /// Id người nhập liệu
        /// </summary>
        public int? DoId { get; set; }
        public string Note { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ImportDate { get; set; }
        public int? ImportType { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}